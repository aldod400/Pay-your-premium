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
    public partial class HP : Form
    {
        public HP()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void combtn_Click(object sender, EventArgs e)
        {
            panel4.Height = combtn.Height;
            panel4.Top = combtn.Top;
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            pnlcom.Visible = true;
            pnlprinter.Visible = false;
            pnlscanner.Visible = false;

        }

        private void printerbtn_Click(object sender, EventArgs e)
        {
            panel4.Height = printerbtn.Height;
            panel4.Top = printerbtn.Top;
            panel4.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

            pnlcom.Visible = false;
            pnlprinter.Visible = true;
            pnlscanner.Visible = false;
        }

        private void scannerbtn_Click(object sender, EventArgs e)
        {
            panel4.Height = scannerbtn.Height;
            panel4.Top = scannerbtn.Top;
            panel4.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            pnlcom.Visible = false;
            pnlprinter.Visible = false;
            pnlscanner.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price = 6999;
            global.desc = label40.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 8500;
            global.desc = label36.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 52990.00;
            global.desc = label34.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 90799.99;
            global.desc = label38.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            global.price = 15990.00;
            global.desc = label14.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price = 12905.00;
            global.desc = label12.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.price = 1099.00;
            global.desc = label20.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.price = 9599.00;
            global.desc = label20.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.price = 15799.99;
            global.desc = label22.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.price = 11990.00;
            global.desc = label18.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price = 12905.00;
            global.desc = label2.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.price = 15990.00;
            global.desc = label16.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price = 12905.00;
            global.desc = label6.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price = 16800.95;
            global.desc = label4.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price = 1999.99;
            global.desc = label28.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price = 199.00;
            global.desc = label32.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price = 1799.99;
            global.desc = label30.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            global.price = 990.00;
            global.desc = label26.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }
    }
}
