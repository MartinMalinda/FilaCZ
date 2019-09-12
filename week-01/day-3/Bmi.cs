using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = massInKg / (heightInM * heightInM);

            Console.WriteLine(bmi);
            Console.ReadLine();
        }
    }
}
