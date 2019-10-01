using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BunniesCount(4));
            Console.ReadLine();
        }

        public static int BunniesCount(int bunniesCount)
        {
            if (bunniesCount == 1)
            {
                return 2;
            }
            return 2 + BunniesCount(bunniesCount - 1);
        }
    }
}
