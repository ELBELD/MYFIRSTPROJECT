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
    public partial class report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        //DataTable table = new DataTable();
        int TStockcost, TServiceCost;
        
        public report()
        {
            InitializeComponent();
            
        }
        void stockreport()
        {
            con.Open();
            
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(inv_total_cost), SUM(inv_total_price) FROM invoice WHERE inv_date bETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                txtstocksale.Text = (myreader[1].ToString());
                TStockcost =Int32.Parse(myreader[0].ToString());
            }
            con.Close();
        }
        void servicereport()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(ser_inv_total_cost), SUM(ser_inv_total_price) FROM services_invoice WHERE ser_inv_date bETWEEN  '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                txtservicesale.Text = (myreader[1].ToString());
                TServiceCost = Int32.Parse(myreader[0].ToString());
            }
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void earning()
        {

            string a = txtservicesale.Text;
            int x = Convert.ToInt32(a);
            string b = txtstocksale.Text;
            int y = Convert.ToInt32(b);
            txtserviceernings.Text = (x - TServiceCost).ToString();
            txtstockearnings.Text = (y - TStockcost).ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            servicereport();
            stockreport();
            if (txtservicesale.Text != "" && txtstocksale.Text != "")
            {
                earning();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            servicereport();
            stockreport();
            if (txtservicesale.Text != "" && txtstocksale.Text != "")
            {
                earning();
            }

        }
    }
}
