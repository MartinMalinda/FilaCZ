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
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            string path = @"./file.txt";

            WriteName("Filip", path);

            Console.ReadLine();


        }
        public static void WriteName(string name, string path)
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
                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine(reader.ReadLine());
                }
        }
    }
}
