using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controllers;
using Models;
using Views;

namespace SistemaDePedidos.Controllers
{
    class OrderController
    {
        private ClientController cController;
        private ProductController pController;

        public OrderController()
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
        }

        public void CreateOrder()
        {
            Order temp = new Order();
            temp.client = ClientView.LoadClient();
            temp.setProductList(OrderView.LoadProductList());
        }
    }
}
