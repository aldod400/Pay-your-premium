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
using Microsoft.VisualBasic;

namespace pay_your_premium
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            da = new SqlDataAdapter("select*from contracts", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RGLU690;Initial Catalog=pay_your_premium;Integrated Security=True");
       // SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C8AHDPB\PROGRAMMER;Initial Catalog=pay_your_premium;Integrated Security=True");
        private void data()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            da = new SqlDataAdapter("select*from contracts where [national_number]='" + textBox1.Text + "'", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        DataGridViewRow row;
        int selectedRowIndex;
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DialogResult ss = MessageBox.Show("Are You Sure to delete?","Delete Document",MessageBoxButtons.YesNo);
            if( ss == DialogResult.Yes)
            {
                row = dataGridView1.Rows[e.RowIndex];
                id = int.Parse(row.Cells[0].Value.ToString());
                cn.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM [dbo].[contracts] WHERE [contracts_id] = '" + id + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("DELETED Successfully");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                cn.Open();
                da = new SqlDataAdapter("select*from contracts", cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRowIndex];
            int iid = int.Parse(row.Cells[0].Value.ToString());
            string client_name = Interaction.InputBox("Enter The New Client Name", "Update Data", row.Cells[1].Value.ToString(), -1, -1);
            string national_number = Interaction.InputBox("Enter The New National Number", "Update Data", row.Cells[2].Value.ToString(), -1, -1);
            string address  = Interaction.InputBox("Enter The New Address", "Update Data", row.Cells[3].Value.ToString(), -1, -1);
            string date_birth  = Interaction.InputBox("Enter The New Date Birth", "Update Data", row.Cells[4].Value.ToString(), -1, -1);
            string device_description  = Interaction.InputBox("Enter The Divice Description", "Update Data", row.Cells[5].Value.ToString(), -1, -1);
            string total_price = Interaction.InputBox("Enter The New Total Price", "Update Data", row.Cells[6].Value.ToString(), -1, -1);
            string deposit = Interaction.InputBox("Enter The New Deposit", "Update Data", row.Cells[7].Value.ToString(), -1, -1);
            string premium_period  = Interaction.InputBox("Enter The Premium Period", "Update Data", row.Cells[8].Value.ToString(), -1, -1);
            string start_date  = Interaction.InputBox("Enter The New Start Date", "Update Data", row.Cells[9].Value.ToString(), -1, -1);
            string end_date = Interaction.InputBox("Enter The New End Date", "Update Data", row.Cells[10].Value.ToString(), -1, -1);
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE [dbo].[contracts] SET client_name = '"+ client_name + "', national_number = '"+ national_number + "', address = '"+ address + "', date_birth = '"+ date_birth + "', device_description = '"+ device_description + "', total_price = '"+ total_price + "', deposit = '"+ deposit + "', premium_period = '"+ premium_period + "', start_date = '"+ start_date + "',end_date = '"+ end_date + "' WHERE contracts_id = '"+ iid + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            da = new SqlDataAdapter("select*from contracts", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            data();
        }
    }
}
