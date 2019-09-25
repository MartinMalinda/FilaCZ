using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie newSharpie = new Sharpie("Red", 5);

            newSharpie.Use();
            newSharpie.Use();

            Console.ReadLine();
        }
    }
}
