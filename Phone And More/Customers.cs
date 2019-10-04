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
    public partial class Customers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DataTable dt;
        string id;
        public Customers()
        {
            InitializeComponent();
            loadgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void loadgrid()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customer_ID as ID,customer_name as 'Customer Name',customer_phone as 'Phone number',customer_address as 'Address' from customers";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadgrid();
        }
        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            AddCustomers rc = new AddCustomers();
            rc.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            rc.ShowDialog();
             
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "'Customer Name' like '" + txtsearch.Text + "%'";
                dataGridView1.DataSource = dv;

            }
        }
    }
}
