using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        public static int Sum(int x)
        {
            int numbers = 0;
            for (int i = 0; i <= x; i++)
            {
                numbers += i;
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            Console.WriteLine("Give me a number and I will sum the numbers from 0 to number you gave me.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(number));

            Console.ReadLine();
        }
    }
}
