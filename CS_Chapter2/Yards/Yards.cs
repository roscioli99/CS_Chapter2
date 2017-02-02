using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Yards
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            double price = (length * width) / 9;

            Console.WriteLine("The cost of carpeting per square yard is $" + price);
        }
    }
}
