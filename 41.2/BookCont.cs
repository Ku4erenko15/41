using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41._2
{
    internal class BookCont
    {
        private Book[] books;

        public BookCont(Book[] books)
        {
            this.books = books;
        }

        public void SortBooks(Func<Book, Book, int> compareMethod)
        {
            Array.Sort(books, new Comparison<Book>((book1, book2) => compareMethod(book1, book2)));
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

    }
}
