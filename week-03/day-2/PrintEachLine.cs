using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string fileName = "my-file.txt";
            string path = @"./my-file.txt";
            try
            {
                string[] contents = File.ReadAllLines(path);
                foreach (var content in contents)
                {
                    Console.WriteLine(content);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: " + fileName);
            }

            Console.ReadLine();

        }
    }
}
