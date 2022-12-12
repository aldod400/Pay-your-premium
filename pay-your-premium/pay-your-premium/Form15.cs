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
            global.desc = label40.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 1550.00;
            global.desc = label36.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 190.99;
            global.desc = label34.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 379.99;
            global.desc = label38.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            global.price = 990.99;
            global.desc = label14.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price = 1999.99;
            global.desc = label12.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.price = 50.00;
            global.desc = label8.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.price = 669.00;
            global.desc = label16.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price = 90.99;
            global.desc = label6.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            global.price = 70.00;
            global.desc = label44.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            global.price = 59.00;
            global.desc = label46.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price = 60.00;
            global.desc = label32.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price = 65.99;
            global.desc = label42.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price = 65.99;
            global.desc = label30.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price = 50.00;
            global.desc = label4.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.price = 69.99;
            global.desc = label10.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.price = 70.99;
            global.desc = label18.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price = 90.99;
            global.desc = label2.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.price = 88.00;
            global.desc = label22.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.price = 90.99;
            global.desc = label20.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.price = 79.99;
            global.desc = label24.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }
    }
}
