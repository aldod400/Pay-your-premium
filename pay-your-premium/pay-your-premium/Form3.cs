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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void phonbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = phonbtn.Height;
            panel3.Top = phonbtn.Top;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void combtn_Click(object sender, EventArgs e)
        {
            panel3.Height = combtn.Height;
            panel3.Top = combtn.Top;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void cookbtn_Click(object sender, EventArgs e)
        {
            panel3.Height = cookbtn.Height;
            panel3.Top = cookbtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
        }

        private void fribtn_Click(object sender, EventArgs e)
        {
            panel3.Height = fribtn.Height;
            panel3.Top = fribtn.Top;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
        }
    }
}
