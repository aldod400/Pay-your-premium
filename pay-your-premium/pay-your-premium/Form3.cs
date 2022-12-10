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
    public partial class APPLE : Form
    {
        public APPLE()
        {
            InitializeComponent();
        }

        private void phonbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = phonbtn.Height;
            panel3.Top = phonbtn.Top;
            panel3.Visible = true;
            panel4.Visible = false;
            pnlcom.Visible = false;
            panel7.Visible = false;

            pnlphone.Visible = true;
            pnlwatch.Visible = false;
        }

        private void combtn_Click(object sender, EventArgs e)
        {
            panel3.Height = combtn.Height;
            panel3.Top = combtn.Top;
            panel3.Visible = false;
            panel4.Visible = true;
            panel7.Visible = false;

            pnlcom.Visible = true;
            pnlphone.Visible = false;
            pnlwatch.Visible = false;
        } 

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Height = watchbtn.Height;
            panel3.Top = watchbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = true;

            pnlcom.Visible = false;
            pnlphone.Visible = false;
            pnlwatch.Visible = true;
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }
    }
}
