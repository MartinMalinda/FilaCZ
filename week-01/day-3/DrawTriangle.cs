using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("I will draw a triangle. How many lines do you want me to draw?");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            char star = '*';

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write(star);
                    
                }
                Console.Write("\n");
               


            }
            Console.ReadLine();
        }
    }
}
