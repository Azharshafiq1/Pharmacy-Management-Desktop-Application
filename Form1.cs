using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtusername.Text = "";
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RL09GG8;Initial Catalog=PharmacyManagment;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from [dbo].[Users] where Username = '" + txtusername.Text + "' and Pass = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dsa = new DataSet();
                sda.Fill(dsa);
                if (dsa.Tables[0].Rows.Count != 0)
                {
                    String Userrole = dsa.Tables[0].Rows[0][1].ToString();
                    if (Userrole == "Administrator")
                    {
                        Administrator ad = new Administrator(txtusername.Text);
                        ad.Show();
                        this.Hide();
                    }
                    else if (Userrole == "Pharmacist")
                    {
                        Pharmacist pm = new Pharmacist(txtusername.Text);
                        pm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
