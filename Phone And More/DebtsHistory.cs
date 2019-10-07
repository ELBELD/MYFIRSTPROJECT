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
    public partial class DebtsHistory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        string customerid, debtid;

        public DebtsHistory()
        {
            InitializeComponent();
            autocompleteCustomerName();

        }
        void autocompleteCustomerName()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT customer_name FROM customers";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (myreader.Read())
            {
                mycollection.Add(myreader.GetString(0));

            }
            textBox1.AutoCompleteCustomSource = mycollection;

            con.Close();
        }
        void getDebtsHistory()
        {
            con.Open();
            int x = int.Parse(customerid);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT debt_ID as '#',item_name as 'Item Name',amount as Amount,debt_date as Date,debt_status as Completed FROM debts WHERE customer_ID_FK = '"+ x + "' ORDER BY debt_status DESC, debt_date DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }
        void getDebtsHistoryDETAILS()
        {
            con.Open();
            int x = int.Parse(debtid);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT payment_amount as 'Payment amount',payment_date AS Date FROM debts_payments WHERE debt_ID_FK = '"+x+"' "; 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customer_ID from customers where customer_name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                customerid = (myreader[0].ToString());


            }
            con.Close();
            lblid.Text = customerid;
            
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView2.Rows[index];

                {
                    
                    debtid = selectedrow.Cells[0].Value.ToString();

                    getDebtsHistoryDETAILS();


                }

            }
            catch
            {

            }
        }

        private void lblid_TextChanged(object sender, EventArgs e)
        {
            if (lblid.Text != "")
            {
                getDebtsHistory();
            }
        }
    }
}
