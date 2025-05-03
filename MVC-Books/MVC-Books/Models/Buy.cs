using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Buy
    {
        public User user { get; set; }
        private List<Book> bookList = new List<Book>();

        public int Id { get; set; }
        public DateTime BuyDate { get; set; }
        public Buy()
        {

        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Book book in bookList)
            {
                total += book.Price;
            }
            return total;
        }

        public List<Book> GetBookList()
        {
            return this.bookList;
        }

        public void SetBookList(List<Book> list)
        {
            this.bookList = list;
        }
    }
}
