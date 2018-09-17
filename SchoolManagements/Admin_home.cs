using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagements
{
    public partial class Admin_home : Form
    {
        all_classDataContext db = new all_classDataContext();
        public Admin_home()
        {
            InitializeComponent();




        }

        int couese_id;

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Admin_home_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            _2nd_frame fn = new _2nd_frame();
            name.Text = _2nd_frame.Getname2nd();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            _2nd_frame log = new _2nd_frame();

            log.Show();
        }
        static int i = 1;
        private void insClass_Click(object sender, EventArgs e)
        {

            if (ClassID.Text == "")
            {

                if (className.Text == "")
                {
                    MessageBox.Show("Class id or Class name can not be blank");
                }
                else
                {
                    var cr = new Course
                    {
                        Name = className.Text
                        //Course_Id = int.Parse(ClassID.Text),
                        //TID = int.Parse(TechID.Text),
                        //SID = int.Parse(StuID.Text),
                        //NID = i++
                    };
                    db.Courses.InsertOnSubmit(cr);
                    db.SubmitChanges();
                }
                
            }
            else
            {
                MessageBox.Show("ID will be auto genereted. Leave it blank.");
                ClassID.Text = "";
            }
            
             // dgv.DataSource = db.Courses;
            //StuID.Text = "";
           // TechID.Text = "";        
           className.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            all_classDataContext db = new all_classDataContext();
            string search_text = TechID.Text;
            var prods = from p in db.Teachers
                        where p.Name.Contains(search_text)
                        select new { p.Id, p.Name, p.Notes, p.Note_Id };
            dgv.DataSource = prods;
        }

        private void addClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void insTech_Click(object sender, EventArgs e)
        {

            if (TechID.Text == "")
            {
                if (TechName.Text == "" || TechPass.Text == "")
                {
                    MessageBox.Show("Teacher id or teacher name or Teacher Password can not be blank");
                }
                else
                {
                    var te = new Teacher
                    {
                        //teacher_Id = int.Parse(TechID.Text),
                        Name = TechName.Text,
                        Password = TechPass.Text
                    };

                    db.Teachers.InsertOnSubmit(te);
                    db.SubmitChanges();
                }
            }
            else
                MessageBox.Show("ID will be auto genereted. Leave it blank.");
            dgv.DataSource = db.Teachers;
            TechID.Text = "";
            TechName.Text = "";
            TechPass.Text = "";
        }

        private void insStudent_Click(object sender, EventArgs e)
        {
            if (StuID.Text == "")
            {
                if (StuName.Text == "" || StuPass.Text == "")
                {
                    MessageBox.Show("Student id or Student or Student password name can not be blank");
                }
                else
                {
                    var st = new student
                    {
                        //Student_Id = int.Parse(StuID.Text),
                        Name = StuName.Text,
                        Password = StuPass.Text
                    };

                    db.students.InsertOnSubmit(st);
                    db.SubmitChanges();
                }
            }
            else
                MessageBox.Show("ID will be auto genereted. Leave it blank.");
            dgv.DataSource = db.students;
            StuID.Text = "";
            StuName.Text = "";
            StuPass.Text = "";
        }

        private void insAdmin_Click(object sender, EventArgs e)
        {
            if (AdminId.Text == "" || AdminName.Text == "" || AdminPass.Text == "")
            {
                MessageBox.Show("Admin id or Admin name or Admin password can not be blank");
            }
            else
            {
                var ad = new Admin
                {
                    Admin_Id = int.Parse(AdminId.Text),
                    Name = AdminName.Text,
                    Password = AdminPass.Text
                };

                db.Admins.InsertOnSubmit(ad);
                db.SubmitChanges();
            }

            dgv.DataSource = db.Admins;
            AdminId.Text = "";
            AdminName.Text = "";
            AdminPass.Text = "";
        }

        private void acc_set_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClassID.Text == "")
            {
                MessageBox.Show("Class id or Class name can not be blank");
            }
            else
            {
                int id = int.Parse(ClassID.Text);
                student s = db.students.SingleOrDefault(x => x.Id == id);
                if (s != null)
                {
                    db.students.DeleteOnSubmit(s);

                    db.SubmitChanges();
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }

            dgv.DataSource = db.students;

            StuID.Text = "";
            TechID.Text = "";
            ClassID.Text = "";
            className.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (StuID.Text == "")
            {
                MessageBox.Show("Class id or Class name can not be blank");
            }
            else
            {
                int id = int.Parse(StuID.Text);
                student s = db.students.SingleOrDefault(x => x.Id == id);
                if (s != null)
                {
                    db.students.DeleteOnSubmit(s);

                    db.SubmitChanges();
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (AdminId.Text == "")
            {
                MessageBox.Show("Admin id or Admin name can not be blank");
            }
            else
            {
                int id = int.Parse(AdminId.Text);
                Admin s = db.Admins.SingleOrDefault(x => x.Admin_Id == id);
                if (s != null)
                {
                    db.Admins.DeleteOnSubmit(s);

                    db.SubmitChanges();
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TechID.Text == "")
            {
                MessageBox.Show("Teacher id or Teacher name can not be blank");
            }
            else
            {
                int id = int.Parse(TechID.Text);
                Teacher s = db.Teachers.SingleOrDefault(x => x.teacher_Id == id);
                if (s != null)
                {
                    db.Teachers.DeleteOnSubmit(s);

                    db.SubmitChanges();
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TechID.Text);
            //string name = textBox3.Text;
            Teacher s = db.Teachers.SingleOrDefault(x => x.Id == id);
            if (s != null)
            {
                TechName.Text = s.Name;
               // textBox2.Text = s.email;
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //all_classDataContext db = new all_classDataContext();
            string search_text = textBox1.Text;
            var prods = from p in db.Teachers
                        where p.Name.Contains(search_text)
                        select new { p.Id, p.Name, p.Notes, p.Note_Id };
            dgv.DataSource = prods;

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           // all_classDataContext db = new all_classDataContext();
            string search_text = textBox2.Text;
            var prods = from p in db.students
                        where p.Name.Contains(search_text)
                        select new { p.Id, p.Name};
            dgv.DataSource = prods;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_change_Click(object sender, EventArgs e)
        {
            all_classDataContext db = new all_classDataContext();
            int id = _2nd_frame.Getid();
            Admin stu = db.Admins.SingleOrDefault(x => x.Admin_Id == id);
            stu.Password = pass_change_box.Text;
            //prod.price = float.Parse(textBox2.Text);
            db.SubmitChanges();
            MessageBox.Show("password changed");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
