using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Library
    {
        private static readonly List<Book> books = new List<Book>();
        private List<Book> _library = books;

        public List<Book> AddBook()
        {
            Console.Clear();

            
            Console.Write("Enter Title: ");
            string title = ValidateInput("Title");

            Console.Write("Enter Author: ");
            string author = ValidateInput("Author");

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine() ?? "No ISBN for this book";

            Book book = new Book(title, author, isbn);

            _library.Add(book);

            return _library;
        }

        public void DisplayAllBooks()
        {
            int count = 1;

            Console.Clear();
            Console.WriteLine("Current Books in the Library: ");


            foreach (Book book in _library)
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

            //This is a list, a lambda expression with Linq to search for a book title 
            var searchedBooks = _library.Where(l => l.Title.Contains(titleSearch, StringComparison.OrdinalIgnoreCase)).ToList();

            if (searchedBooks.Count == 0) 
            {
                Console.WriteLine("No books found.");
            }

            else
            {
                int count = 0;
                foreach (Book book in searchedBooks)
                {  
                    Console.WriteLine($"{count}. {book.Title} by {book.Author}");
                    count++;
                }
            }
            
        }

        private string ValidateInput(string title)
        {

            string input = Console.ReadLine() ?? "";

            //Validation if title is empty or null
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write($"{title} cannot be empty. Enter a valid {title}: ");
                input = Console.ReadLine() ?? "";
            }

            return input;

        }


    }
}
