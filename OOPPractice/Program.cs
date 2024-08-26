using System;
using System.IO;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Library library = new Library();
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
                        library.AddBook();
                        break;
                    case "2":
                        library.DisplayAllBooks();
                        break;
                    case "3":
                        library.SearchForBook();
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
        

        


    }

}