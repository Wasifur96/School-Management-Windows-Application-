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
    public partial class Teacher_Course : Form
    {
        all_classDataContext db = new all_classDataContext();

        public Teacher_Course()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _2nd_frame log = new _2nd_frame();
            log.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Teacher_home teach = new Teacher_home();
            teach.Show();
        }

        private void notes_Click(object sender, EventArgs e)
        {
            if (Note_Link.Text == "")
            {
                MessageBox.Show("The box can not be blank");
            }
            else
            {
                var n = new Note
                {
                    
                    Note_link = Note_Link.Text,
                  
                };

                db.Notes.InsertOnSubmit(n);
                db.SubmitChanges();
                MessageBox.Show("Note link is inserted .. ");
            }

        }

        private void Teacher_Course_Load(object sender, EventArgs e)
        {
            _2nd_frame fn = new _2nd_frame();
            label1.Text = _2nd_frame.Getname2nd();

        }

        private void search_stu_box_TextChanged(object sender, EventArgs e)
        {
            string search_text = search_stu_box.Text;
            var stus = from p in db.students
                        where p.Name.Contains(search_text)
                        select new { p.Id, p.Name };
            dgv1.DataSource = stus;
        }
    }
}
