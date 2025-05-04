using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public static class BookView
    {
        public static void ShowBookList(List<Book> bookList)
        {
            Console.WriteLine("List of Books: ");
            Console.WriteLine();
            foreach (Book book in bookList)
            {
                Console.WriteLine($"Title: {book.Title} Author: {book.Author} Price: {book.Price}.");
            }
        }
        public static void ShowBook(Book book)
        {
            Console.WriteLine("-----------------------");
            Console.Write($"Title: {book.Title}");
            Console.Write($"Author: {book.Author}");
            Console.Write($"Final price: {book.Price}");
            Console.WriteLine("-----------------------");
        }
        public static Book LoadBook()
        {
            Book temp = new Book();
            Console.Write("Book's title?: ");
            temp.Title = Console.ReadLine();
            Console.Write("Book's author?: ");
            temp.Author = Console.ReadLine();
            Console.Write("Book's price?: ");
            temp.Price = double.Parse(Console.ReadLine());

            return temp;
        }
    }
}
