using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class BookIterator : IBookIterator
    {
        private List<Book> books;
        private int currentIndex = 0;

        public BookIterator(List<Book> books)
        {
            this.books = books;
        }
        public bool HasNext()
        {
            return currentIndex < books.Count;
        }

        public Book Next()
        {
            return books[currentIndex++];
        }
    }
}
