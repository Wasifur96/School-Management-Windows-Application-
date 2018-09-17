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
    public partial class Student_course : Form
    {
        public Student_course()
        {
            InitializeComponent();
        }


        all_classDataContext db = new all_classDataContext();


        private void Student_course_Load(object sender, EventArgs e)
        {
            string search_text = textBox1.Text;
            var prods = from p in db.Notes
                        //where p.Name.Contains(search_text)
                        select new { p.Note_Id , p.Note_link  };
            DGV.DataSource = db.Notes;
            _2nd_frame fn = new _2nd_frame();
            name.Text = _2nd_frame.Getname2nd();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            _2nd_frame log = new _2nd_frame();
            log.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Student_home teach = new Student_home();
            teach.Show();
        }

        private void Assign1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The last date of Your assignment is 10/5/2018 .. \n No let submisson !! ");
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search_text = textBox1.Text;
            var prods = from p in db.Notes
                            where p.Note_link.Contains(search_text)
                        select new { p.Note_Id, p.Note_link };
            DGV.DataSource = prods;
        }
    }
}
