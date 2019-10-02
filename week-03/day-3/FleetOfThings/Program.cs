using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {

            var fleet = new Fleet();

            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            fleet.GetThing()[2].Complete();
            fleet.GetThing()[3].Complete();



            for (int i = 0; i < fleet.GetThing().Count; i++)
            {
                string name = fleet.GetThing()[i].Name;
                string done = "[x]";
                string unDone = "[ ]";
                if (fleet.GetThing()[i].Completed)
                {
                    Console.WriteLine($"{i + 1}. {done} {name}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {unDone} {name}");
                }
                

            }
            
            Console.Read();

        }

    }
}