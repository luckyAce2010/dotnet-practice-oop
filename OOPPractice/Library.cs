using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Library
    {
        private List<Book> _library = new List<Book> ();

        public List<Book> LibraryOfBooks
        {
            get { return _library; }
            set { _library = value; }
        }


        public List<Book> AddBook()
        {
            Console.Clear();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine() ?? "Default Title";

            Console.Write("Enter Author: ");
            string author = Console.ReadLine() ?? "Default Author";

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine() ?? "No ISBN for this book";

            Book book = new Book(title, author, isbn);

            LibraryOfBooks.Add(book);

            return LibraryOfBooks;
        }

        public void DisplayAllBooks()
        {
            int count = 1;

            Console.Clear();
            Console.WriteLine("Current Books in the Library: ");


            foreach (Book book in LibraryOfBooks)
            {
                Console.WriteLine($"{count}. {book.Title} by {book.Author}");
                count++;
            }
        }

        public void SearchForBook()
        {
            Console.Clear();
            string titleSearch;

            Console.Write("Enter Title of the Book: ");
            titleSearch = Console.ReadLine() ?? string.Empty;

            bool condition = false;
            foreach (Book book in LibraryOfBooks)
            {
                if (titleSearch == book.Title)
                {
                    book.DisplayBookInfo();
                    condition = true;
                }
            }

            if (condition == false)
            {
                Console.WriteLine("No match...");
            }
        }


    }
}
