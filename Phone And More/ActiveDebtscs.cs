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
        DataTable dt;
        string ID;
        public ActiveDebts()
        {
            InitializeComponent();
            loadgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiveDebtscs_Load(object sender, EventArgs e)
        {

        }
        void loadgrid()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT debt_ID, customer_ID_FK, customer_name as 'Customer name', item_name as 'Item name',amount as Amount, remaining as Remaining, debt_date as Date, notes FROM debts INNER JOIN customers ON customer_ID_FK = customer_ID ";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["debt_ID"].Visible = false;
            this.dataGridView1.Columns["customer_ID_FK"].Visible = false;
            con.Close();
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
        private void btnAddDebts_Click(object sender, EventArgs e)
        {
            AddDebts rc = new AddDebts();
            rc.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Partial Payments")
            {
                int index = e.RowIndex;

                DataGridViewRow selectedrow = dataGridView1.Rows[index];
            ID = selectedrow.Cells[2].Value.ToString(); 
             AddPartialAmmount rc = new AddPartialAmmount();
            rc.get(ID.ToString());
            rc.ShowDialog();
        }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Full")
            {


            }
        }
    }
}
