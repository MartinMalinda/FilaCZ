using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = File.ReadAllText("doubledChars.txt");

            

            List<char> characters = text.ToList<char>();
            string text1 = "";

            for (int i = 0; i < characters.Count; i += 2)
            {
                /*if (i % 2 == 1) //working!!!!
                {
                    text1 += characters[i];
                }*/

                text1 += characters[i];
            }
            Console.WriteLine(text1);

            Console.ReadLine();
        }
    }
}
