using System;
using System.IO;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cars
            Bicycle bicycle1 = new Bicycle(5, 1, "Bicycle", 500);

            bicycle1.Run();
            bicycle1.Stop();

            bicycle1.DisplayTopSpeed();


            //Role base access 
            Admin admin = new Admin("Adobe Photoshop", "Admin1");
            Editors editor = new Editors("Adobe Photoshop", "Editor1");
            Viewers viewer = new Viewers("Viewer1");


            AccessPhoto(admin);
            AccessPhoto(viewer);
            AccessPhoto(editor);
        }

        public static void AccessPhoto(Users users)
        {
            users.AccessPhoto();
            users.DisplayEditingApps();
            Console.WriteLine();
        }

    }
}