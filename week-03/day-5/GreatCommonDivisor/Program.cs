using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CommonDivisor(48, 21));
            Console.ReadLine();
        }

        public static int CommonDivisor(int numOne, int numTwo)
        {
            if (numOne % numTwo == 0)
            {
                return numTwo;
            }

            return CommonDivisor(numTwo, numOne % numTwo);
        }
    }
}
