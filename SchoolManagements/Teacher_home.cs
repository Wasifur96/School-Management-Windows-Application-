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
    public partial class Teacher_home : Form
    {
        public Teacher_home()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {
            
        }

        private void Teacher_home_Load(object sender, EventArgs e)
        {
            
            _2nd_frame fn = new _2nd_frame();
            name.Text = _2nd_frame.Getname2nd();
            //name.Visible = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            _2nd_frame log = new _2nd_frame();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher_Course stu_c = new Teacher_Course();
            stu_c.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (pass_fld.Text == "")
            { MessageBox.Show(" Empty feild "); }
            else
            {
                all_classDataContext db = new all_classDataContext();
                int id = _2nd_frame.Getid();
                Teacher stu = db.Teachers.SingleOrDefault(x => x.teacher_Id == id);
                stu.Password = pass_fld.Text;
                //prod.price = float.Parse(textBox2.Text);
                db.SubmitChanges();
                MessageBox.Show("password changed");
            }
        }

        private void pass_fld_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
