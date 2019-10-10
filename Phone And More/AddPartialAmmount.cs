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
    public partial class AddPartialAmmount : Form
    {
        string b;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
        DateTime date = DateTime.Now;
        DateTime time = DateTime.Now;
        public AddPartialAmmount()
        {
            InitializeComponent();
            this.AcceptButton = button1;

        }
        public void get(string x)
        {
            b = x.ToString();
            lbldebtid.Text = b;
            
        }
        void loaddebbts()
        {
            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT amount,remaining FROM debts where debt_ID = '" + b + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtOriginalAmount.Text = myreader[0].ToString();
                    txtRemaingAmount.Text = myreader[1].ToString();

                }
               

                con.Close();
            
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltest_TextChanged(object sender, EventArgs e)
        {
            loaddebbts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //add Debts partial
                int amount = Int32.Parse(txtAmountReceived.Text);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO debts_payments (debt_ID_FK, payment_date,payment_time, payment_amount) VALUES ('"+lbldebtid.Text+"', '"+ date + "','" + time + "', '" + amount+"')";
                cmd.ExecuteNonQuery();

                    SqlCommand update = con.CreateCommand();
                    update.CommandType = CommandType.Text;
                    update.CommandText = "UPDATE debts SET remaining = (remaining -'"+amount+"') WHERE debt_ID = '"+lbldebtid.Text+"' ";
                update.ExecuteNonQuery();
                

                con.Close();
                MessageBox.Show("done");
                this.Close();
            }
            catch
            {

            }
        }

        private void AddPartialAmmount_Load(object sender, EventArgs e)
        {
            this.txtAmountReceived.Focus();
        }

        private void txtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
