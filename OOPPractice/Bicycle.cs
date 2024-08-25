using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Bicycle : Car
    {
        private int _speed;

        public Bicycle(int speed, int numberofWheels, string name, int topSpeed) : base(numberofWheels, name) {
            Speed = speed;
            TopSpeed = topSpeed;
        }

        public int Speed 
        { 
            get { return _speed; } 
            set { _speed = value; }
        }


        // This is polymorphism
        public override void Run()
        {
            Console.WriteLine("The car " + Name + " with a wheel count of " + NumberOfWheels + " is now running");
            Console.WriteLine("The speed is " + Speed);
        }

        public override void Stop()
        {
            base.Stop();

            Console.WriteLine("with a speed of " + Speed + " is stopeed.");
        }

        //Pass the value to the parent class with a default value of 300;
        protected override int TopSpeed { get; set; } = 300;


    }
}
