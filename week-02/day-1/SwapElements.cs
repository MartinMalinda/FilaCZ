using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };

            string a = abc[0];
            abc[0] = abc[2];
            abc[2] = a;

            Console.ReadLine();
        }
    }
}
