using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phone_And_More
{
    public partial class HistoryControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        int sum, cost;
        public HistoryControl()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            
            TotalPrice();
        }


        private void btnServiceInvoice_Click(object sender, EventArgs e)
        {
            btnServiceInvoice.BringToFront();
        }
        void getserviceinvoice()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ser_inv_ID as Invoice, ser_inv_date,convert(char(5), ser_inv_time, 108) as Time, ser_inv_total_cost, ser_inv_total_price as  Price FROM services_invoice WHERE ser_inv_date = '"+dateTimePicker1.Text+"' "; 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["ser_inv_date"].Visible = false;
            this.dataGridView1.Columns["ser_inv_total_cost"].Visible = false;

            con.Close();
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getserviceinvoice();
            TotalPrice();
            totalprofit();
        }
    }
}
