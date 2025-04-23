using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }   

        public Product()
        {

        }
        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public double FinalPrice()
        {
            return this.Price * 1.21;
        }
    }
}
