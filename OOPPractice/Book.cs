using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal class Book
    {
        private string _title = "Default Title";
        private string _author = "Default Author";
        private string? _isbn;

        //Without ISBN
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        //With ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        //Getter and setters
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Isbn
        { 
            get { return _isbn ?? "No ISBN"; }
            set { _isbn = value; }
        }
        //End of getters and setters

        //
        public void DisplayBookInfo()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("ISBN : " + Isbn);
        }
    }
}
