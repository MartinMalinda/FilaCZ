using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string path = @"./newFile";
            string pathCopy = @"./newFileCopy";

            CreateandCopyFile(path, pathCopy);

            Console.ReadLine();

        }
        public static bool CreateandCopyFile(string pathOriginalFile, string pathCoppiedFile)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pathOriginalFile))
                {
                    writer.WriteLine("Hello!");
                    writer.WriteLine("How are you?");
                }
                string[] arrayOfLines = File.ReadAllLines(pathOriginalFile);
                File.WriteAllLines(pathCoppiedFile, arrayOfLines);
                return true;
            }
            catch
            {
                Console.WriteLine("Something went wrong mate..");
                return false;
            }
        }
    }
}
