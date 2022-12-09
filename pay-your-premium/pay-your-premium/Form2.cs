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
            this.Close();
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
    }
}
