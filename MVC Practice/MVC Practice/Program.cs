using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Views;
using Controllers;

namespace MVC_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            OrderController oController = new OrderController();
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine("1. Add Order.");
                Console.WriteLine("2. Show Orders.");
                Console.WriteLine("3. Update Order.");
                Console.WriteLine("4. Delete Order.");
                Console.Write("Select an option (1-4)");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        oController.CreateOrder();
                        break;
                    case 2:
                        oController.ShowOrder();
                        break;
                    case 3:

                        break;
                }
            }
        }
    }
}
