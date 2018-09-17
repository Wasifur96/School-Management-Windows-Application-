namespace SchoolManagements
{
    partial class Student_course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.note = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.log_out = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.noticeBox = new System.Windows.Forms.GroupBox();
            this.Assign1 = new System.Windows.Forms.LinkLabel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noticeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(108, 112);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(51, 20);
            this.note.TabIndex = 6;
            this.note.Text = "Notes";
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(313, 23);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(167, 25);
            this.home.TabIndex = 7;
            this.home.Text = "Course Details";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(23, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(112, 20);
            this.name.TabIndex = 8;
            this.name.Text = "Student Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(677, 13);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(75, 23);
            this.log_out.TabIndex = 9;
            this.log_out.Text = "Log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(677, 64);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 20;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // noticeBox
            // 
            this.noticeBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noticeBox.Controls.Add(this.Assign1);
            this.noticeBox.Location = new System.Drawing.Point(440, 112);
            this.noticeBox.Name = "noticeBox";
            this.noticeBox.Size = new System.Drawing.Size(200, 266);
            this.noticeBox.TabIndex = 21;
            this.noticeBox.TabStop = false;
            this.noticeBox.Text = "Notice Box";
            // 
            // Assign1
            // 
            this.Assign1.AutoSize = true;
            this.Assign1.LinkColor = System.Drawing.Color.Navy;
            this.Assign1.Location = new System.Drawing.Point(38, 35);
            this.Assign1.Name = "Assign1";
            this.Assign1.Size = new System.Drawing.Size(70, 13);
            this.Assign1.TabIndex = 0;
            this.Assign1.TabStop = true;
            this.Assign1.Text = "Assignment 1";
            this.Assign1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Assign1_LinkClicked);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(45, 228);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(240, 150);
            this.DGV.TabIndex = 22;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search Note Links :";
            // 
            // Student_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.noticeBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.name);
            this.Controls.Add(this.home);
            this.Controls.Add(this.note);
            this.Name = "Student_course";
            this.Text = "Student_course";
            this.Load += new System.EventHandler(this.Student_course_Load);
            this.noticeBox.ResumeLayout(false);
            this.noticeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox noticeBox;
        private System.Windows.Forms.LinkLabel Assign1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}