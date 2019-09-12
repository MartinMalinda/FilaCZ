using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.WriteLine("Write the distance in miles: ");
            int miles = int.Parse(Console.ReadLine());

            double milesToKm = miles * 1.6;

            Console.WriteLine("It is {0} km.", milesToKm);

            Console.ReadLine();
        }
    }
}
