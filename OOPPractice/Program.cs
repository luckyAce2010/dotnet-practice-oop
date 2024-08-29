using System;
using System.IO;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Variables
            //Library library = new Library();
            //bool continueMenu = true;

            //while (continueMenu)
            //{
            //    Console.WriteLine("Welcome to the Library Management System");
            //    Console.WriteLine("1. Add a Book");
            //    Console.WriteLine("2. Display All Books");
            //    Console.WriteLine("3. Search for a Book by Title");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");

            //    string choice = Console.ReadLine() ?? "4";

            //    switch (choice)
            //    {
            //        case "1":
            //            library.AddBook();
            //            break;
            //        case "2":
            //            library.DisplayAllBooks();
            //            break;
            //        case "3":
            //            library.SearchForBook();
            //            break;
            //        case "4":
            //            continueMenu = false;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Input");
            //            break;
            //    }

            //    Console.WriteLine("\nClick any keys to continue");
            //    Console.ReadKey();
            //    Console.Clear();

            //}

            //Console.WriteLine("Thank you for using the Library Management System!");



            /////////////////////////////// Practicing Lambda expressions /////////////////////////////
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Grades = new List<int> { 90, 85, 92, 88 } },
                new Student { Name = "Bob", Grades = new List<int> { 70, 75, 80, 60 } },
                new Student { Name = "Charlie", Grades = new List<int> { 100, 95, 98, 97 } },
                new Student { Name = "David", Grades = new List<int> { 50, 45, 55, 60 } },
                new Student { Name = "Eva", Grades = new List<int> { 88, 92, 80, 85 } }
            };

            //1. Find students average above 85
            var studentDescending = students.Where(s => s.Average > 85)
                                            .OrderByDescending(s => s.Average);


            Console.WriteLine("Students above 85: ");
            int count = 1;
            foreach (var s in studentDescending)
            {
                Console.WriteLine($"{count}. {s.Name} - {s.Average}");
                count++;
            }
            Console.WriteLine();

            //2. Find the student who has the highest average
            var highestStudent = studentDescending.FirstOrDefault() ?? new Student { Name = "" };

            Console.WriteLine("Highest Student");
            Console.WriteLine($"Congratulations to {highestStudent.Name} for being the top 1 in Class with an average of {highestStudent.Average}");
            Console.WriteLine();

            //3. Count the number of students who have a failing grade of 60 
            int failedStudents = students.Count(s => s.Average <= 60);
            Console.WriteLine("Number of failed students: " + failedStudents);
            Console.WriteLine();

            //4. Find all students who scored 100
            var student100 = students.Where(s => s.Grades.Contains(100));
            Console.WriteLine("Students who scored 100: ");
            foreach (var s in student100)
            {
                Console.WriteLine($"{s.Name}");
            }
            Console.WriteLine();

            //5. Display the names of students and their average grades in descending order of the average grade.
            var descendingStudentByAverage = students.OrderByDescending(s => s.Average);

            Console.WriteLine("Student from highest to lowest");
            foreach (var s in descendingStudentByAverage)
            {
                Console.WriteLine($"{s.Name} - {s.Average}");
            }
            Console.WriteLine();

            // Group students by their average grade ranges
            var groupedByAverage = students.GroupBy(s =>
            {
                var average = s.Grades.Average();
                if (average >= 90) return "90-100";
                if (average >= 80) return "80-89";
                if (average >= 70) return "70-79";
                if (average >= 60) return "60-69";
                return "Below 60";
            }).OrderByDescending(s => s.Key);

            Console.WriteLine("Students grouped by average grade ranges:");
            foreach (var group in groupedByAverage)
            {
                Console.WriteLine($"\nGrade Range: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($" - {student.Name}: {student.Grades.Average():F2}");
                }
            }

            // Calculate the overall average grade
            double overallAverage = students.Select(s => s.Average).Average();
            Console.WriteLine($"\nOverall average grade of all students: {overallAverage:F2}");

            // Display students whose average is below the overall average
            var belowAverageStudents = students.Where(s => s.Grades.Average() < overallAverage);

            Console.WriteLine("\nStudents with an average grade below the overall average:");
            foreach (var student in belowAverageStudents)
            {
                Console.WriteLine($"{student.Name}: {student.Grades.Average():F2}");
            }
        }

    }


    //For lambda expressions
    class Student
    {
        public required string Name { get; set; } = "Default Name";
        public List<int> Grades { get; set; } = new List<int> ();

        //Check if Grades does not contain any numbers and if it contains value it will average it.
        public double Average => Grades.Any() ? Grades.Average() : 0.0;
    }

}