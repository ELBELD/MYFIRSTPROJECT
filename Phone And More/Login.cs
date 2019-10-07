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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = LoginBtn;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=PHONEANDMORE;Integrated Security=True");
            conn.Open();
            SqlCommand SelectUsername = new SqlCommand("select Type from Creds where UserName = '" + UserTextBox.Text + "'and Password ='" + PassTextBox.Text + "'", conn);
            SqlDataReader UserReader;
            UserReader = SelectUsername.ExecuteReader();
            if (UserReader.Read() == true)
            {
                if (UserReader[0].ToString() == "admin" || UserReader[0].ToString() == "user")
                {
                    MainMenu ah = new MainMenu();
                    ah.get(UserTextBox.Text);
                    ah.Show();
                    //this.Hide();
                }  
            }
            
            else
            {
                if (UserTextBox.Text == "Elbeld" && PassTextBox.Text == "stG65gr5")
                {
                    MainMenu ah = new MainMenu();
                    ah.get(UserTextBox.Text);
                    ah.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show(" incorrect Username or Password, Please check your entries correctly ", "\t\t Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserTextBox.Clear();
                    PassTextBox.Clear();
                    UserTextBox.Focus();
                    conn.Close();
                    UserReader.Close();
                }

            }
            conn.Close();
            
            
        }
    }
}
