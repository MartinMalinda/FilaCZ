using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddNumsAverageMethod = numbers.Where(n => n % 2 == 1 || n % 2 == -1).Average();

            var oddNumsAverage = from number in numbers
                                 where number % 2 == 1 || number % 2 == -1
                                 select number;

            Console.WriteLine(oddNumsAverage.Average());
        }
    }
}
