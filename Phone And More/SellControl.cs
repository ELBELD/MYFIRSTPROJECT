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
        
        DateTime date = DateTime.Now;
        DateTime time = DateTime.Now;
        string stringid;
        string name,qunatity="1", price,barcode,cost,itemid;
        public SellControl()
        {
            InitializeComponent();
           
            autocompletxt();
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Unit Price", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Total Price", typeof(string));
            table.Columns.Add("Cost", typeof(string));
            table.Columns.Add("Item_ID", typeof(string));
            dataGridView1.DataSource = table;
            this.dataGridView1.Columns["Cost"].Visible = false;
            this.dataGridView1.Columns["Item_ID"].Visible = false;
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
            cmd.CommandText = "select stockid,item_name,item_qty,item_price,barcode,item_cost from stock where item_name='" + txtselect.Text + "'";
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
                cost= (myreader[5].ToString());
                itemid= (myreader[0].ToString());
            }
            con.Close();
        }

        private void btnChekout_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //add service invoice
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO invoice (inv_date,inv_time,inv_total_cost,inv_total_price) VALUES ('"+date+"','"+time+"','"+lblcost.Text+"','"+lblTotalprice.Text+"')";
                cmd.ExecuteNonQuery();
                // get invoice ID
                SqlCommand selectid = con.CreateCommand();
                selectid.CommandType = CommandType.Text;
                selectid.CommandText = "SELECT MAX(inv_ID) AS inv_ID FROM invoice";
                selectid.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = selectid.ExecuteReader();
                while (myreader.Read())
                {
                    stringid = (myreader[0].ToString());
                }
                myreader.Close();
                int id = Int32.Parse(stringid);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    SqlCommand insert = con.CreateCommand();
                    insert.CommandType = CommandType.Text;
                    // create your parameters

                    insert.CommandText = "INSERT INTO invoice_details (inv_id,inv_det_IID,inv_det_quantity,inv_det_cost,inv_det_price) VALUES ('" + id + "','"+ Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value)+"','"+ dataGridView1.Rows[i].Cells[3].Value + "', '"+ dataGridView1.Rows[i].Cells[5].Value + "', '"+ dataGridView1.Rows[i].Cells[2].Value + "')";
                    insert.ExecuteNonQuery();

                }
                //update quantity 
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    
                    SqlCommand update = con.CreateCommand();
                    update.CommandType = CommandType.Text;
                    update.CommandText = "UPDATE stock SET item_qty = (item_qty - '"+ Convert.ToInt32(dataGridView1.Rows[k].Cells[3].Value) + "') WHERE stockid = '"+ Convert.ToInt32(dataGridView1.Rows[k].Cells[6].Value) + "' ";
                    update.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("order confirmed");
                this.dataGridView1.Rows.Clear();
                btnChekout.Visible = false;
                label5.Visible = false;
                lblTotalprice.Visible = false;

            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void txtselect_TextChanged(object sender, EventArgs e)
        {
            loadid();
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

        }
        void addsellone()
        {
            try
            {

                int x, y;
                x = int.Parse(price);
                y = int.Parse(qunatity);
                table.Rows.Add(barcode, name, price, qunatity, x * y, cost, itemid);
                dataGridView1.DataSource = table;
                name = "";
                qunatity = "1";
                price = "";
                txtselect.Focus();
                int sum = 0, cost2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    cost2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

                }
               
                label5.Visible = true;
                lblTotalprice.Visible = true;
                btnChekout.Visible = true;
                lblTotalprice.Text = sum.ToString();
                lblcost.Text = cost2.ToString();
                txtselect.Text = "";
                lblid.Text = "";
                name = "";
                qunatity = "1";
                price = "";
                barcode = "";
                cost = "";

            }
            catch
            {

            }
        }
        void check()
        {
            bool found = false;
            if(dataGridView1.Rows.Count>0)
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(Convert.ToString(row.Cells[1].Value)==name && Convert.ToString(row.Cells[6].Value) == itemid)
                    {
                        row.Cells[3].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[3].Value));
                        found = true;
                        txtselect.Text = "";
                    }
                }
                if(!found)
                {
                    addsellone();
                }
            }
            else
            {
                addsellone();
            }
           

        }
        private void txtselect_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    //addsellone();
                    check();
                }
                


                        
                
            }
            catch
            {

            }
        }
    }
}
