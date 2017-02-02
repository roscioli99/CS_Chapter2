using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Carpet
    {
        static void Main(string[] args)
        {
            int length = 8;
            int width = 6;
            double price = (length * width);

            Console.WriteLine("The total cost of the carpeting per square foot is $" + price);
        }
    }
}
