using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            var biggerThanTwentyMethod = numbers.Where(n => n * n > 20);
            biggerThanTwentyMethod.ToList().ForEach(n => Console.WriteLine(n));

            var biggerThanTwenty = from number in numbers
                                   where number * number > 20
                                   select number;

            biggerThanTwenty.ToList().ForEach(number => Console.WriteLine(number));

            Console.ReadLine();
        }
    }
}
