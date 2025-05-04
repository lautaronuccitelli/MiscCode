using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public static class BuyView
    {
        public static void ShowBooks(List<Book> list)
        {
            BookView.ShowBookList(list);
        }

        public static void ShowUser(User user)
        {
            UserView.showUser(user);
        }

        public static List<Book> LoadBookList()
        {
            string resp = "n";
            List<Book> temp = new List<Book>();
            do
            {
                temp.Add(BookView.LoadBook());
                Console.WriteLine("Add another book? Y/N");
                resp = Console.ReadLine();
            } while (resp.ToLower() != "n");

            return temp;
        }
        public static void showMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
