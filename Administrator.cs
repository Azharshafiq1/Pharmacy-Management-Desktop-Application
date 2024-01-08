using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Administrator : Form
    {
        String username = "";
        public Administrator()
        {
            InitializeComponent();
        }

        public Administrator(String user)
        {
            InitializeComponent();
            lblusername.Text = user;
            username = user;
            uS_View1.ID = ID;
            uC_Profile1.ID = ID;
        }

        public string ID
        {
            get { return username.ToString(); } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            uS_adduser1.Visible = true;
            uS_adduser1.BringToFront();
        }

        private void uS_adduser1_Load(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uS_adduser1.Visible = false;
            uS_View1.Visible = false;
            uC_Profile1.Visible = false;
            btndashboard.PerformClick();
        }

        private void btnviewuser_Click(object sender, EventArgs e)
        {
            uS_View1.Visible = true;
            uS_View1.BringToFront();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
            
        }

        private void btnprofile_Click_1(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
