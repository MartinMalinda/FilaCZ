using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");
            int firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the second number:");
            int secondNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the operation (1=add, 2=subtract, 3=multiply or 4=divide):");


            String operation = Console.ReadLine();
            double result = 0.0;

            switch (operation)
            {
                case "1":
                case "add":
                    result = firstNr + secondNr;
                    break;
           
                case "2":
                case "substract":
                    result = firstNr - secondNr;
                break;
          
                case "3":
                case "multiply":
                    result = firstNr * secondNr;
                break;
           
                case "4":
                case "divide":
                    result = firstNr / secondNr;
                break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                break;
            }
        
            

            Console.WriteLine($"The result of the calculation is {result}");


            Console.ReadLine();

        }
    }
}
