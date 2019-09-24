using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            
            DivideBy0();

            Console.ReadLine();

            

        }

        public static void DivideBy0()
        {
            Console.WriteLine("Give me a number and I will divide 10 with it.");

            int result = 0;
            

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int number = 10;
                result = number/ divisor;
                Console.WriteLine("Result is: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
        }
    }
}
