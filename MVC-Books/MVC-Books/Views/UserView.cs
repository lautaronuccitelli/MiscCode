using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public static class UserView
    {
        public static void showUser(User user)
        {
            Console.Write($"|ID: {user.Id}|");
            Console.Write($" |Name: {user.Name}|");
            Console.Write($" |Email: {user.Email}|");
            Console.Write($" |Phone: {user.Phone}|");
            Console.WriteLine($" |Adress: {user.Address}|");
        }
        public static User LoadUser()
        {
            Console.Write("ID: ");
            string Id = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Phone: ");
            string Phone = Console.ReadLine();
            Console.Write("Address: ");
            string Address = Console.ReadLine();

            User temp = new User(int.Parse(Id), name, Email, Phone, Address);
            return temp;
        }
    }
}
