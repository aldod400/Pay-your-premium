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

        private void LG_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
