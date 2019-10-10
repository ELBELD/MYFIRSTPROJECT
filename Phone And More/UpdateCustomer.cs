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
    public partial class UpdateCustomer : Form
    {
        string b;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        public UpdateCustomer()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get(string x)
        {
            b = x.ToString();
            lblid.Text = b;
            loadcustomer();
        }
        public void loadcustomer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "select customer_name,customer_phone,customer_address from customers where customer_ID='"+lblid.Text+"' "; 
                cmd.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtCustomerName.Text = ((myreader[0].ToString()));
                    txtCustomerPhone.Text = ((myreader[1].ToString()));
                    txtCustomerAddress.Text = ((myreader[2].ToString()));
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update customers set customer_name='" + txtCustomerName.Text + "',customer_phone='" + txtCustomerPhone.Text + "',customer_address='" + txtCustomerAddress.Text + "' where customer_ID='" + lblid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadcustomer();
                    MessageBox.Show("Customer update Successfulyy");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("please double click on your row first ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from customers  where customer_ID='" + lblid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadcustomer();
                    MessageBox.Show("Product delete Successfulyy");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("please double click on your row first ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
