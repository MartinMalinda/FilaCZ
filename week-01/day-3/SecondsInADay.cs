using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingHours = 24 - currentHours;
            int remainingMinutes = 60 - currentMinutes;
            int remainingSeconds = 60 - currentSeconds;

            Console.WriteLine("Remaining seconds of the day: " + ((remainingHours * 60 * 60)
                + (remainingMinutes * 60) + remainingSeconds));
            Console.ReadLine();
        }
    }
}
