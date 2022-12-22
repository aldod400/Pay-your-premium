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
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are You Sure About Closing The Program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            LG f5 = new LG();
            f5.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            APPLE f3 = new APPLE();
            f3.Show();
            this.Hide();
        }

        private void btnsam_Click(object sender, EventArgs e)
        {
            SAMSUNG f11 = new SAMSUNG();
            f11.Show();
            this.Hide();
        }

        private void btnhp_Click(object sender, EventArgs e)
        {
            HP f13 = new HP();
            f13.Show();
            this.Hide();
        }

        private void btnlenovo_Click(object sender, EventArgs e)
        {
            LENOVO f14 = new LENOVO();
            f14.Show();
            this.Hide();
        }

        private void btnsony_Click(object sender, EventArgs e)
        {
            SONY f15 = new SONY();
            f15.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main f8 = new Main();
            f8.Show();
            this.Hide();
       
        }
    }
}
