using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumsMethod = numbers.Where(n => n % 2 == 0);

            var evenNums = from number in numbers
                           where number % 2 == 0
                           select number;

            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
