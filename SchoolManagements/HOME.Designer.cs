namespace SchoolManagements
{
    partial class HOME
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticeBox = new System.Windows.Forms.GroupBox();
            this.notice1 = new System.Windows.Forms.LinkLabel();
            this.NewsBox = new System.Windows.Forms.GroupBox();
            this.news1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.noticeBox.SuspendLayout();
            this.NewsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "WEB MAIL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // noticeBox
            // 
            this.noticeBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noticeBox.Controls.Add(this.notice1);
            this.noticeBox.Location = new System.Drawing.Point(66, 221);
            this.noticeBox.Name = "noticeBox";
            this.noticeBox.Size = new System.Drawing.Size(200, 217);
            this.noticeBox.TabIndex = 3;
            this.noticeBox.TabStop = false;
            this.noticeBox.Text = "Notice Box";
            // 
            // notice1
            // 
            this.notice1.AutoSize = true;
            this.notice1.LinkColor = System.Drawing.Color.Navy;
            this.notice1.Location = new System.Drawing.Point(17, 40);
            this.notice1.Name = "notice1";
            this.notice1.Size = new System.Drawing.Size(47, 13);
            this.notice1.TabIndex = 0;
            this.notice1.TabStop = true;
            this.notice1.Text = "Notice 1";
            this.notice1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notice1_LinkClicked);
            // 
            // NewsBox
            // 
            this.NewsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewsBox.Controls.Add(this.news1);
            this.NewsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewsBox.Location = new System.Drawing.Point(369, 296);
            this.NewsBox.Name = "NewsBox";
            this.NewsBox.Size = new System.Drawing.Size(370, 142);
            this.NewsBox.TabIndex = 4;
            this.NewsBox.TabStop = false;
            this.NewsBox.Text = "School News";
            // 
            // news1
            // 
            this.news1.AutoSize = true;
            this.news1.LinkColor = System.Drawing.Color.Navy;
            this.news1.Location = new System.Drawing.Point(26, 31);
            this.news1.Name = "news1";
            this.news1.Size = new System.Drawing.Size(43, 13);
            this.news1.TabIndex = 0;
            this.news1.TabStop = true;
            this.news1.Text = "News 1";
            this.news1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.news1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "B . A . D . C .  High School";
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewsBox);
            this.Controls.Add(this.noticeBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.noticeBox.ResumeLayout(false);
            this.noticeBox.PerformLayout();
            this.NewsBox.ResumeLayout(false);
            this.NewsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        //private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.GroupBox noticeBox;
        private System.Windows.Forms.LinkLabel notice1;
        private System.Windows.Forms.GroupBox NewsBox;
        private System.Windows.Forms.LinkLabel news1;
        private System.Windows.Forms.Label label1;
    }
}

