using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>();
            foxes.Add(new Fox("Karel", FoxType.pallida, "green"));
            foxes.Add(new Fox("Josef", FoxType.arctic, "red"));
            foxes.Add(new Fox("Frantisek", FoxType.pallida, "green"));
            foxes.Add(new Fox("Alfred", FoxType.chama, "violet"));
            foxes.Add(new Fox("Boromir", FoxType.arctic, "green"));

            var greenFox = foxes.Where(f => f.Color == "green");

            greenFox.ToList().ForEach(f => Console.WriteLine(f.Name));

            var greenPallida = foxes.Where(f => f.Color == "green" && f.Type == FoxType.pallida);

            greenPallida.ToList().ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();
        }
    }
}
