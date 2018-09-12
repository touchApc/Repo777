using System;

public class Vehicle
{
//reference type Field
//Private variables should use underscore
private string _color;

public string Color
//Normal Property
{
    get
     {
        return _color;
     }
    set {
    Console.WriteLine(value);
    this._color = value;
    }
}

//Automatic Property
    public string WheelType { get; set;}

    //Default Constructor
    public Vehicle();
    [
        Console.WriteLine("Default Constructor");
    ]
    public Vehicle(string type )// Constructor with a parameter
    public virtual void CloseWindow()
    {
        Console.WriteLine("Vehicle Window Closed");
    }
    public void OpenDoor() // Method with no parameters
    {
        Console.WriteLine("Door is Open");
    }
}
