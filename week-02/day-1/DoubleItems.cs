using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numList = { 3, 4, 5, 6, 7 };
            foreach (int number in numList)
            {
                Console.WriteLine(number * 2);
            }

            Console.ReadLine();
        }
    }
    
}
