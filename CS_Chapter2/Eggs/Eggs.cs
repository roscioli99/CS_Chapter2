using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = 69;
            int eggsTwo = 25;
            int eggsThree = 84;
            int eggsFour = 56;

            int dozens = eggs / 12;
            int dozensTwo = eggsTwo / 12;
            int dozensThree = eggsThree / 12;
            int dozensFour = eggsFour / 12;

            int remainder = eggs % 12;
            int remainderTwo = eggsTwo % 12;
            int remainderThree = eggsThree % 12;
            int remainderFour = eggsFour % 12;

            Console.WriteLine("a total of " + eggs + " eggs is " + dozens + " dozen and " + remainder + " eggs.");
            Console.WriteLine("a total of " + eggsTwo + " eggs is " + dozensTwo + " dozen and " + remainderTwo + " eggs.");
            Console.WriteLine("a total of " + eggsThree + " eggs is " + dozensThree + " dozen and " + remainderThree + " eggs.");
            Console.WriteLine("a total of " + eggsFour + " eggs is " + dozensFour + " dozen and " + remainderFour + " eggs.");
        }
    }
}
