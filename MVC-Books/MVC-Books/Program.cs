using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;
using Controllers;

namespace MVC_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("-Welcome to the book store!-");
            BuyController BuyController = new BuyController();
            int rta = 0;
            while (rta != 5)
            {
                Console.WriteLine("1. Buy book");
                Console.WriteLine("2. Show purchases");
                Console.WriteLine("3. Update purchase");
                Console.WriteLine("4. Delete purchase");
                Console.WriteLine("5. Exit");
                rta = int.Parse(Console.ReadLine());
                switch(rta)
                {
                    case 1:
                        BuyController.CreateBuy();
                        break;
                    case 2:
                        BuyController.ShowBuy();
                        break;
                    case 3:
                        BuyController.updateBuy();
                        break;
                    case 4:
                        BuyController.DeleteBuy();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

        }
    }
}
