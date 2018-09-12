using System;

namespace Fundamentals
{
    public class Dinosaur
    {
        private string _teeth;
        private string _something;
        private int _size;

        protected string Color { set; get;} = "Green";

        public int Size
        { 
            set
            {
                this._size = value;
            }

            get
            {
                if(_size > 200)
                {
                    Console.WriteLine("Your huge");
                }
                return _size;
            }      
        }

        public bool Skin { set; get; }

        public string Teeth
        {
            set
            {
                this._teeth = value;
            }

            get
            {
                return _teeth;
            }
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eat");
        }

        public class Raptor : Dinosaur
        {
            public void Group()
            {
                Color = "Brown";
            }
        }


    }

    public class TRex : Dinosaur //polymorphism
    {
        public void Stomp()
        {
            Color = "Blue";
        }

        public override void Eat()
        {
            Console.WriteLine("Rip");
        }
    }
}