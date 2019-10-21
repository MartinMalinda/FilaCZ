using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'h', 'o', 'j' };
            var word = String.Join("", chars.Select(c => c));
            Console.WriteLine(word);


            Console.ReadLine();
        }
    }
}
