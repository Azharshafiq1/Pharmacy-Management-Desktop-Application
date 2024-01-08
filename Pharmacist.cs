using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        public Pharmacist(String user)
        {
            InitializeComponent();
            lblusername.Text = user;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void uC_Dashboardp1_Load(object sender, EventArgs e)
        {

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_Dashboardp1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicine1.Visible = false;
            uC_Modify_Medicine1.Visible = false;
            uC_MedicineValidityCheck1.Visible = false;
            uC_SellMedicine1.Visible = false;
            btndashboard.PerformClick();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboardp1.Visible = true;
            uC_Dashboardp1.BringToFront();
        }

        private void btnaddmedicine_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();
        }

        private void btnviewmedicine_Click(object sender, EventArgs e)
        {
            uC_ViewMedicine1.Visible = true;
            uC_ViewMedicine1.BringToFront();
        }

        private void btnmodifymedicine_Click(object sender, EventArgs e)
        {
            uC_Modify_Medicine1.Visible = true;
            uC_Modify_Medicine1.BringToFront();
        }

        private void btnmedicinevalitycheck_Click(object sender, EventArgs e)
        {
            uC_MedicineValidityCheck1.Visible = true;
            uC_MedicineValidityCheck1.BringToFront();
        }

        private void btnsellmedicine_Click(object sender, EventArgs e)
        {
            uC_SellMedicine1.Visible = true;
            uC_SellMedicine1.BringToFront();
        }
    }
}
