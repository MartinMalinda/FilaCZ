using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        public string Name { get; private set; }
        public int DrinksTaken { get; private set; }
        public bool IsNotDead { get; private set; }

        public bool IsCaptain { get; private set; }

        public Pirate(string name, bool isCaptain = false)
        {
            Name = name;
            DrinksTaken = 0;
            IsNotDead = true;
            IsCaptain = isCaptain;
        }

        public void DrinkSomeRum()
        {
            if (IsNotDead)
            {
                if (IsCaptain)
                {
                    DrinksTaken += 3;
                }
                else
                DrinksTaken++;
            }
            else
                Console.WriteLine("He's dead.");
        }

        public void HowsItGoingMate()
        {
            if (DrinksTaken <= 4 && IsNotDead)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else if (!IsNotDead)
            {
                Console.WriteLine("...dead...");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                DrinksTaken = 0;
            }
        }

        public void Brawl(Pirate pirateTwo)
        {
            Random random = new Random();
            int chance = random.Next(1, 4);

            if (!pirateTwo.IsNotDead)
            {
                Console.WriteLine("Can't fight dead pirate.");
                return;  
            }

            switch (chance)
            {
                case 1:
                    this.Die();
                    Console.WriteLine($"{Name} is dead.");
                    break;
                case 2:
                    pirateTwo.Die();
                    Console.WriteLine($"{pirateTwo.Name} is dead.");
                    break;
                case 3:
                    Console.WriteLine("Both pirates passed out.");
                    break;
            }

        }

        public bool Die()
        {
            return IsNotDead = false;
        }

    }
}
