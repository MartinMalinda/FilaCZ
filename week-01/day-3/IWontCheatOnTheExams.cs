using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWontCheatOnTheExams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            int oath = 0;

            while (oath < 100)
            {
                Console.WriteLine("I won't cheat on the exam!");
                oath += 1;
            }
            Console.ReadLine();
        }
    }
}
