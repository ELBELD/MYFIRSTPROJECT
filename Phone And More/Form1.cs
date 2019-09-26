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
            rc.ShowDialog();

        }
    }
}
