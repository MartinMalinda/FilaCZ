using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
            Console.ReadLine();
        }
    }
}
