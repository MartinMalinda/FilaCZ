using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listA = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" }; // creting listA
            List<string> listB = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" }; // creating listB

            Console.WriteLine(listA.Contains("Durian")); // checking if durian is in listA

            Console.WriteLine();

            listB.Remove("Durian"); // removing durian from ListB
            Console.WriteLine(listB.Count());

            Console.WriteLine();

            listA.Insert(4, "Kiwifruit"); // adding kiwi to position 4 (index 3) of listA 
            Console.WriteLine(listA.Count());

            Console.WriteLine();

            if (listA.Count() > listB.Count()) // comparing siye of lists
            {
                Console.WriteLine("ListA is bigger");
            }

            Console.WriteLine();

            listA.IndexOf("Avocado"); // getting index of avocado
            listB.IndexOf("Durian"); // getting index of durian

            string[] moreFruit = { "Passion fruit", "Pomelo" };
            listA.AddRange(moreFruit); // adding moreFruit to listA
            Console.WriteLine(listA.Count());

            Console.WriteLine();

            Console.WriteLine(listA.ElementAt(2));

        }
    }
}
