using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(50);
            counter.Add(10);
            counter.Add();
            counter.Get();
            counter.Reset();

            Console.ReadLine();
        }
    }
}
