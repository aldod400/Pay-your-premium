﻿using System;
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
    }
}
