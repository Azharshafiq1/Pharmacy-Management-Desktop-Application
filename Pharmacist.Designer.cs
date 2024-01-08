namespace WindowsFormsApp1
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnsellmedicine = new System.Windows.Forms.Button();
            this.btnmedicinevalitycheck = new System.Windows.Forms.Button();
            this.btnmodifymedicine = new System.Windows.Forms.Button();
            this.btnviewmedicine = new System.Windows.Forms.Button();
            this.btnaddmedicine = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SellMedicine1 = new WindowsFormsApp1.PharmacistUC.UC_SellMedicine();
            this.uC_MedicineValidityCheck1 = new WindowsFormsApp1.PharmacistUC.UC_MedicineValidityCheck();
            this.uC_Modify_Medicine1 = new WindowsFormsApp1.PharmacistUC.UC_Modify_Medicine();
            this.uC_ViewMedicine1 = new WindowsFormsApp1.PharmacistUC.UC_ViewMedicine();
            this.uC_AddMedicine1 = new WindowsFormsApp1.PharmacistUC.UC_AddMedicine();
            this.uC_Dashboardp1 = new WindowsFormsApp1.PharmacistUC.UC_Dashboardp();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnsellmedicine);
            this.panel1.Controls.Add(this.btnmedicinevalitycheck);
            this.panel1.Controls.Add(this.btnmodifymedicine);
            this.panel1.Controls.Add(this.btnviewmedicine);
            this.panel1.Controls.Add(this.btnaddmedicine);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 801);
            this.panel1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Lime;
            this.lblusername.Location = new System.Drawing.Point(3, 224);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(304, 33);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "TwinsTech";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Teal;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(3, 628);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(299, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnsellmedicine
            // 
            this.btnsellmedicine.BackColor = System.Drawing.Color.Teal;
            this.btnsellmedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsellmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsellmedicine.ForeColor = System.Drawing.Color.White;
            this.btnsellmedicine.Location = new System.Drawing.Point(3, 575);
            this.btnsellmedicine.Name = "btnsellmedicine";
            this.btnsellmedicine.Size = new System.Drawing.Size(299, 47);
            this.btnsellmedicine.TabIndex = 6;
            this.btnsellmedicine.Text = "Sell Medicine";
            this.btnsellmedicine.UseVisualStyleBackColor = false;
            this.btnsellmedicine.Click += new System.EventHandler(this.btnsellmedicine_Click);
            // 
            // btnmedicinevalitycheck
            // 
            this.btnmedicinevalitycheck.BackColor = System.Drawing.Color.Teal;
            this.btnmedicinevalitycheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmedicinevalitycheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedicinevalitycheck.ForeColor = System.Drawing.Color.White;
            this.btnmedicinevalitycheck.Location = new System.Drawing.Point(3, 522);
            this.btnmedicinevalitycheck.Name = "btnmedicinevalitycheck";
            this.btnmedicinevalitycheck.Size = new System.Drawing.Size(299, 47);
            this.btnmedicinevalitycheck.TabIndex = 5;
            this.btnmedicinevalitycheck.Text = "Medicine Validity Check\r\n";
            this.btnmedicinevalitycheck.UseVisualStyleBackColor = false;
            this.btnmedicinevalitycheck.Click += new System.EventHandler(this.btnmedicinevalitycheck_Click);
            // 
            // btnmodifymedicine
            // 
            this.btnmodifymedicine.BackColor = System.Drawing.Color.Teal;
            this.btnmodifymedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodifymedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifymedicine.ForeColor = System.Drawing.Color.White;
            this.btnmodifymedicine.Location = new System.Drawing.Point(3, 469);
            this.btnmodifymedicine.Name = "btnmodifymedicine";
            this.btnmodifymedicine.Size = new System.Drawing.Size(299, 47);
            this.btnmodifymedicine.TabIndex = 4;
            this.btnmodifymedicine.Text = "Modify Medicine";
            this.btnmodifymedicine.UseVisualStyleBackColor = false;
            this.btnmodifymedicine.Click += new System.EventHandler(this.btnmodifymedicine_Click);
            // 
            // btnviewmedicine
            // 
            this.btnviewmedicine.BackColor = System.Drawing.Color.Teal;
            this.btnviewmedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnviewmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmedicine.ForeColor = System.Drawing.Color.White;
            this.btnviewmedicine.Location = new System.Drawing.Point(3, 415);
            this.btnviewmedicine.Name = "btnviewmedicine";
            this.btnviewmedicine.Size = new System.Drawing.Size(299, 47);
            this.btnviewmedicine.TabIndex = 3;
            this.btnviewmedicine.Text = "View Medicine";
            this.btnviewmedicine.UseVisualStyleBackColor = false;
            this.btnviewmedicine.Click += new System.EventHandler(this.btnviewmedicine_Click);
            // 
            // btnaddmedicine
            // 
            this.btnaddmedicine.BackColor = System.Drawing.Color.Teal;
            this.btnaddmedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmedicine.ForeColor = System.Drawing.Color.White;
            this.btnaddmedicine.Location = new System.Drawing.Point(3, 362);
            this.btnaddmedicine.Name = "btnaddmedicine";
            this.btnaddmedicine.Size = new System.Drawing.Size(299, 47);
            this.btnaddmedicine.TabIndex = 2;
            this.btnaddmedicine.Text = "Add Medicine";
            this.btnaddmedicine.UseVisualStyleBackColor = false;
            this.btnaddmedicine.Click += new System.EventHandler(this.btnaddmedicine_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Teal;
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(3, 309);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(299, 47);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 801);
            this.panel2.TabIndex = 1;
            // 
            // uC_SellMedicine1
            // 
            this.uC_SellMedicine1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_SellMedicine1.Location = new System.Drawing.Point(309, 0);
            this.uC_SellMedicine1.Name = "uC_SellMedicine1";
            this.uC_SellMedicine1.Size = new System.Drawing.Size(1169, 801);
            this.uC_SellMedicine1.TabIndex = 6;
            // 
            // uC_MedicineValidityCheck1
            // 
            this.uC_MedicineValidityCheck1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_MedicineValidityCheck1.Location = new System.Drawing.Point(309, 0);
            this.uC_MedicineValidityCheck1.Name = "uC_MedicineValidityCheck1";
            this.uC_MedicineValidityCheck1.Size = new System.Drawing.Size(1174, 801);
            this.uC_MedicineValidityCheck1.TabIndex = 5;
            // 
            // uC_Modify_Medicine1
            // 
            this.uC_Modify_Medicine1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Modify_Medicine1.Location = new System.Drawing.Point(309, 0);
            this.uC_Modify_Medicine1.Name = "uC_Modify_Medicine1";
            this.uC_Modify_Medicine1.Size = new System.Drawing.Size(1174, 801);
            this.uC_Modify_Medicine1.TabIndex = 4;
            // 
            // uC_ViewMedicine1
            // 
            this.uC_ViewMedicine1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_ViewMedicine1.Location = new System.Drawing.Point(309, -3);
            this.uC_ViewMedicine1.Name = "uC_ViewMedicine1";
            this.uC_ViewMedicine1.Size = new System.Drawing.Size(1174, 801);
            this.uC_ViewMedicine1.TabIndex = 3;
            // 
            // uC_AddMedicine1
            // 
            this.uC_AddMedicine1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_AddMedicine1.Location = new System.Drawing.Point(309, 0);
            this.uC_AddMedicine1.Name = "uC_AddMedicine1";
            this.uC_AddMedicine1.Size = new System.Drawing.Size(1169, 801);
            this.uC_AddMedicine1.TabIndex = 2;
            // 
            // uC_Dashboardp1
            // 
            this.uC_Dashboardp1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Dashboardp1.Location = new System.Drawing.Point(309, 0);
            this.uC_Dashboardp1.Name = "uC_Dashboardp1";
            this.uC_Dashboardp1.Size = new System.Drawing.Size(1169, 798);
            this.uC_Dashboardp1.TabIndex = 1;
            this.uC_Dashboardp1.Load += new System.EventHandler(this.uC_Dashboardp1_Load);
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1480, 800);
            this.Controls.Add(this.uC_SellMedicine1);
            this.Controls.Add(this.uC_MedicineValidityCheck1);
            this.Controls.Add(this.uC_Modify_Medicine1);
            this.Controls.Add(this.uC_ViewMedicine1);
            this.Controls.Add(this.uC_AddMedicine1);
            this.Controls.Add(this.uC_Dashboardp1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnsellmedicine;
        private System.Windows.Forms.Button btnmedicinevalitycheck;
        private System.Windows.Forms.Button btnmodifymedicine;
        private System.Windows.Forms.Button btnviewmedicine;
        private System.Windows.Forms.Button btnaddmedicine;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Label lblusername;
        private PharmacistUC.UC_Dashboardp uC_Dashboardp1;
        private PharmacistUC.UC_AddMedicine uC_AddMedicine1;
        private PharmacistUC.UC_ViewMedicine uC_ViewMedicine1;
        private PharmacistUC.UC_Modify_Medicine uC_Modify_Medicine1;
        private PharmacistUC.UC_MedicineValidityCheck uC_MedicineValidityCheck1;
        private PharmacistUC.UC_SellMedicine uC_SellMedicine1;
    }
}