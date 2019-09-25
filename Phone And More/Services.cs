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
    public partial class Services : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        int cost = 0, sum = 0,quantity=1;
        DateTime date = DateTime.Now;
        DateTime time = DateTime.Now;
        string stringid;
        public Services()
        {
            InitializeComponent();
            
        }
        
        public void loadtouch()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select service_name,service_cost,service_price,SID from services where service_type='touch'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridService.DataSource = dt;
            this.dataGridService.Columns["service_cost"].Visible = false;
            this.dataGridService.Columns["SID"].Visible = false;

            con.Close();

        }

        private void btntouch_Click(object sender, EventArgs e)
        {
            loadtouch();
        }
        public void loadalfa()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select service_name,service_cost,service_price,SID from services where service_type='alfa'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridService.DataSource = dt;
            this.dataGridService.Columns["service_cost"].Visible = false;
            this.dataGridService.Columns["SID"].Visible = false;
            con.Close();

        }

        private void btnalfa_Click(object sender, EventArgs e)
        {
            loadalfa();
        }

        private void dataGridService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridService.Rows[index];

                {
                    int n = dataGridInvoice.Rows.Add();
                    dataGridInvoice.Rows[n].Cells[0].Value = selectedrow.Cells[0].Value.ToString();
                    dataGridInvoice.Rows[n].Cells[1].Value = selectedrow.Cells[1].Value.ToString();
                    dataGridInvoice.Rows[n].Cells[2].Value = selectedrow.Cells[2].Value.ToString();
                    dataGridInvoice.Rows[n].Cells[4].Value = selectedrow.Cells[3].Value.ToString();

                }
                label5.Visible = true;
                lblTotalprice.Visible = true;
                tsum();
                tcost();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to cancel order?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.dataGridInvoice.Rows.Clear();
            }
            label5.Visible = false;
            lblTotalprice.Visible = false;


        }

        private void dataGridInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridInvoice.Columns[e.ColumnIndex].Name == "Options")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                        int rowindex = dataGridInvoice.CurrentCell.RowIndex;
                        dataGridInvoice.Rows.RemoveAt(rowindex); 
                }
            }
            tsum();
            tcost();
            
        }
        void tsum ()
        {
            sum = 0;
            for(int i =0; i<dataGridInvoice.Rows.Count;i++)
            {
                sum += Convert.ToInt32(dataGridInvoice.Rows[i].Cells[2].Value);
            }
            lblTotalprice.Text = sum.ToString();
        }
        void tcost()
        {
            cost = 0;
            for (int i = 0; i < dataGridInvoice.Rows.Count; i++)
            {
                cost += Convert.ToInt32(dataGridInvoice.Rows[i].Cells[1].Value);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                con.Open();
                //add service invoice
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into services_invoice(ser_inv_date,ser_inv_time,ser_inv_total_cost,ser_inv_total_price) values('" +date + "','" + time + "','" + cost + "','" + sum + "')";
                cmd.ExecuteNonQuery();
                // get invoice ID
                SqlCommand selectid = con.CreateCommand();
                selectid.CommandType = CommandType.Text;
                selectid.CommandText = "SELECT MAX(ser_inv_ID) AS ser_inv_ID FROM services_invoice";
                selectid.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = selectid.ExecuteReader();
                while (myreader.Read())
                {
                stringid = (myreader[0].ToString());
                }
                //add service to invoice 
                 myreader.Close();
            int id = Int32.Parse(stringid);
            for (int i = 0; i < dataGridInvoice.Rows.Count; i++)
                {
                    SqlCommand insert = con.CreateCommand();
                    insert.CommandType = CommandType.Text;
                    // create your parameters
                   
                    insert.CommandText = "insert into ser_inv_details(ser_inv_id,ser_inv_SID,ser_inv_quantity,ser_inv_cost,ser_inv_price) values('"+id +"','"+dataGridInvoice.Rows[i].Cells[4].Value+"','" +quantity+ "','"+dataGridInvoice.Rows[i].Cells[1].Value+"','"+dataGridInvoice.Rows[i].Cells[2].Value+"')";
                    insert.ExecuteNonQuery();
                
                 }
            
                con.Close();

                MessageBox.Show("Order Confirmed");
                this.dataGridInvoice.Rows.Clear();
                label5.Visible = false;
                lblTotalprice.Visible = false;

            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}
    }
}
