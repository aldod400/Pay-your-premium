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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //private void User_Enter(object sender, EventArgs e)
        //{
        //    if (User.Text == "Username")
        //    {
        //        User.Text = "";
        //    }
        //}
        //private void User_Leave(object sender, EventArgs e)
        //{
        //    if (User.Text == "")
        //    {
        //        User.Text = "Username";
        //    }
        //}

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
            {
                Pass.Text = "";
            }
            Pass.UseSystemPasswordChar = true;
        }
        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Password";
            }
            Pass.UseSystemPasswordChar = false;
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
            }
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            if (confirm.Text == "Confirm Password")
            {
                confirm.Text = "";
            }
            confirm.UseSystemPasswordChar = true;
        }

        private void confirm_Leave(object sender, EventArgs e)
        {
            if (confirm.Text == "")
            {
                confirm.Text = "Confirm Password";
            }
            confirm.UseSystemPasswordChar = false;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void close_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(email.Text == "" || email.Text == "Email")
            {
                MessageBox.Show("Please Inter Your Email");
            }
            else
            {
                cn.Open();
                SqlCommand sq = new SqlCommand("SELECT * FROM users WHERE user_email = '" + email.Text + "'", cn);
                SqlDataReader dr = sq.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Close();
                    if (Pass.Text == "Password" || Pass.Text == "" || confirm.Text == "Confirm Password" || confirm.Text == "")
                    {
                        MessageBox.Show("Please Enter The New Password");
                    }
                    else
                    {
                        SqlCommand sql = new SqlCommand("UPDATE users SET  user_password = '" + Pass.Text + "'  WHERE user_email ='" + email.Text + "'", cn);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Your Email Is Updated");
                        email.Text = "Email";
                        Pass.Text = "Password";
                        confirm.Text = "Confirm Password";
                        this.Close();
                        Login l = new Login();
                        l.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
            }
            
            cn.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}