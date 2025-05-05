using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Controllers
{
    internal class UserController
    {
        public UserController()
        {

        }

        public User LoadUser()
        {
            Console.WriteLine("------LOADING USER------");
            return UserView.LoadUser();
        }

        public void showUser(User temp)
        {
            UserView.showUser(temp);
        }
    }
}
