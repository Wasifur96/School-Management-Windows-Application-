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
    public partial class _2nd_frame : Form
    {
        all_classDataContext data = new all_classDataContext();

        
        public _2nd_frame()
        {
            InitializeComponent();
        }
        public static string name;
        public static int userid;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && pass.Text != "")
            {
                userid = int.Parse(id.Text);
                if (teacher.Checked)
                {

                    /*var teach = (from Teacher in data.Teachers
                                 where Teacher.teacher_Id == int.Parse(id.Text)

                                 select Teacher.Password).First();*/
                    int count = 0;

                    foreach(var Line in data.Teachers)
                    {
                        if(Line.teacher_Id== int.Parse(id.Text) && Line.Password == pass.Text)
                        {
                            count = 1;
                            name = Line.Name;
                            this.Close();
                            Teacher_home techer = new Teacher_home();
                            techer.Show();
                        }

                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Mismatch");
                    }




                    /*if (teach !=null && pass.Text.Equals(teach.ToString() ))
                    {
                        this.Close();
                        Teacher_home techer = new Teacher_home();
                        techer.Show();
                      
                        
                    }
                    else
                        MessageBox.Show("Mismatch");*/
                }
                else if (student.Checked)
                {
                    int count = 0;

                    foreach (var Line in data.students)
                    {
                        
                        if (Line.Student_Id == int.Parse(id.Text) && Line.Password == pass.Text)
                        {
                            count = 1;
                            name = Line.Name;
                            //MessageBox.Show(name);

                            this.Close();
                           
                            Student_home stu = new Student_home();
                          //  stu
                            stu.Show();
                        }

                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Mismatch");
                    }
                }
                else if (admin.Checked)
                {


                    int count = 0;

                    foreach (var Line in data.Admins)
                    {
                        if (Line.Admin_Id == int.Parse(id.Text) && Line.Password.Equals(pass.Text))
                        {
                            count = 1;
                            name = Line.Name;
                            this.Close();
                            Admin_home ad = new Admin_home();
                            ad.Show();
                        }

                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Mismatch");
                    }
                }
                else
                    MessageBox.Show("Wrong selection");
            }
            else
                MessageBox.Show("No input");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      static  public string Getname2nd()
        {
            return name;
        }
      static public int Getid()
        {
            return userid;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void _2nd_frame_Load(object sender, EventArgs e)
        {

        }
    }
}
