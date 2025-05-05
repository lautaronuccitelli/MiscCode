using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Controllers
{
    internal class BookController
    {

        public BookController()
        {
        }

        public Book LoadBook()
        {
            Console.WriteLine("------LOADING BOOK------");
            return BookView.LoadBook();
        }

        public void ShowBookList(List<Book> bookList)
        {
            BookView.ShowBookList(bookList);
        }
    }
}
