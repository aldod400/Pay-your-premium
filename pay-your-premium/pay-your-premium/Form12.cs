using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pay_your_premium
{
    public partial class Contract : Form
    {
        
        string clientname;
        double clientid;
        string dayofbirth;
        string address;
        string start;
        string end;
        string compname;
        string devicedetial;
        int totalpri;
        int preperiod;
        int deposit;

        public Contract()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            clientname = client.Text;
            clientid = double.Parse(Nationnum.Text);
            dayofbirth =maskedTextBox1.Text;
            address = Address.Text;
            start = dateTimePicker1.Text;
            end = dateTimePicker2.Text;
            compname = comnam.Text;
            devicedetial = descri.Text;
            totalpri = int.Parse(price.Text);
            preperiod = int.Parse(period.Text);
            deposit = int.Parse(dpsit.Text);



            richTextBox1.Text = string.Format("                               Premium Contract                               \n\n\n\n This  contract  encloses  terms  and  conditions  with  which  a    contractor : " + compname + "  will  offer  services  to " + "\n\n - Client :  " + clientname + " ,   \n\n - Client Nation Number :" + clientid.ToString() + "\n\n - Adreess : " + address + "\n\n - Day Of Birth : " + dayofbirth + "\n\n\n The contractor shall: \n\n - begin work on " + start + "\n\n - Complete on  " + end + " \n\n\n The Product Details : \n " + devicedetial + " \n\n - The Total Price : " + totalpri + "\n\n - Depodit : "+ deposit +"\n\n - Premiumm Period : " + preperiod );

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}
