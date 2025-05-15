using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
       {
            new Book("C# Programming", "John Doe", "Tech Press"),
            new Book("Java Basics", "Jane Smith", "Code Publisher"),
            new Book("C# Advanced", "John Doe", "Tech Press"),
            new Book("Learning Python", "Alice Johnson", "Code Publisher")
       };

            BookCont bookContainer = new BookCont(books);

            Console.WriteLine("Книги, отсортированные по названию:");
            bookContainer.SortBooks(CompareByTitle);
            bookContainer.PrintBooks();

            Console.WriteLine("\nКниги, отсортированные по автору:");
            bookContainer.SortBooks(CompareByAuthor);
            bookContainer.PrintBooks();

            Console.WriteLine("\nКниги, отсортированные по издательству:");
            bookContainer.SortBooks(CompareByPublisher);
            bookContainer.PrintBooks();
            Console.ReadKey();
        }
        public static int CompareByTitle(Book book1, Book book2)
        {
            return string.Compare(book1.Title, book2.Title);
        }

        public static int CompareByAuthor(Book book1, Book book2)
        {
            return string.Compare(book1.Author, book2.Author);
        }

        public static int CompareByPublisher(Book book1, Book book2)
        {
            return string.Compare(book1.Publisher, book2.Publisher);
        }
    }
}
