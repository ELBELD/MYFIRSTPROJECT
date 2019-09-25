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
    public partial class AddStock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        public AddStock()
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
                if (txtname.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into stock values('" + txtbarcode.Text + "','" + txtname.Text + "','" + txtquantity.Text + "','" + txtcost.Text + "','" + txtprice.Text + "','" + txtnotes.Text + "')";
                    cmd.ExecuteNonQuery();
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
