using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41._2
{
    internal class Book
    {
        private string title;
        private string author;
        private string publisher;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {Publisher}";
        }
    }
}
