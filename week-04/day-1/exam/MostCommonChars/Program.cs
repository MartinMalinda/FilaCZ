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

            string path = @"./countchar.txt";

            string text = File.ReadAllText(path);


            Dictionary<char, int> charsAmount = new Dictionary<char, int>();
            int counter = 0;
            foreach (char character in text)
            {
                if (!charsAmount.ContainsKey(character))
                {
                    charsAmount.Add(character, 1);
                }
                else
                    charsAmount[character]++;
            }

            var values = charsAmount.Values.ToList();

            values.Sort();
            values.Reverse();
     

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in charsAmount)
                {
                    if (item.Value == values[i])
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
