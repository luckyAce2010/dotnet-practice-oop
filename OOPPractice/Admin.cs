using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal class Admin : Users
    {

        //Constructor for admin
        public Admin(string username, string editingSoftware) : base(username, "Admin")  
        {
            EditingApps = editingSoftware;
        }


        //Implement AccessPhoto for Admin Roles
        public override void AccessPhoto()
        {
            Console.WriteLine("You have all the access for editing and viewing this photo."); 
        }

        protected override string EditingApps 
        {
            get { return base.EditingApps; }
            set { base.EditingApps = value; }
        }
    }
}
