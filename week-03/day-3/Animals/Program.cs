using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals("Zebra", 50, 50);

            animal.Eat();
            animal.Drink();
            animal.Play();

            //Console.WriteLine(animal.Thirst);

            Console.ReadLine();
        }
    }
}
