using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonChars
{
    class Program
    {
        static void Main(string[] args)
        {

            //string fileName = "countchar.txt";
            string path = @"./countchar.txt";

            //string path = $"./{fileName}";
            string countcharFile = File.ReadAllText(path.Trim());
            char[] charsInFile = countcharFile.ToCharArray();


            for (int i = 0; i < countcharFile.ToCharArray().Length; i++)
            {

                Console.Write(charsInFile[i]);
            }

            foreach (char charInString in countcharFile)
            {

            }


            var count = countcharFile.Count(x => x == 'e'); // copy paste for inspiration reasons .. 
            Console.WriteLine(count);


            Console.ReadLine();


        //}

        /*public static int CountChars(string fileName)
        {
            string path = $"./{fileName}";
            string countcharFile = File.ReadAllText(path);
            char[] charsInFile = countcharFile.ToCharArray();

            int count = 0;

            for (int i = 0; i < countcharFile.ToCharArray().Length; i++)
            {

                for (int k = 0; k < countcharFile.ToCharArray().Length; k++)
                {
                    if (countcharFile.ToCharArray()[i] == countcharFile.ToCharArray()[k])
                    {
                        count++;
                    }
                    Console.WriteLine($"{countcharFile.ToCharArray()[i]} : {count}");
                }

                
            }*/


        }
    }
}
