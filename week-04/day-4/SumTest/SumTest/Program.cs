using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine(Sum(numbers));

            Console.ReadKey();
        }

        public static int Sum(List<int> numbers)
        {
            int sumNum = 0;
            /*for (int i = 0; i < numbers.Count(); i++)
            {
                sumNum = sumNum + numbers[i];
            }*/
            foreach (var num in numbers) // working with null exception!!!
            {
                sumNum += num;
            }
            return sumNum;
        }
    }
}
