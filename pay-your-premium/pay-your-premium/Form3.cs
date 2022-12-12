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

        private void APPLE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price = 589.99;
            global.desc = label1.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price = 769.99;
            global.desc = label4.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            global.price = 399.00;
            global.desc = label6.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price = 299.00;
            global.desc = label8.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.price = 114.00;
            global.desc = label10.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.price = 199.00;
            global.desc = label12.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price = 1089.99;
            global.desc = label36.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 1569.99;
            global.desc = label32.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price = 1399.00;
            global.desc = label30.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 589.99;
            global.desc = label42.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.price = 769.99;
            global.desc = label38.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price = 399.00;
            global.desc = label34.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price = 299.00;
            global.desc = label40.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 114.00;
            global.desc = label28.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            global.price = 769.99;
            global.desc = label50.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
