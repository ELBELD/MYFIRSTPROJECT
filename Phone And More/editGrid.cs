using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_And_More
{
  public  class editGrid
    {
        private string price;
        private string quantity;
        

        public string getprice()
        {
            return this.price;
        }
        public void setprice(string _price)
        {
            this.price = _price;
        }
        public string getquantity()
        {
            return this.quantity;
        }
        public void setquantity(string _quantity)
        {
            this.quantity = _quantity;
        }
    }
}
