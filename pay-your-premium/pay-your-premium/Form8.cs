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
    public partial class Main : Form
    {
        public Main()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Premium f8 = new Premium();
            f8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients f8 = new Clients();
            f8.Show();
            this.Hide();
        }
    }
}
