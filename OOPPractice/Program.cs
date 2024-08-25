using System;
using System.IO;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            List<Book> library = new List<Book>();
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("Welcome to the Library Management System");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Search for a Book by Title");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine() ?? "4";

                switch (choice)
                {
                    case "1":
                        library = AddBook(library);
                        break;
                    case "2":
                        DisplayAllBooks(library);
                        break;
                    case "3":
                        SearchForBook(library);
                        break;
                    case "4":
                        continueMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.WriteLine("\nClick any keys to continue");
                Console.ReadKey();
                Console.Clear();

            }

            Console.WriteLine("Thank you for using the Library Management System!");
        }

        //Function to display details of the book
        

        public static List<Book> AddBook(List<Book> library)
        {
            Console.Clear();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine() ?? "Default Title";

            Console.Write("Enter Author: ");
            string author = Console.ReadLine() ?? "Default Author";

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine() ?? "No ISBN for this book";

            Book book = new Book(title, author, isbn);

            library.Add(book);

            return library; 
        }

        public static void DisplayAllBooks(List<Book> library)
        {
            int count = 1;

            Console.Clear();
            Console.WriteLine("Current Books in the Library: ");


            foreach (Book book in library)
            {
                Console.WriteLine($"{count}. {book.Title} by {book.Author}");
                count++;
            }
        }

        public static void SearchForBook(List<Book> library)
        {
            Console.Clear();
            string titleSearch;

            Console.Write("Enter Title of the Book: ");
            titleSearch = Console.ReadLine() ?? string.Empty;

            bool condition = false;
            foreach (Book book in library)
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