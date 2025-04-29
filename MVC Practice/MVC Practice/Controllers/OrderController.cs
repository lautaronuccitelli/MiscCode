using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Controllers;
using Models;
using Views;

namespace Controllers
{
    class OrderController
    {
        private ClientController cController;
        private ProductController pController;
        private List<Order> orders;

        public OrderController()
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
            this.orders = new List<Order>();
        }

        public void CreateOrder()
        {
            Order temp = new Order();
            temp.client = cController.LoadClient();
            temp.setProductList(OrderView.LoadProductList());
            orders.Add(temp);
        }

        public void ShowOrder()
        {
            if (orders.Count == 0) 
            {
                OrderView.showMsg("There are no orders.");
            }
            else
            {
                foreach (var order in orders) 
                {
                    Console.WriteLine("--- Order Details ---");
                    cController.showClient(order.client);
                    pController.ShowProductList(order.getProductList());
                    Console.WriteLine($"Total (excluding IVA): {order.calculateTotal():C}");
                    Console.WriteLine($"Total (including IVA): {order.IVAtotal():C}");
                    Console.WriteLine("--------------------");
                }
            }
        }

        public void UpdateOrder()
        {
            if (orders.Count == 0)
            {
                OrderView.showMsg("No orders.");
                return;
            }

            ShowOrder();

            Console.WriteLine($"Enter the number of the order to edit (1 to {orders.Count})");
            int orderIndex = int.Parse(Console.ReadLine());
            Order order = orders[orderIndex - 1];

            Console.WriteLine("What do you want to update?");
            Console.WriteLine("1: Clients");
            Console.WriteLine("2: Products");
            Console.WriteLine("Select an option: ");
            int updateOption = int.Parse(Console.ReadLine());

            switch (updateOption)
            {
                case 1:
                    order.client = cController.LoadClient();
                    OrderView.showMsg("Clients details updated.");
                    break;
                case 2:
                    order.setProductList(OrderView.LoadProductList());
                    OrderView.showMsg("Products list updated.");
                    break;
            }
        }

       public void DeleteOrder()
        {
            if(orders.Count == 0)
            {
                OrderView.showMsg("There are no orders.");
                return;
            }

            ShowOrder();

            Console.WriteLine($"Enter the number of the order to edit (1 to {orders.Count})");
            int orderIndex = int.Parse(Console.ReadLine());

            Console.WriteLine($"Are you sure you want to delete the order {orderIndex}? (Y/N)");
            string rta = Console.ReadLine().ToLower();
            if(rta == "y")
            {
                orders.RemoveAt(orderIndex - 1);
                OrderView.showMsg("Order deleted.");
            }
            else
            {
                OrderView.showMsg("Deletion canceled.");
            }
        }
    }
}
