using System;
namespace week_1.Week2.fundamentals
{
    public class Square
    {
        //properties
        public int Length {get; set;}
        public int Height {get; set }
        
        //Constructor
        public Square(int length, int height)
            {
                this.Length = length;
                this.Height = height;
            }
        //method 
        public void Deconstruct(out int lenght, out int height)
        {
            lenght = this.Length;
            height = this.Height;
        }
    }
}