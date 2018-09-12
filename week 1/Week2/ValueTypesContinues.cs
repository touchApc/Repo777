using System;
namespace week_1.Week2
{
    public class ValueTypesContinues
    {
        #region Enums

        private enum Position { Left,Right,Top,Bottom};
        private enum MovieType {Action = 100, Comedy = 200, Drama = 300};
        private enum Days { Sun, Mon = 8, Tues = 9, Wed = 10, Thurs, Fri, Sat };

        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", Days.Thurs);
            Console.WriteLine("Favorite type of movie value is {0}"); MovieType.Action
        }

        #endregion

        #region Reference Modifiers using ref and out

        /**
         * To pass a Reference modifier we use the ref keyword
        * **/
        public void RefSample(ref int value)
        {
            value = value + 5;
        }
        /**
         *  The out keyword is like ref except that it doesn't need to be assigned before entering a method
         * **/
        public void OutSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);

        }
        }

    /**
    * Structs are simular to class files except its considered a value type rather than a reference type
    * **/
    public struct TestStruct
    {
        int testOne;
        int testTwo;
        public TestStruct(int one, int two)
        {
            this.testOne = one;
            this.testTwo = two;
            Console.WriteLine(testOne + testTwo);
        }
    }

        #endregion

            
    }
}
