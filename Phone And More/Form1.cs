using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_And_More
{
    public partial class MainMenu : Form
    {
        string b;
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            services1.BringToFront();
            
        }
        public void get(string x)
        {
            b = x.ToString();
            lbluserA.Text ="***"+b+"***";
            
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            
            StockForm rc = new StockForm();
            rc.ShowDialog();

        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            
            SellForm rc = new SellForm();
            rc.ShowDialog();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            
            HistoryForm rc = new HistoryForm();
            rc.get(lbluserA.Text);
            rc.ShowDialog();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers rc = new Customers();
            rc.ShowDialog();
        }

        private void btnDebtsHistory_Click(object sender, EventArgs e)
        {
            DebtsHistory rc = new DebtsHistory();
            rc.ShowDialog();
        }
    }
}
