using System;

/*
    Inheritance is one of the fundamental attributes of OOP. You can define a 
    child class that reuses or inherits, extends, or modifies behavior of a 
    parent class.
    C# only supports single inheritance. A class can only inherit from a single class,
    but inheritance is transitive. Basically Bicycle is a parent to a Mountain Bike Class,
    but the Mountain class can be a parent to a DownhillBike Class. The DownhillBike can gain
    attributes of the Bicycle because of the relationship between the Mountain bike and Bicycle.
 */
namespace HelloWorld.Homework1
{
    /*
        Parent or base class
     */
    public class MountainBike
    {
        // Class variable
        // Field
        private string _seat;

        // Class variable
        // Field
        private int _sprocket = 20;


        // Class variable
        // Property
        // In this case it is recommended to do the auto property way below and remove the field above
        // Use this way, if you need to do more that assign a default value.
        private string _gears;
        private int _igears = 20;
        public virtual int Sprocket
        {
            get
            {
                return _sprocket;
            }
        }

        // Class variable
        // Property
        public string Seat
        {
            set
            {
                this._seat = value;
            }
            get
            {
                return _seat;
            }
        }

        // Class variable
        // Auto Property with a default value and no ability to set a value
        public virtual int WheelSpokes { get; } = 25;

        // Class variable
        // Auto Property that is a private field with property
        public string Wheels { set; get; }

        // Class variable
        // Auto Property that is a private field with property
        public string HandleBars { set; get; }

        // Default Constructor
        public MountainBike()
        {
            Console.WriteLine("Bicycle Default");
        }

        // Constructor with parameter
        public MountainBike(string type)
        {
            Console.WriteLine("Bicycle with parameter");
        }

        // Method with parameter
        public void Pedal(string type)
        {
            Console.WriteLine(type);
        }

        // Virtual method that can be overriden by a child class
        public virtual void Brake()
        {
            Console.WriteLine("Stop with back brake.");
        }
        public override void Brake()
        [
            Console.WriteLine("Slow Down");
        ]
    }
}