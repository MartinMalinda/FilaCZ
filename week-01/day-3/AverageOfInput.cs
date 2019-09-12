using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine("Write a number: ");
            int firstNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number: ");
            int secondNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number: ");
            int thirdNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number: ");
            int fourthNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number: ");
            int fifthNr = int.Parse(Console.ReadLine());

            int sum = firstNr + secondNr + thirdNr + firstNr + firstNr;
            int average = sum / 5;

            Console.WriteLine("Sum: {0}, Average: {1}", sum, average);

            Console.Read();

        }
    }
}
