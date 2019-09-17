using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); // empty list
            Console.WriteLine(names.Count); // printing number of elements
            names.Add("William"); // adding William

            bool emptyOrNot = names.Count > 0;

            if (emptyOrNot) // empty or not 
            {
                Console.WriteLine("This list is not empty!");
            }
            else
            {
                Console.WriteLine("This list is empty!");
            }

            names.Add("John"); // adding John
            names.Add("Amanda"); // adding Amanda

            Console.WriteLine(names.Count); // printing number of elements
            Console.WriteLine(names[2]); // printing 3rd element

            foreach (var name in names) // printing all elements
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            for (int i = 0; i < names.Count; i++) // printing all elements with position in list
            {
                Console.Write(i + 1 + ". " + names[i]);
                Console.Write("\n");

            }

            Console.WriteLine();

            names.RemoveAt(1); // cannot be in cw!!! to control create method
            //Console.WriteLine(names.RemoveAt());

            names.Reverse();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            names.RemoveRange(0, names.Count); // delete
            Console.WriteLine(names.Count);
        }
    }
}
