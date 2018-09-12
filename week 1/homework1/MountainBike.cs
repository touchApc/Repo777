using System;


namespace week_1.homework1
{
    public class MountainBike : Bicycle
    {
        private int _sprocket = 30;
        public override int _Sprocket
        {
                get{
                        return _sprocket;
                }
        }
        public MountainBike()      
        {
            Console.Write("MountainBike");
        }
    }   


}