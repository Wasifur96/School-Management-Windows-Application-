using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SchoolManagements
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Table' table. You can move, or remove it, as needed.
           // this.tableTableAdapter.Fill(this.schoolDataSet.Table);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _2nd_frame Log = new _2nd_frame();
            Log.Show();
            
        }

        private void news1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.badchs.edu.bd/PublicSite/Bangla/NewsWebForm.aspx");
        }

        private void notice1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.badchs.edu.bd/PublicSite/Bangla/NoticeWebForm.aspx");
        }
    }
}
