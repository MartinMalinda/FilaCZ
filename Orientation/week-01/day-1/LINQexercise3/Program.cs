using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squarePosNumsMethod = numbers.Where(n => n > 0).Select(n => n * n);

            squarePosNumsMethod.ToList().ForEach(n => Console.WriteLine(n));

            var squarePosNums = from number in numbers
                                where number > 0
                                select number * number;

            squarePosNums.ToList().ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
