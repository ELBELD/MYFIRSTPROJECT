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
    public partial class HistoryControl : UserControl
    {
       
        
        public HistoryControl()
        {
            InitializeComponent();
           
            
        }


        private void btnServiceInvoice_Click(object sender, EventArgs e)
        {
            serviceInvoiceControl1.BringToFront();
        }
          

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            //sellInvoiceControl1.BringToFront();
        }

        
    }
}
