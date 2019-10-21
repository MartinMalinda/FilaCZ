using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatever = "bla bla bla bla fox fox";
            /*char[] separator = { ' ' };
            var whatever2 = whatever.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            whatever2.ToList();*/

            var frequencyOfCharsMethod = whatever.Where(ch => ch != ' ').GroupBy(chars => chars);
            frequencyOfCharsMethod.ToList().ForEach(chars => Console.WriteLine(chars.Key + " " + chars.Count()));

            Console.WriteLine();

            var frequencyOfChars = from ch in whatever
                                   where ch != ' '
                                   group ch
                                   by ch;

            frequencyOfChars.ToList().ForEach(ch => Console.WriteLine(ch.Key + " " + ch.Count()));

            Console.ReadLine();
        }
    }
}
