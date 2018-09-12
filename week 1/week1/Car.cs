using System;

public class Car : Vehicle
{
    public override void CloseWindow() //example of polymorphism from the child class
        {
            Console.WriteLine("My Car Window is closed");
        }
}