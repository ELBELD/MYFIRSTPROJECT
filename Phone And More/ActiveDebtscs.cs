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
    public partial class ActiveDebts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        
        string ID;
        DateTime date = DateTime.Now;
        DateTime time = DateTime.Now;
        public ActiveDebts()
        {
            InitializeComponent();
            loadgrid();
            addbuttontogrid();
            sumdebts();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiveDebtscs_Load(object sender, EventArgs e)
        {

        }
        void addbuttontogrid()
        {
            try {
                //add first button
                DataGridViewButtonColumn Partial = new DataGridViewButtonColumn();
                Partial.Name = "Partial Payments";
                Partial.Text = "Partial";
                int columnIndex = 8;
                Partial.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Partial"] == null)
                {
                    dataGridView1.Columns.Insert(columnIndex, Partial);
                }
                //add second button
                DataGridViewButtonColumn Full = new DataGridViewButtonColumn();
                Full.Name = "Full Payments";
                Full.Text = "Full";
                int columnIndex2 = 9;
                Full.UseColumnTextForButtonValue = true;
                if (dataGridView1.Columns["Full"] == null)
                {
                    dataGridView1.Columns.Insert(columnIndex2, Full);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void loadgrid()
        {
            try {
                DataTable dt;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT debt_ID, customer_ID_FK, customer_name as 'Customer name', item_name as 'Item name',amount as Amount, remaining as Remaining, debt_date as Date, notes FROM debts INNER JOIN customers ON customer_ID_FK = customer_ID WHERE debt_status = 'NO' ";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["debt_ID"].Visible = false;
                this.dataGridView1.Columns["customer_ID_FK"].Visible = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnAddDebts_Click(object sender, EventArgs e)
        {
            AddDebts rc = new AddDebts();
            rc.ShowDialog();
            loadgrid();
            sumdebts();
        }
        void sumdebts()
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select SUM(remaining) from debts where debt_status='NO' ";
                cmd.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    lblTotalDebts.Text = ((myreader[0].ToString()));
                   

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Partial Payments")
                {
                    int index = e.RowIndex;

                    DataGridViewRow selectedrow = dataGridView1.Rows[index];
                    ID = selectedrow.Cells[2].Value.ToString();
                    AddPartialAmmount rc = new AddPartialAmmount();
                    rc.get(ID.ToString());
                    rc.ShowDialog();
                    loadgrid();
                    sumdebts();

                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Full Payments")
                {
                    int index2 = e.RowIndex;
                    DataGridViewRow selectedrow2 = dataGridView1.Rows[index2];
                    string ID2 = selectedrow2.Cells[2].Value.ToString();
                    con.Open();
                    //add Debts Full payment
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO debts_payments(debt_ID_FK, payment_date,payment_time, payment_amount) VALUES ('" + ID2 + "', '" + date + "','" + time + "', (SELECT remaining FROM debts WHERE debt_ID = '" + ID2 + "'))";
                    cmd.ExecuteNonQuery();
                    SqlCommand update = con.CreateCommand();
                    update.CommandType = CommandType.Text;
                    update.CommandText = "UPDATE debts SET remaining = 0,debt_status = 'YES' WHERE debt_ID = '" + ID2 + "'";
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("done");
                    loadgrid();
                    sumdebts();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
