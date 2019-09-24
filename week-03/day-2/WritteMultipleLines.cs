using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            string path = @"./file.txt";
            int repetitions = 5;

            WriteName("apple", path, repetitions);

            Console.ReadLine();


        }
        public static void WriteName(string name, string path, int repetitions)
        {

            try
            {

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(name);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            for (int i = 0; i < repetitions; i++)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
