using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Views;

namespace Controllers
{
    internal class ClientController
    {
        public ClientController()
        {

        }

        public Client LoadClient()
        {
            Console.WriteLine("------LOADING CLIENT------");
            return ClientView.LoadClient();
        }

        public void showClient(Client temp)
        {
            ClientView.showClient(temp);
        }

    }
}
