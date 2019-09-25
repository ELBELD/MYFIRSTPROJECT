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
            sidepanel.Height = button1.Height;
            services1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            services1.BringToFront();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnstock.Height;
            sidepanel.Top = btnstock.Top;
            stockcontrol1.BringToFront();
          

        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnsell.Height;
            sidepanel.Top = btnsell.Top;
            sellControl1.BringToFront();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnhistory.Height;
            sidepanel.Top = btnhistory.Top;
            historyControl1.BringToFront();

        }
    }
}
