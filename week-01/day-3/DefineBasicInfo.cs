using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean
            String myName = "Filip";
            int myAge = 25;
            double myHeight = 1.76;
            bool myMarriageStatus = false;

            Console.WriteLine(myName);
            Console.WriteLine( myAge);
            Console.WriteLine(myHeight);
            Console.WriteLine(myMarriageStatus);

            Console.ReadLine();
        }
    }
}
