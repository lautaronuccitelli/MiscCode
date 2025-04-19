using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Order
    {
        public Client client { get; set; }
        private List<Product> productList = new List<Product>();

        public Order()
        {

        }

        public double IVAtotal()
        {
            double total = 0;
            foreach (Product product in productList)
            {
                total += product.FinalPrice();
            }
            return total;
        }

        public double calculateTotal()
        {
            double total = 0;
            foreach (Product product in productList)
            {
                total += product.Price;
            }
            return total;
        }
        public List<Product> getProductList()
        {
            return this.productList;
        }

        public void setProductList(List<Product> list)
        {
            this.productList = list;
        }
    }
}
