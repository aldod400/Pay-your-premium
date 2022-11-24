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
        private void LG_MouseMove(object sender, MouseEventArgs e)
        {
            LG.BackColor = Color.White;
        }
        private void LG_MouseLeave(object sender, EventArgs e)
        {
            LG.BackColor = DefaultBackColor;
        }

        private void sam_MouseMove(object sender, MouseEventArgs e)
        {
            sam.BackColor = Color.White;
        }

        private void sam_MouseLeave(object sender, EventArgs e)
        {
            sam.BackColor = DefaultBackColor;
        }

        private void hp_MouseMove(object sender, MouseEventArgs e)
        {
            hp.BackColor = Color.White;
        }

        private void hp_MouseLeave(object sender, EventArgs e)
        {
            hp.BackColor = DefaultBackColor;
        }

        private void lenovo_MouseMove(object sender, MouseEventArgs e)
        {
            lenovo.BackColor = Color.White;
        }

        private void lenovo_MouseLeave(object sender, EventArgs e)
        {
            lenovo.BackColor = DefaultBackColor;
        }

        private void sony_MouseMove(object sender, MouseEventArgs e)
        {
            sony.BackColor = Color.White;
        }

        private void sony_MouseLeave(object sender, EventArgs e)
        {
            sony.BackColor = DefaultBackColor;
        }

        private void sharp_MouseMove(object sender, MouseEventArgs e)
        {
            sharp.BackColor = Color.White;
        }

        private void sharp_MouseLeave(object sender, EventArgs e)
        {
            sharp.BackColor = DefaultBackColor;
        }


    }
}
