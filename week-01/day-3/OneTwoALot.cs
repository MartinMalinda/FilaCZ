using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("Write a number equals to 1 or 2: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Two");
            }
            else if (number < 1)
            {
                Console.WriteLine("Not enough");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}
