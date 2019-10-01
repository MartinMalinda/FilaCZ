using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SumDigits(111));

            Console.ReadLine();
        }

        public static int SumDigits(int n)
        {

            if (n < 10)
            {
                return n;
            }
            return n % 10 + SumDigits(n / 10);
            

        }
    }
}
