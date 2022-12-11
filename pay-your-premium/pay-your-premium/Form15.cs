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
    public partial class SONY : Form
    {
        public SONY()
        {
            InitializeComponent();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = tvbtn.Height;
            panel2.Top = tvbtn.Top;
            panel2.Visible = true;
            panel6.Visible = false;
            panel5.Visible = false;
            panel19.Visible = false;

            pnltv.Visible = true;
            pnlfan.Visible = false;
            pnlspeaker.Visible = false;
            pnlpro.Visible = false;
        }

        private void fanbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = fanbtn.Height;
            panel2.Top = fanbtn.Top;
            panel2.Visible = false;
            panel6.Visible = true;
            panel5.Visible = false;
            panel19.Visible = false;

            pnltv.Visible = false;
            pnlfan.Visible = true;
            pnlspeaker.Visible = false;
            pnlpro.Visible = false;
        }

        private void speakerbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = speakerbtn.Height;
            panel2.Top = speakerbtn.Top;
            panel2.Visible = false;
            panel6.Visible = false;
            panel5.Visible = true;
            panel19.Visible = false;

            pnltv.Visible = false;
            pnlfan.Visible = false;
            pnlspeaker.Visible = true;
            pnlpro.Visible = false;
        }

        private void projbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = projbtn.Height;
            panel2.Top = projbtn.Top;
            panel2.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel19.Visible = true;

            pnltv.Visible = false;
            pnlfan.Visible = false;
            pnlspeaker.Visible = false;
            pnlpro.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price = 1804.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 1550.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 190.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 379.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            global.price = 990.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price = 1999.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }
    }
}
