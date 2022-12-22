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
    public partial class LENOVO : Form
    {
        public LENOVO()
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

        private void phonbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = phonbtn.Height;
            panel3.Top = phonbtn.Top;
            panel3.Visible = true;
            panel4.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;

            pnlphone.Visible = true;
            pnllap.Visible = false;
            pnltaplet.Visible = false;
            pnlwatch.Visible = false;
            
        }

        private void lapbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = lapbtn.Height;
            panel3.Top = lapbtn.Top;
            panel3.Visible = false;
            panel4.Visible = true;
            panel7.Visible = false;
            panel2.Visible = false;

            pnlphone.Visible = false;
            pnllap.Visible = true;
            pnltaplet.Visible = false;
            pnlwatch.Visible = false;
        }

        private void tabletbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = tabletbtn.Height;
            panel3.Top = tabletbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false ;
            panel7.Visible = true;
            panel2.Visible = false;

            pnlphone.Visible = false;
            pnllap.Visible = false;
            pnltaplet.Visible = true;
            pnlwatch.Visible = false;
        }

        private void watchbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = watchbtn.Height;
            panel3.Top = watchbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;

            pnlphone.Visible = false;
            pnllap.Visible = false;
            pnltaplet.Visible = false;
            pnlwatch.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price = 900.00;
            global.desc = label40.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 5550.00;
            global.desc = label36.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 1110.00;
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
            global.price = 1990.99;
            global.desc = label14.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price = 905.00;
            global.desc = label12.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.price = 44999.00;
            global.desc = label16.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.price = 50959.99;
            global.desc = label8.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.price = 52979.99;
            global.desc = label10.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price = 105559.99;
            global.desc = label2.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price = 30110.00;
            global.desc = label6.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price = 100990.99;
            global.desc = label4.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.price = 130000.99;
            global.desc = label18.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            global.price = 959.99;
            global.desc = label28.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price = 199.00;
            global.desc = label32.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price = 1979.99;
            global.desc = label30.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            global.price = 1110.00;
            global.desc = label26.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.price = 1990.99;
            global.desc = label24.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price = 1099;
            global.desc = label42.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            global.price = 179.99;
            global.desc = label44.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            global.price = 57.01;
            global.desc = label46.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.price = 54.99;
            global.desc = label22.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.price = 65.00;
            global.desc = label20.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }
    }
}
