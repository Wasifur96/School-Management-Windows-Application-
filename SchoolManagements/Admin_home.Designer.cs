namespace SchoolManagements
{
    partial class Admin_home
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
            this.name = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.log_out = new System.Windows.Forms.Button();
            this.insAdmin = new System.Windows.Forms.Button();
            this.insStudent = new System.Windows.Forms.Button();
            this.insTech = new System.Windows.Forms.Button();
            this.insClass = new System.Windows.Forms.Button();
            this.ClassID = new System.Windows.Forms.TextBox();
            this.TechID = new System.Windows.Forms.TextBox();
            this.className = new System.Windows.Forms.TextBox();
            this.TechName = new System.Windows.Forms.TextBox();
            this.StuID = new System.Windows.Forms.TextBox();
            this.StuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.AdminId = new System.Windows.Forms.TextBox();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.TechPass = new System.Windows.Forms.TextBox();
            this.StuPass = new System.Windows.Forms.TextBox();
            this.AdminPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass_change_box = new System.Windows.Forms.TextBox();
            this.pass_change = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(360, 9);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(72, 25);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(640, 9);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(75, 23);
            this.log_out.TabIndex = 4;
            this.log_out.Text = "Log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // insAdmin
            // 
            this.insAdmin.Location = new System.Drawing.Point(34, 287);
            this.insAdmin.Name = "insAdmin";
            this.insAdmin.Size = new System.Drawing.Size(75, 23);
            this.insAdmin.TabIndex = 7;
            this.insAdmin.Text = "Insert Adm";
            this.insAdmin.UseVisualStyleBackColor = true;
            this.insAdmin.Click += new System.EventHandler(this.insAdmin_Click);
            // 
            // insStudent
            // 
            this.insStudent.Location = new System.Drawing.Point(34, 188);
            this.insStudent.Name = "insStudent";
            this.insStudent.Size = new System.Drawing.Size(75, 23);
            this.insStudent.TabIndex = 12;
            this.insStudent.Text = "Ins Stud";
            this.insStudent.UseVisualStyleBackColor = true;
            this.insStudent.Click += new System.EventHandler(this.insStudent_Click);
            // 
            // insTech
            // 
            this.insTech.Location = new System.Drawing.Point(34, 97);
            this.insTech.Name = "insTech";
            this.insTech.Size = new System.Drawing.Size(75, 23);
            this.insTech.TabIndex = 13;
            this.insTech.Text = "Ins tech";
            this.insTech.UseVisualStyleBackColor = true;
            this.insTech.Click += new System.EventHandler(this.insTech_Click);
            // 
            // insClass
            // 
            this.insClass.Location = new System.Drawing.Point(37, 368);
            this.insClass.Name = "insClass";
            this.insClass.Size = new System.Drawing.Size(75, 23);
            this.insClass.TabIndex = 14;
            this.insClass.Text = "Insert class";
            this.insClass.UseVisualStyleBackColor = true;
            this.insClass.Click += new System.EventHandler(this.insClass_Click);
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(21, 330);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(100, 20);
            this.ClassID.TabIndex = 15;
            this.ClassID.TextChanged += new System.EventHandler(this.addClass_TextChanged);
            // 
            // TechID
            // 
            this.TechID.Location = new System.Drawing.Point(14, 53);
            this.TechID.Name = "TechID";
            this.TechID.Size = new System.Drawing.Size(100, 20);
            this.TechID.TabIndex = 16;
            this.TechID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(143, 330);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(100, 20);
            this.className.TabIndex = 17;
            // 
            // TechName
            // 
            this.TechName.Location = new System.Drawing.Point(140, 52);
            this.TechName.Name = "TechName";
            this.TechName.Size = new System.Drawing.Size(100, 20);
            this.TechName.TabIndex = 18;
            // 
            // StuID
            // 
            this.StuID.Location = new System.Drawing.Point(17, 145);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(100, 20);
            this.StuID.TabIndex = 19;
            // 
            // StuName
            // 
            this.StuName.Location = new System.Drawing.Point(143, 147);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(100, 20);
            this.StuName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(568, 238);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(194, 185);
            this.dgv.TabIndex = 24;
            // 
            // AdminId
            // 
            this.AdminId.Location = new System.Drawing.Point(17, 247);
            this.AdminId.Name = "AdminId";
            this.AdminId.Size = new System.Drawing.Size(100, 20);
            this.AdminId.TabIndex = 25;
            // 
            // AdminName
            // 
            this.AdminName.Location = new System.Drawing.Point(143, 247);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(100, 20);
            this.AdminName.TabIndex = 26;
            // 
            // TechPass
            // 
            this.TechPass.Location = new System.Drawing.Point(262, 53);
            this.TechPass.Name = "TechPass";
            this.TechPass.Size = new System.Drawing.Size(100, 20);
            this.TechPass.TabIndex = 27;
            // 
            // StuPass
            // 
            this.StuPass.Location = new System.Drawing.Point(262, 148);
            this.StuPass.Name = "StuPass";
            this.StuPass.Size = new System.Drawing.Size(100, 20);
            this.StuPass.TabIndex = 28;
            // 
            // AdminPass
            // 
            this.AdminPass.Location = new System.Drawing.Point(262, 247);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.Size = new System.Drawing.Size(100, 20);
            this.AdminPass.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(143, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(143, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 35;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(273, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(273, 287);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(277, 365);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 39;
            this.button11.Text = "Search";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "search here by text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 42;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(396, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 43;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(396, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 44;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Search";
            // 
            // pass_change_box
            // 
            this.pass_change_box.Location = new System.Drawing.Point(52, 30);
            this.pass_change_box.Name = "pass_change_box";
            this.pass_change_box.Size = new System.Drawing.Size(100, 22);
            this.pass_change_box.TabIndex = 46;
            // 
            // pass_change
            // 
            this.pass_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_change.Location = new System.Drawing.Point(52, 69);
            this.pass_change.Name = "pass_change";
            this.pass_change.Size = new System.Drawing.Size(105, 23);
            this.pass_change.TabIndex = 47;
            this.pass_change.Text = "Change password";
            this.pass_change.UseVisualStyleBackColor = true;
            this.pass_change.Click += new System.EventHandler(this.pass_change_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.pass_change_box);
            this.groupBox1.Controls.Add(this.pass_change);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(568, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account settings";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.TechPass);
            this.groupBox2.Controls.Add(this.insAdmin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.insStudent);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.insTech);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.insClass);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.ClassID);
            this.groupBox2.Controls.Add(this.TechID);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.className);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.TechName);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.StuID);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.StuName);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.AdminId);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.AdminName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.StuPass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AdminPass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 415);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Management";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Admin_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.home);
            this.Controls.Add(this.name);
            this.Name = "Admin_home";
            this.Text = "Admin_home";
            this.Load += new System.EventHandler(this.Admin_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button insAdmin;
        private System.Windows.Forms.Button insStudent;
        private System.Windows.Forms.Button insTech;
        private System.Windows.Forms.Button insClass;
        private System.Windows.Forms.TextBox ClassID;
        private System.Windows.Forms.TextBox TechID;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.TextBox TechName;
        private System.Windows.Forms.TextBox StuID;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox AdminId;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.TextBox TechPass;
        private System.Windows.Forms.TextBox StuPass;
        private System.Windows.Forms.TextBox AdminPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass_change_box;
        private System.Windows.Forms.Button pass_change;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}