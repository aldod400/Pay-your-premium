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
    public partial class SAMSUNG : Form
    {
        public SAMSUNG()
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
            pnlcom.Visible = false;
            pnlwatch.Visible = false;
            pnltv.Visible = false;
        }

        private void combtn_Click(object sender, EventArgs e)
        {
            panel3.Height = combtn.Height;
            panel3.Top = combtn.Top;
            panel3.Visible = false;
            panel4.Visible = true;
            panel7.Visible = false;
            panel2.Visible = false;

            pnlphone.Visible = false;
            pnlcom.Visible = true;
            pnlwatch.Visible = false;
            pnltv.Visible = false;
        }

        private void watchbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = watchbtn.Height;
            panel3.Top = watchbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = true;
            panel2.Visible = false;

            pnlphone.Visible = false;
            pnlcom.Visible = false;
            pnlwatch.Visible = true;
            pnltv.Visible = false;
        }

        private void tvbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = tvbtn.Height;
            panel3.Top = tvbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
            panel2.Visible = true;

            pnlphone.Visible = false;
            pnlcom.Visible = false;
            pnlwatch.Visible = false;
            pnltv.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Brands f2 = new Brands();
            f2.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global.price = 296.00;
            global.desc = label38.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            global.price = 299.99;
            global.desc = label34.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            global.price = 299.00;
            global.desc = label32.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            global.price = 290.00;
            global.desc = label36.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.price = 399.99;
            global.desc = label6.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            global.price = 15949.99;
            global.desc = label28.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global.price = 20999.99;
            global.desc = label14.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            global.price = 25599.00;
            global.desc = label12.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            global.price = 25799.00;
            global.desc = label26.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.price = 15760.00;
            global.desc = label10.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global.price = 30990.00;
            global.desc = label8.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global.price = 589.99;
            global.desc = label24.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.price = 1990;
            global.desc = label2.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            global.price = 1990;
            global.desc = label16.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            global.price = 799.00;
            global.desc = label22.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            global.price = 999.00;
            global.desc = label18.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            global.price = 999.99;
            global.desc = label20.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.price = 1990;
            global.desc = label4.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            global.price = 10999.00;
            global.desc = label42.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            global.price = 15295.00;
            global.desc = label46.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            global.price = 9900.00;
            global.desc = label44.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            global.price = 9545.89;
            global.desc = label40.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            global.price = 23299.00;
            global.desc = label30.Text;
            Contract cont = new Contract();
            this.Hide();
            cont.Show();
        }
    }
}
