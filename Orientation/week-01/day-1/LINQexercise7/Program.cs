using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startsAEndsIMethod = cities.Where(c => c.StartsWith("A") && c.EndsWith("I"));
            startsAEndsIMethod.ToList().ForEach(c => Console.WriteLine(c));

            Console.WriteLine();

            var startsAEndsI = from c in cities
                               where c.StartsWith("A") && c.EndsWith("I")
                               select c;

            startsAEndsI.ToList().ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }
    }
}
