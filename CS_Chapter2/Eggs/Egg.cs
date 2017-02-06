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

            int totalEggs = eggs + eggsTwo + eggsThree + eggsFour;

            int dozen = totalEggs / 12;

            int remainder = totalEggs % 12;

            Console.WriteLine("A total of " + totalEggs + " eggs is " + dozen + " dozen and " + remainder + " eggs.");
        }
    }
}
