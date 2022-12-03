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

namespace pay_your_premium
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void picpass_MouseDown(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = false;
        }

        private void picpass_MouseUp(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void User_Click(object sender, EventArgs e)
        {
            User.Clear();
        }

        private void User_Enter(object sender, EventArgs e)
        {
            if (User.Text == "Username")
            {
                User.Text = "";
            }
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (User.Text == "")
            {
                User.Text = "Username";
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
            cn.Open();
            if (User.Text == "Email" || Pass.Text == "Password")
            {
                MessageBox.Show("Chek Empty Field");
            }
            else
            {
                SqlCommand cm = new SqlCommand("SELECT * FROM users WHERE [user_email] = '" + User.Text + "' AND [user_password] = '" + Pass.Text + "'", cn);
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows == true)
                {
                    this.Hide();
                    Brands f2 = new Brands();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Email Or Password");
                }
            }
            cn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form = new Form7();
            this.Hide();
            form.Show();
        }
    }
}
