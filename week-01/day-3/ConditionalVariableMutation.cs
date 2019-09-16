using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hiii");
            int a = 24;
            int out1 = 0;
            // if a is even increment out by one
            bool evenToOdd = (a % 2) == 0;
            
            if (evenToOdd)
            {
                out1 += 1;
            }

            Console.WriteLine(out1);

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            if (b > 10 && b < 20)
            {
                out2 = "Sweet!";
            }
            else if (b < 10)
            {
                out2 = "Less!";
            }
            else if (b > 20)
            {
                out2 = "More!";
            }
            else
            {
                out2 = "Equal!";
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            if (credits >= 50 && isBonus)
            {
                c = c - 2;
            }
            else if (credits < 50 && isBonus)
            {
                c = c - 1;
            }
            else if (!isBonus)
            {
                c = c;
            }
           

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            bool dividebleBy4 = (8 % 4) == 0;
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            if (dividebleBy4 && time < 200)
            {
                out3 = "Check";
            }
            else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);

            Console.ReadLine();
        }
    }
}
