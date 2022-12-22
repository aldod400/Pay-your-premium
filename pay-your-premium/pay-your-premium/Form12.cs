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
using System.Data.SqlClient;

namespace pay_your_premium
{
    public partial class Contract : Form
    {
        
        string clientname;
        long clientid;
        string dayofbirth;
        string address;
        string start;
        string end;
        string compname;
        string devicedetial;
        double totalpri;
        double preperiod;
        double deposit;

        public Contract()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
        //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C8AHDPB\PROGRAMMER;Initial Catalog=pay_your_premium;Integrated Security=True");
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (client.Text == "" || Nationnum.Text == "" || maskedTextBox1.Text == "" || Address.Text == "" || dateTimePicker1.Text == ""
                || dateTimePicker2.Text == "" || comnam.Text == "" || descri.Text == "" 
                || price.Text == "" || period.Text == "" || dpsit.Text == "")
            {
                MessageBox.Show("Check Empty Field","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double z = 0;
                cn.Open();
                clientname = client.Text;
                if (double.TryParse(Nationnum.Text, out z) && Nationnum.Text.Length == 14)
                {
                    clientid = long.Parse(Nationnum.Text);
                    dayofbirth = maskedTextBox1.Text;
                    address = Address.Text;
                    start = dateTimePicker1.Text;
                    end = dateTimePicker2.Text;
                    compname = comnam.Text;
                    devicedetial = global.desc;
                    if(double.TryParse(price.Text,out z) && double.TryParse(period.Text, out z) && double.TryParse(dpsit.Text, out z))
                    {
                        totalpri = global.price;
                        preperiod = double.Parse(period.Text);
                        deposit = double.Parse(dpsit.Text);
                        if(global.price >= deposit)
                        {
                            global.price -= deposit;
                            double batch = (global.price + (global.price * (2.5 / 100))) / preperiod;
                            DialogResult d = MessageBox.Show("Are You Sure?", "Save Contract", MessageBoxButtons.YesNo);

                            if (d == DialogResult.Yes)
                            {

                                SqlCommand cm = new SqlCommand("INSERT INTO contracts ([client_name],[national_number],[address],[date_birth],[device_description],[total_price],[deposit],[premium_period],[batch],[start_date],[end_date])VALUES ('" + clientname + "', '" + clientid + "', '" + address + "', '" + dayofbirth + "','" + devicedetial + "', '" + global.price + "', '" + deposit + "', '" + preperiod + "', '" + batch + "','" + start + "', '" + end + "')", cn);

                                cm.ExecuteNonQuery();

                                richTextBox1.Text = string.Format("                               Premium Contract                               \n\n\n\n This  contract  encloses  terms  and  conditions  with  which  a    contractor : " + compname + "  will  offer  services  to " + "\n\n - Client :  " + clientname + " ,   \n\n - Client Nation Number :" + clientid.ToString() + "\n\n - Adreess : " + address + "\n\n - Day Of Birth : " + dayofbirth + "\n\n\n The contractor shall: \n\n - begin work on " + start + "\n\n - Complete on  " + end + " \n\n\n The Product Details : \n " + devicedetial + " \n\n - The Total Price : " + totalpri + "\n\n - Depodit : " + deposit + "\n\n - Premiumm Period : " + preperiod + "\n\n - Batch : "+batch);
                                client.Text = "";
                                Nationnum.Text = "";
                                maskedTextBox1.Text = "";
                                Address.Text = "";
                                dateTimePicker1.Text = "";
                                dateTimePicker2.Text = "";
                                comnam.Text = "";
                                descri.Text = "";
                                price.Text = "";
                                period.Text = "";
                                dpsit.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Deposit","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }

                    else
                    {
                        MessageBox.Show("Please Enter The Number","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Please Enter The Correct National ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are You Sure About Closing The Program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            //}
           if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Text = "";
            }
            
            

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Sans Serif", 8),Brushes.Black,10,20);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contract_Load(object sender, EventArgs e)
        {
            price.Text = global.price.ToString();
            descri.Text = global.desc.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main f8 = new Main();
            f8.Show();
            this.Hide();
        }
    }
}
