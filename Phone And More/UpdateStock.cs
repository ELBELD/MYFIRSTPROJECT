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
    public partial class UpdateStock : Form
    {
        string b;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        public UpdateStock()
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
            Loadstock();
        }
        public void Loadstock()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select barcode,item_name,item_qty,item_cost,item_price,notes from stock where stockid='" + lblid.Text + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtbarcode.Text = ((myreader[0].ToString()));
                    txtname.Text = ((myreader[1].ToString()));
                    txtquantity.Text = ((myreader[2].ToString()));
                    txtcost.Text = ((myreader[3].ToString()));
                    txtprice.Text = (myreader[4].ToString());
                    txtnotes.Text = (myreader[5].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update stock set barcode='" + txtbarcode.Text + "',item_name='" + txtname.Text + "',item_qty='" + txtquantity.Text + "',item_cost='" + txtcost.Text + "',item_price='" + txtprice.Text + "',notes='" + txtnotes.Text + "' where stockid='" + lblid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Loadstock();
                    MessageBox.Show("Product update Successfulyy");
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
                    cmd.CommandText = "delete from stock where stockid='" + lblid.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Loadstock();
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
