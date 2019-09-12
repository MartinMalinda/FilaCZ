using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens does farmer has? ");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs does farmer has? ");
            int pigs = int.Parse(Console.ReadLine());

            Console.WriteLine("Animals have " + ((chickens * 2) + (pigs * 4)) + " legs");
            Console.ReadLine();
        }
    }
}
