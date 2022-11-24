using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Close();
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
            this.Hide();
            Brands f2 = new Brands();
            f2.Show();
        }
    }
}
