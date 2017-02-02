using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleDecimalTest
{
    class DoubleDecimalTest
    {
        static void Main(string[] args)
        {
            decimal value = 122334455667788912341234.9887766554433221M;
            double value2 = 1.79769313486231E+308; // 1223344556677889123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412233445566778891232341223344556677889123234122334455667788912323412233445566778891232341223344556677889123.9887766554433221;
            Console.WriteLine(Double.MaxValue);
            Console.WriteLine(Decimal.MaxValue);
            Console.WriteLine(value);
            Console.WriteLine(value2);
        }
    }
}
