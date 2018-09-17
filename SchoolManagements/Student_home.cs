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
    public partial class Student_home : Form
    {
        public Student_home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            Course cs = new Course();
            //if(comboBox1.SelectedItem==)
            this.Close();
            _2nd_frame fn = new _2nd_frame();
            //MessageBox.Show(_2nd_frame.Getname2nd());
            Student_course stu_c = new Student_course();
            stu_c.Show();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            _2nd_frame t = new _2nd_frame();
            t.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            _2nd_frame fn = new _2nd_frame();
            lblname.Text = _2nd_frame.Getname2nd();
        }
        
        private void Student_home_Load(object sender, EventArgs e)
        {
            _2nd_frame fn = new _2nd_frame();
            lblname.Text = _2nd_frame.Getname2nd();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            all_classDataContext db = new all_classDataContext();
            int id = _2nd_frame.Getid();
            student stu = db.students.SingleOrDefault(x => x.Student_Id == id);
            stu.Password = pass.Text;
            //prod.price = float.Parse(textBox2.Text);
            db.SubmitChanges();
            MessageBox.Show("password changed");
        }
    }
}
