using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string fileName = "my-file.txt";
            string path = @"./my-file.txt";

            CountLines(fileName, path);

            Console.ReadLine();

        }
        public static void CountLines(string fileName, string filePath)
        {
            try
            {
                string[] fileNames = File.ReadAllLines(filePath);

                Console.WriteLine(fileNames.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }

            Console.ReadLine();
        }
    }
}
