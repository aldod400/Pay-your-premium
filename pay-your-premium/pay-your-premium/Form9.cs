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
            DialogResult m = MessageBox.Show("Are You Sure About Closing The Program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
        //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C8AHDPB\PROGRAMMER;Initial Catalog=pay_your_premium;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            int idd = 0;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                if (comboBox2.SelectedItem == comboBox2.Items[i])
                {
                    idd = id[i];
                    break;
                }
            }
            cn.Open();
            if(textBox2.Text == "" || comboBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Check Empty Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double z = double.Parse(textBox2.Text);
                double x = double.Parse(textBox3.Text);
                if (z > 0)
                {
                    if (z >= x)
                    {
                        z -= double.Parse(textBox3.Text);
                        SqlCommand cm = new SqlCommand("UPDATE contracts SET total_price = '" + z + "'  WHERE contracts_id = '" + idd + "'", cn);
                        cm.ExecuteNonQuery();
                        textBox2.Text = "";
                        comboBox2.Items.Clear();
                        textBox3.Text = "";
                        MessageBox.Show("Payed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The Batch is Bigger Than Total Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }
                else
                {
                    MessageBox.Show("The Premiums has been Finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    comboBox2.Items.Clear();
                    textBox3.Text = "";
                    Search.Enabled = true;
                }
                

            }
            cn.Close();
        }
        int[] id = new int[50];
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM [dbo].[contracts] WHERE [national_number] = '"+textBox1.Text+"'",cn);
            SqlDataReader sdr = cm.ExecuteReader();
            int i = 0;
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    comboBox2.Items.Add(sdr["device_description"].ToString());
                    //comboBox1.Items.Add(sdr["total_price"].ToString());
                    id[i] = int.Parse(sdr["contracts_id"].ToString());
                    i++;
                }
                Search.Enabled = false;
                //comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox2.Text = comboBox2.Items[0].ToString();
                sdr.Close();
                //label5.Text = id[1].ToString();
            }
            else
            {
                MessageBox.Show("Invalid National Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main f8 = new Main();
            f8.Show();
            this.Hide();
        }
        
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idd = 0;
            cn.Close();
            cn.Open();
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                if (comboBox2.SelectedItem == comboBox2.Items[i])
                {
                    idd = id[i];
                    break;
                }
            }
            SqlCommand cm = new SqlCommand("SELECT * FROM contracts WHERE contracts_id = '" + idd + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                    textBox2.Text = dr["total_price"].ToString();
            }
            cn.Close();
        }
    }
}
