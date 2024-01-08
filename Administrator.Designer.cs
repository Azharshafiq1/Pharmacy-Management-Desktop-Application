namespace WindowsFormsApp1
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnviewuser = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Profile1 = new WindowsFormsApp1.Resources.administratorUC.UC_Profile();
            this.uS_View1 = new WindowsFormsApp1.Resources.administratorUC.US_View();
            this.uS_adduser1 = new WindowsFormsApp1.Resources.administratorUC.US_adduser();
            this.uC_Dashboard1 = new WindowsFormsApp1.Resources.administratorUC.UC_Dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.btnviewuser);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 801);
            this.panel1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Lime;
            this.lblusername.Location = new System.Drawing.Point(3, 679);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(301, 33);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "TwinsTech";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(3, 620);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(301, 47);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.Location = new System.Drawing.Point(3, 558);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(301, 45);
            this.btnprofile.TabIndex = 4;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = false;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click_1);
            // 
            // btnviewuser
            // 
            this.btnviewuser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnviewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnviewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewuser.ForeColor = System.Drawing.Color.White;
            this.btnviewuser.Location = new System.Drawing.Point(3, 494);
            this.btnviewuser.Name = "btnviewuser";
            this.btnviewuser.Size = new System.Drawing.Size(301, 47);
            this.btnviewuser.TabIndex = 3;
            this.btnviewuser.Text = "View User";
            this.btnviewuser.UseVisualStyleBackColor = false;
            this.btnviewuser.Click += new System.EventHandler(this.btnviewuser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.Location = new System.Drawing.Point(3, 434);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(301, 47);
            this.btnadduser.TabIndex = 2;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(3, 372);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(301, 47);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uS_View1);
            this.panel2.Controls.Add(this.uS_adduser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(306, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 768);
            this.panel2.TabIndex = 1;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Profile1.Location = new System.Drawing.Point(0, -3);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1169, 801);
            this.uC_Profile1.TabIndex = 6;
            // 
            // uS_View1
            // 
            this.uS_View1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uS_View1.ForeColor = System.Drawing.Color.Black;
            this.uS_View1.Location = new System.Drawing.Point(0, -3);
            this.uS_View1.Name = "uS_View1";
            this.uS_View1.Size = new System.Drawing.Size(1101, 801);
            this.uS_View1.TabIndex = 2;
            // 
            // uS_adduser1
            // 
            this.uS_adduser1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uS_adduser1.Location = new System.Drawing.Point(0, -3);
            this.uS_adduser1.Name = "uS_adduser1";
            this.uS_adduser1.Size = new System.Drawing.Size(1172, 801);
            this.uS_adduser1.TabIndex = 1;
            this.uS_adduser1.Load += new System.EventHandler(this.uS_adduser1_Load);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, -3);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1101, 801);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1480, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnviewuser;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusername;
        private Resources.administratorUC.UC_Dashboard uC_Dashboard1;
        private Resources.administratorUC.US_adduser uS_adduser1;
        private Resources.administratorUC.US_View uS_View1;
        private Resources.administratorUC.UC_Profile uC_Profile1;
    }
}