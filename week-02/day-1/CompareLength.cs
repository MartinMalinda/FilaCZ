using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print "p2 is longer" if `p2` has more elements than `p1`
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            bool compareLength = p1.Length < p2.Length;

            if (compareLength)
            {
                Console.WriteLine("p2 is longer") ;
            }


            Console.ReadLine();
        }
    }
}
