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
    public partial class SellControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DataTable table = new DataTable();
        string name,qunatity="1", price,barcode;
        public SellControl()
        {
            InitializeComponent();
           
            autocompletxt();
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Unit Price", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Total Price", typeof(string));
            dataGridView1.DataSource = table;

        }

       
        void autocompletxt()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select item_name from stock";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (myreader.Read())
            {
                mycollection.Add(myreader.GetString(0));
                
            }
            txtselect.AutoCompleteCustomSource = mycollection;
           

            con.Close();
        }
        void loadid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select stockid,item_name,item_qty,item_price,barcode from stock where item_name='" + txtselect.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                lblid.Text = (myreader[0].ToString());
                name = (myreader[1].ToString());
                //qunatity = (myreader[2].ToString());
                price = (myreader[3].ToString());
                barcode = (myreader[4].ToString());
            }
            con.Close();
        }

        private void btnChekout_Click(object sender, EventArgs e)
        {

        }

        private void txtselect_TextChanged(object sender, EventArgs e)
        {
            loadid();
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtselect_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   
                    int x, y;
                    x = int.Parse(price);
                    y = int.Parse(qunatity);
                    table.Rows.Add(barcode, name, price, qunatity, x * y);
                    dataGridView1.DataSource = table;
                    name = "";
                    qunatity = "1";
                    price = "";
                    txtselect.Focus();
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);

                    }
                    label5.Visible = true;
                    lblTotalprice.Visible = true;
                    btnChekout.Visible = true;
                    lblTotalprice.Text = sum.ToString();
                    txtselect.Text = "";
                    lblid.Text = "";
                    name = "";
                    qunatity = "1";
                    price = "";
                    barcode = "";

                }
            }
            catch
            {

            }
        }
    }
}
