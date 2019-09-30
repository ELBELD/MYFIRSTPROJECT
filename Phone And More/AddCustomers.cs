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
   
    public partial class AddCustomers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DataTable dt;
        string id;
        public AddCustomers()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO customers (customer_name, customer_phone,customer_address) VALUES ('"+txtCustomerName.Text+"', '"+txtCustomerPhone.Text+"','"+txtCustomerAddress.Text+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Friend has been Added Successfully");
                    con.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please enter a name first");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
