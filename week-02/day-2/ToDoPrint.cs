using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo


            StringBuilder todoTextUpdate = new StringBuilder("My todo:\n");
            todoTextUpdate.Append(todoText);
            todoTextUpdate.Append(" - Download games\n");
            todoTextUpdate.Append("\t- Diablo");

            Console.WriteLine(todoTextUpdate);
            Console.ReadLine();
        }
    }
}
