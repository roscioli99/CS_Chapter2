using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Egg
    {
        static void Main(string[] args)
        {
            int eggs = 69;
            int eggsTwo = 97;
            int eggsThree = 53;
            int eggsFour = 25;

            int dozen = eggs / 12;
            int dozenTwo = eggsTwo / 12;
            int dozenThree = eggsThree / 12;
            int dozenFour = eggsFour / 12;

            int remainder = eggs % 12;
            int remainderTwo = eggsTwo % 12;
            int remainderThree = eggsThree % 12;
            int remainderFour = eggsFour % 12;

            Console.WriteLine("A total of " + eggs + " eggs is " + dozen + " dozen and " + remainder + " eggs.");
            Console.WriteLine("A total of " + eggsTwo + " eggs is " + dozenTwo + " dozen and " + remainderTwo + " eggs.");
            Console.WriteLine("A total of " + eggsThree + " eggs is " + dozenThree + " dozen and " + remainderThree + " eggs.");
            Console.WriteLine("A total of " + eggsFour + " eggs is " + dozenFour + " dozen and " + remainderFour + " eggs.");
        }
    }
}
