using System;
using System.Collections.Generic;
using System.Linq;
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

        public OrderController()
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
        }

        public void CreateOrder()
        {
            Order temp = new Order();
            temp.client = cController.LoadClient();
            temp.setProductList(OrderView.LoadProductList());
        }

        public void ShowOrder()
        {
            Order temp = new Order();
            if (temp is null)
            {
                OrderView.showMsg("There is not orders.");
            }
            else
            {
                cController.showClient(temp.client);
                pController.ShowProductList(temp.getProductList());
            }

        }
    }
}
