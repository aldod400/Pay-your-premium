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
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
        //Form4 form4 = new Form4();
        private void Form7_Load(object sender, EventArgs e)
        {
            //cn.Open();
            //SqlCommand sql = new SqlCommand("SELECT * FROM [pay_your_premium].[dbo].[users] WHERE user_email ='" + form4.emai()+"'", cn);
            //SqlDataReader sdr = sql.ExecuteReader();
            //sdr.Read();
            //User.Text = sdr["user_name"].ToString();
            //email.Text = sdr["user_email"].ToString();
            //sdr.Close();
            //cn.Close();
        }
    }
}