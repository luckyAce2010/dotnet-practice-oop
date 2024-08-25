using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal abstract class Users
    {
        protected string _username = "User";
        protected string _role = "Viewer";

        //Constructor
        public Users(string username, string role) 
        { 
            _username = username;
            _role = role;
        }

        protected string Username 
        { 
            get { return _username; } 
            set { _username = value; } 
        }
        protected string Role 
        {
            get { return _role; }
            set { _role = value; }
        }

        //Abstraction
        public abstract void AccessPhoto();


        //Get value from child class
        private string _editingApps = "no editing apps";

        protected virtual string EditingApps 
        {
            get { return _editingApps; }
            set 
            {
                if (value == "Adobe Premiere")
                {
                    throw new ArgumentException("editingApps should not be a video editing apps.");
                }

                _editingApps = value;
            }
        }

        public void DisplayEditingApps()
        {
            if (EditingApps == null)
            {
                Console.WriteLine("This user have no access to editing apps");
            }
            else
            {
                Console.WriteLine($"Editing apps is {EditingApps}");
            }
        }

    }
}
