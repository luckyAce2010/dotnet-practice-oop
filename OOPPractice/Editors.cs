using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal class Editors : Users
    {
        protected string _editingApps = string.Empty;

        //Constructor for Editors
        public Editors(string editingApps, string username) : base(username, "Editors") 
        {
            EditingApps = editingApps ;
        }

        //Getters and setters 
        protected override string EditingApps {
            get { return _editingApps; }
            set {
                if (value == "Adobe Premiere")
                {
                    throw new ArgumentException("editingApps should not be a video editing apps.");
                }
                
                _editingApps = value;
            }
        }
        //End of getter and setters

        //Override abstract function
        public override void AccessPhoto()
        {
            Console.WriteLine("You access for editing and viewing this photo but not all");
        }
    }
}
