using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Views
{
    public static class ProductView
    {
        public static void ShowProductList(List<Product> productlist)
        {
            Console.WriteLine("Product List:");
            foreach (var product in productlist)
            {
                Console.WriteLine($"Name: {product.Name}, Description: {product.Description}, Price: {product.Price}€");
            }
        }
        public static void ShowProduct(Product product)
        {
            Console.WriteLine("-----------------------");
            Console.Write($"Name: {product.Name}");
            Console.Write($"Price: {product.Price}");
            Console.Write($"Final price: {product.FinalPrice()}");
            Console.Write($"Info: {product.Description}");
            Console.WriteLine("-----------------------");
        }

        public static Product LoadProduct()
        {
            Product temp = new Product();
            Console.WriteLine("Product name?");
            temp.Name = Console.ReadLine();
            Console.WriteLine("Product price?");
            temp.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Product description?");
            temp.Description = Console.ReadLine();

            return temp;
        }
    }
}
