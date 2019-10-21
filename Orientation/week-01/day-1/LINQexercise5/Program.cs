using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumsMethod = numbers.GroupBy(num => num);
            frequencyOfNumsMethod.ToList().ForEach(num => Console.WriteLine(num.Key + " " + num.Count()));

            /*foreach (var num in frequencyOfNums)
            {

                foreach (var item in num)
                {
                    Console.WriteLine(item);
                }
           
            }*/

            Console.WriteLine();

            var frequencyOfNums = from number in numbers
                                  group numbers.GroupBy(num => num)
                                  by number;

            frequencyOfNums.ToList().ForEach(num => Console.WriteLine(num.Key + " " + num.Count()));

            Console.ReadLine();
        }
    }
}
