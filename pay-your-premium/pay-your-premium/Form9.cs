using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pay_your_premium
{
    public partial class Premium : Form
    {
        public Premium()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
        //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C8AHDPB\PROGRAMMER;Initial Catalog=pay_your_premium;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            if(comboBox1.Text == "" || comboBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Check Empty Faild");
            }
            else
            {
                double z = double.Parse(comboBox1.Text);
                double x = double.Parse(textBox3.Text);
                if (z > 0)
                {
                    if (z >= x)
                    {
                        z -= double.Parse(textBox3.Text);
                        SqlCommand cm = new SqlCommand("UPDATE contracts SET total_price = '" + z + "'  WHERE [device_description] = '" + comboBox2.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        textBox3.Text = "";
                        MessageBox.Show("Payed Successfully");
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The Batch is Bigger Than Total Price");

                    }
                    
                }
                else
                {
                    MessageBox.Show("The Premiums has been Finished");
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    textBox3.Text = "";
                    button1.Enabled = true;
                }
                

            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM [dbo].[contracts] WHERE [national_number] = '"+textBox1.Text+"'",cn);
            SqlDataReader sdr = cm.ExecuteReader();
            
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    comboBox2.Items.Add(sdr["device_description"].ToString());
                    comboBox1.Items.Add(sdr["total_price"].ToString());
                }
                button1.Enabled = false;
                comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox2.Text = comboBox2.Items[0].ToString();
                sdr.Close();
            }
            else
            {
                MessageBox.Show("Invalid National Number");
            }
            cn.Close();
        }
    }
}
