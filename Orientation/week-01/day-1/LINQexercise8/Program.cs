using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "NasHleDanoU";

            var upperCaseCharsMethod = word.Where(c => Char.IsUpper(c));
            upperCaseCharsMethod.ToList().ForEach(c => Console.WriteLine(c));

            Console.WriteLine();

            var upperCaseChars = from c in word
                                 where Char.IsUpper(c)
                                 select c;

            upperCaseChars.ToList().ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }
    }
}
