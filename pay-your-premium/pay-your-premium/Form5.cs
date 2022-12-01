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
    }
}
