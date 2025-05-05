using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Controllers
{
    internal class BuyController
    {
        private UserController uController;
        private BookController bController;
        private List<Buy> orders;

        public BuyController()
        {
            this.uController = new UserController();
            this.bController = new BookController();
            this.orders = new List<Buy>();
        }
        public void CreateBuy()
        {
            Buy temp = new Buy();
            temp.user = uController.LoadUser();
            temp.SetBookList(BookView.LoadBookList());
            orders.Add(temp);
        }

        public void ShowBuy()
        {
            if(orders.Count == 0)
            {
                Console.WriteLine("No purchases loaded.");
            }
            else
            {
                Console.WriteLine("------SHOWING BUYS------");
                foreach (Buy order in orders)
                {
                    BuyView.ShowUser(order.user);
                    BuyView.ShowBooks(order.GetBookList());
                    Console.WriteLine("Total: " + order.CalculateTotal());
                    Console.WriteLine();
                }
            }
        }
        public void updateBuy()
        {
            Console.WriteLine("------UPDATING PURCHASE------");
            ShowBuy();

            Console.WriteLine($"Enter the ID of the purchase you want to update (1 to {orders.Count}): ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 1 || id > orders.Count)
            {
                BuyView.showMsg("Invalid ID.");
                return;
            }

            Buy temp = orders[id - 1]; 
            temp.user = uController.LoadUser();
            temp.SetBookList(BookView.LoadBookList());
            Console.WriteLine("Purchase updated.");
        }

        public void DeleteBuy()
        {
            Console.WriteLine("------DELETING PURCHASE------");
            ShowBuy();

            Console.WriteLine($"Enter the ID of the purchase you want to delete (1 to {orders.Count}): ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 1 || id > orders.Count)
            {
                BuyView.showMsg("Invalid ID.");
                return;
            }

            orders.RemoveAt(id - 1); 
            Console.WriteLine("Purchase deleted.");
        }
    }
}