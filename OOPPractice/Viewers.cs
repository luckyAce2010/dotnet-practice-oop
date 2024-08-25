using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal class Viewers : Users
    {
        public Viewers(string username) : base(username, "Viewers") { }

        //Make own implementation for AccessPhoto function
        public override void AccessPhoto()
        {
            Console.WriteLine("The only access for this photo is view. You don't have any access for editing");
        }
    }
}
