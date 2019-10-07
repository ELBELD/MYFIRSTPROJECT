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
    public partial class AddDebts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DateTime date = DateTime.Now;
        string stockid;
        string customerid;
        public AddDebts()
        {
            InitializeComponent();
            autocompleteCustomerName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtCustomername.AutoCompleteCustomSource = mycollection;


            con.Close();
        }
        void autocompletxtstock()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select item_name,item_price from stock";
            cmd.ExecuteNonQuery();
            SqlDataReader stockreader;
            stockreader = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (stockreader.Read())
            {
                mycollection.Add(stockreader.GetString(0));
                //txtAmount.Text = stockreader[1].ToString();
            }
            
            txtitemName.AutoCompleteCustomSource = mycollection;


            con.Close();
        }
        void autocompletxtservice()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select service_name from services";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (myreader.Read())
            {
                mycollection.Add(myreader.GetString(0));

            }
            txtitemName.AutoCompleteCustomSource = mycollection;


            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                ////add Debts
            int amount = Int32.Parse(txtAmount.Text);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO debts (customer_ID_FK, item_type, item_name, amount, remaining, debt_date, notes,debt_status) VALUES ('" + customerid + "', '" + comboBox1.Text + "', '" + txtitemName.Text + "', '" + amount + "', '" + amount + "','" + date + "', '" + txtNotes.Text + "','YES')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("done");
            }
            catch
            {

            }
        }

        private void txtCustomername_TextChanged(object sender, EventArgs e)
        {
            loadcustomerid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Services")
            {
                txtitemName.Text = "";
                autocompletxtservice();
            }
            if (comboBox1.Text == "Stock")
            {
                txtitemName.Text = "";
                autocompletxtstock();
            }

        }
        void loadcustomerid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customer_ID from customers where customer_name='" + txtCustomername.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                customerid = (myreader[0].ToString());
                

            }
            con.Close();
        }
        void loadStockid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select stockid,item_price from stock where item_name='" + txtitemName.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
               stockid = (myreader[0].ToString());
                txtAmount.Text = (myreader[1].ToString());
                
            }
            con.Close();
        }
        void loadserviceid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select service_price from services where service_name='" + txtitemName.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                
                txtAmount.Text = (myreader[0].ToString());

            }
            con.Close();
        }
        private void txtitemName_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Services")
            {
                txtAmount.Text = "";
                loadserviceid();
            }
            if (comboBox1.Text == "Stock")
            {
                txtAmount.Text = "";
                loadStockid();
            }
           
            
        }
    }
}
