using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(4, 3));
            Console.ReadLine();
        }
        public static int Power(int baseNum, int powerBy)
        {
            if (powerBy <= 1)
            {
                return baseNum;
            }
            return baseNum * Power(baseNum, powerBy - 1);
        }
    }
}
