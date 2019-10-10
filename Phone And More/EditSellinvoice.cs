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
    public partial class EditSellinvoice : Form
    {
        private editGrid editgrid;
        public editGrid getprice()
        {
            return this.editgrid;
        }
        public void setprice(editGrid _editgrid)
        {
            this.editgrid = _editgrid;

        }
        public editGrid getquantity()
        {
            return this.editgrid;
        }
        public void setquantity(editGrid _editgrid)
        {
            this.editgrid = _editgrid;

        }

        public EditSellinvoice()
        {
            InitializeComponent();
            editgrid = new editGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            editgrid.setprice(txtprice.Text);
            editgrid.setquantity(txtquantity.Text);
            
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
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
