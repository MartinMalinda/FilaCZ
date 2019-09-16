using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Please give me a first number: ");
            int firstNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give me a second number: ");
            int secondNr = int.Parse(Console.ReadLine());
            bool firstNrBigger = firstNr > secondNr;
            if (firstNrBigger)
            {
                Console.WriteLine("The second number should be bigger than first.");
            }
            else
            {
                for (int i = ++firstNr; i < secondNr; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
