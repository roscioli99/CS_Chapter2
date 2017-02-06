using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs for the first chicken?");
           String input1 = Console.ReadLine();
            Console.WriteLine("Second?");
            String input2 = Console.ReadLine();
            Console.WriteLine("Third?");
            String input3 = Console.ReadLine();
            Console.WriteLine("Fourth?");
            String input4 = Console.ReadLine();
            int chickenOne= Convert.ToInt32(input1);
            int chickenTwo = Convert.ToInt32(input2);
            int chickenThree = Convert.ToInt32(input3);
            int chickenFour = Convert.ToInt32(input4);

            int total = chickenOne + chickenTwo + chickenThree + chickenFour;

            int dozen = total / 12;
            int eggs = total % 12;

            Console.WriteLine("With a total of {0} eggs, you have {1} dozens and {2} eggs.", total, dozen, eggs);

        }
    }
}
