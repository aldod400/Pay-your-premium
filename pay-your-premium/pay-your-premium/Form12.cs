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
    public partial class Contract : Form
    {
        int subscrip;
        string clientname;
        double clientid;
        string start;
        string end;
        string compname;
        string devicedetial;
        int pri;
        int preperiod;

        public Contract()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            subscrip = int.Parse(sub.Text);
            clientname = client.Text;
            clientid = double.Parse(ID.Text);
            start = dateTimePicker1.Text;
            end = dateTimePicker2.Text;
            compname = comnam.Text;
            devicedetial = descri.Text;
            pri = int.Parse(price.Text);
            preperiod = int.Parse(period.Text);



            richTextBox1.Text = string.Format("                                             Premium Contract                               \n\n\n\n This  contract  encloses  terms  and  conditions  with  which  a    contractor : " + compname + "  will  offer  services  to number : " + subscrip + "\n\n                                Client:  " + clientname + " , Client ID :" + clientid.ToString() + "\n\n The contractor shall: \n\n                                begin work on " + start + "\n\n                                Complete on  " + end + " \n\n The Product Details : \n\n                                " + devicedetial + " \n\n The Price , Premiumm Period : \n\n                                " + pri + " , " + preperiod);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
