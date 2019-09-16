using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("I will draw a pyramid. How many lines do you want me to draw?");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < rows + 1; i++) //creates rows based on user input
            {

                
                
                for (int j = 0; j < (rows - i); j++)
                {
                    Console.Write(" ");
                    
                }
                
                for (int k = 0; k < (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                

            }


            Console.ReadLine();
        }
    }
}
