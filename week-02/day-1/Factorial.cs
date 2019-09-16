using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int Factorio(int x)
        {
            int factorialNumber = 1;
            for (int i = 1; i <= x; i++)
            {
                factorialNumber = factorialNumber * i;
            }
            return factorialNumber;
        }
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            int factorialNumber = 6;

            Console.WriteLine(Factorio(factorialNumber));

            Console.ReadLine();
        }
    }
}
