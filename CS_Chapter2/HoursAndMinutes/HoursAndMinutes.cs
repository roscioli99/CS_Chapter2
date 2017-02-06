using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            int minutes = 345;
            int hours = minutes / 60;
            int remainder = minutes % 60;

            Console.WriteLine("You worked for a total of {0} minutes, or {1} hours and {2} minutes.", minutes, hours, remainder);
        }
    }
}
