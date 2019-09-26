using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Phone_And_More
{
    public partial class HistoryForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        int sum, cost; /*sumd;*/
        public HistoryForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TotalPrice();
            
        }
        void getserviceinvoice()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ser_inv_ID as 'Invoice #', ser_inv_date,convert(char(5), ser_inv_time, 108) as Time, ser_inv_total_cost, ser_inv_total_price as 'Total Price' FROM services_invoice WHERE ser_inv_date = '" + dateTimePicker1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["ser_inv_date"].Visible = false;
            this.dataGridView1.Columns["ser_inv_total_cost"].Visible = false;

            con.Close();
        }
        void getSelectedserviceDetails()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ser_inv_id, services.service_name as Name, ser_inv_quantity as Quantity ,ser_inv_price as 'Total Price' FROM ser_inv_details INNER JOIN services ON ser_inv_SID = SID WHERE ser_inv_id = '" + lblsid2.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            this.dataGridView2.Columns["ser_inv_id"].Visible = false;

        }
        void TotalPrice()
        {
            sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            txttotalsell.Text = sum.ToString();
        }
        void totalprofit()
        {
            cost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cost += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            int profit = 0;
            profit = sum - cost;
            txttotalprofit.Text = profit.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView1.Rows[index];

                {
                    //int n = dataGridView1.Rows.Add();
                    lblsid2.Text = selectedrow.Cells[0].Value.ToString();

                    getSelectedserviceDetails();


                }

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getserviceinvoice();
            TotalPrice();
            totalprofit();
        }
    }
}
