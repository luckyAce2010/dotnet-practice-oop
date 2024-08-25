using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    internal abstract class Car
    {
        protected int _numberOfWheels;
        protected string? _name;

        // Constructor
        public Car(int numberOfWheels, string name) {
            NumberOfWheels = numberOfWheels;
            Name = name;
        }


        //Getter and setter
        public int NumberOfWheels {  
            get { return _numberOfWheels; } 
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("There is no vehicle with negative wheels");
                    throw new ArgumentException("Invalid Input");
                }   

                _numberOfWheels = value;
            }
        }

        public string Name
        {
            get { return _name ?? string.Empty; }
            set
            {
                if (value == "Ace Car")
                {
                    _name = "Default Car";
                    Console.WriteLine("There is no car brand Ace");
                    throw new ArgumentException("Invalid Input Name");
                }

                _name = value;
            }
        }
        //End getter and setter



        //This is a abstraction
        public abstract void Run();



        //This is for polymorphism
        public virtual void Stop()
        {
            Console.Write("The " + Name);
        }


        //This is how you get a value from a child class
        protected virtual int TopSpeed { get; set; }

        public void DisplayTopSpeed()
        {
            Console.WriteLine($"The top speed is {TopSpeed}");
        }



    }
}
