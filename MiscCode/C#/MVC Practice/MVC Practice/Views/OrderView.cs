using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Views
{
    public static class OrderView
    {
        public static void ShowProducts(List<Product> list)
        {
            ProductView.ShowProductList(list);
        }

        public static void ShowClient(Client client)
        {
            ClientView.showClient(client);
        }

        public static List<Product> LoadProductList()
        {
            string resp = "n";
            List<Product> temp = new List<Product>();
            do
            {
                temp.Add(ProductView.LoadProduct());
                Console.WriteLine("Add another product? Y/N");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");

            return temp;
        }
    }
}
