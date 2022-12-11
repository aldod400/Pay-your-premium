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
   
    public partial class LG : Form
    {
        public LG()
        {
            InitializeComponent();

        }
        
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tvbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = tvbtn.Height;
            panel2.Top = tvbtn.Top;
            panel2.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
            panel19.Visible = false;

            pnltv.Visible = true;
            pnlfri.Visible = false;
            pnlcook.Visible = false;
            pnlvacuum.Visible = false;
            pnlproj.Visible = false;
        }

        private void fribtn_Click(object sender, EventArgs e)
        {
            panel2.Height = fribtn.Height;
            panel2.Top = fribtn.Top;
            panel2.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel12.Visible = false;
            panel19.Visible = false;

            pnltv.Visible = false;
            pnlfri.Visible = true;
            pnlcook.Visible = false;
            pnlvacuum.Visible = false;
            pnlproj.Visible = false;
        }

        private void cookbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = cookbtn.Height;
            panel2.Top = cookbtn.Top;
            panel2.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel12.Visible = false;
            panel19.Visible = false;

            pnltv.Visible = false;
            pnlfri.Visible = false;
            pnlcook.Visible = true;
            pnlvacuum.Visible = false;
            pnlproj.Visible = false;
        }

        private void vacbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = vacbtn.Height;
            panel2.Top = vacbtn.Top;
            panel2.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = true;
            panel19.Visible = false;

            pnltv.Visible = false;
            pnlfri.Visible = false;
            pnlcook.Visible = false;
            pnlvacuum.Visible = true;
            pnlproj.Visible = false;
        }

        private void projbtn_Click(object sender, EventArgs e)
        {
            panel2.Height = projbtn.Height;
            panel2.Top = projbtn.Top;
            panel2.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
            panel19.Visible = true;

            pnltv.Visible = false;
            pnlfri.Visible = false;
            pnlcook.Visible = false;
            pnlvacuum.Visible = false;
            pnlproj.Visible = true;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            global.price += 589.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.price += 999.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.price += 999.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.price += 799.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.price += 1.990;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            global.price += 1999.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            global.price += 999.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.price += 1239.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.price += 799.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price += 1990;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price += 1029.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price += 1000.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price += 999.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            global.price += 1909.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price += 1239.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price += 899.95;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            global.price += 1399.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price += 2199.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            global.price += 939.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price += 527.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price += 299.99;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 639.00;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 110.95;
            global.desc = label38.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void LG_Load(object sender, EventArgs e)
        {

        }
    }

    class global
    {
        public static double price = 0;
        public static string desc = "";
    }
}
