using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NumAdder(10));

            Console.ReadLine();
        }
        public static int NumAdder(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + NumAdder(n - 1);


        }
    }
}
