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
    public partial class StockForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DataTable dt;
        string id;
        public StockForm()
        {
            InitializeComponent();
            loadgrid();
        }
        public void loadgrid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select stockid as 'ID',barcode,item_name as 'Name',item_qty as 'Quantity',item_cost as 'Cost',item_price as 'Price',notes as 'Note' from stock";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            // dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dataGridView1.BackgroundColor = Color.White;

            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStock rc = new AddStock();
            rc.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            rc.ShowDialog();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dataGridView1.Rows[index];
                id = selectedrow.Cells[0].Value.ToString();
                UpdateStock rc = new UpdateStock();
                rc.get(id.ToString());
                rc.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
                rc.ShowDialog();

            }
            catch
            {

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Name like '%" + txtsearch.Text + "%' or barcode = '" + txtsearch.Text + "'";
                dataGridView1.DataSource = dv;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
