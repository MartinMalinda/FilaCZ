using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {

        public int DrinksTaken { get; private set; } = 0;
        public bool isNotDead { get; private set; } = true;

        public Pirate()
        {
            DrinksTaken = DrinksTaken;
        }

        public void DrinkSomeRum()
        {
            if (isNotDead)
            {
                DrinksTaken++;
            }
            else
                Console.WriteLine("He's dead.");
        }

        public void HowsItGoingMate()
        {
            if (DrinksTaken <= 4 && isNotDead)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else if (!isNotDead)
            {
                Console.WriteLine("...dead...");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                DrinksTaken = 0;
            }
        }

        public void Brawl(Pirate pirateOne, Pirate pirateTwo)
        {
            Random random = new Random();
            int chance = random.Next(1, 4);

            if (!pirateTwo.isNotDead)
            {
                Console.WriteLine("Can't fight dead pirate.");
                return;  
            }



        }

        public bool Die()
        {
            return isNotDead = false;
        }

    }
}
