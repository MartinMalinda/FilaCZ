using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13
            int add = 13 + 22;
            int substract = 22 - 13;
            int multiply = 22 * 13;
            double divideDecimal = 22 / 13;
            int divide = 22 / 13;
            int remainder = 22 % 13;

            Console.WriteLine(add);
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(divideDecimal);
            Console.WriteLine(divide);
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
