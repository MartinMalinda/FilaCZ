using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int Number { get; set; } = 0;

        public Counter(int number)
        {
            this.Number = number;
        }

        public void Add(int numberToAdd)
        {
            Number = Number + numberToAdd;
            Console.WriteLine(Number);
        }

        public void Add()
        {
            Number++;
            Console.WriteLine(Number);
        }
        public void Get()
        {
            Console.WriteLine(Number);
        }
        public void Reset()
        {
            Number = default;
            Console.WriteLine(Number);
        }
    }
}
