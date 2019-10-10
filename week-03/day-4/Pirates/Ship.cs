using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        public string Name { get; private set; }

        public List<Pirate> Pirates { get; private set; }

        public Ship(string name)
        {
            Name = name;
            Pirates = new List<Pirate>();
        }


        public void FillShip()
        {
            Random random = new Random();
            int numOfPirates = random.Next(2, 7);

            for (int i = 1; i <= numOfPirates; i++)
            {
                if (i == 1)
                {
                    Pirates.Add(new Pirate("captain", true));
                }
                else
                    Pirates.Add(new Pirate($"pirate{i - 1}"));
            }

        }

        public void Battle(Ship name)
        {

        }

        public override string ToString()
        {
            int counter = 0;

            for (int i = 1; i < Pirates.Count; i++)
            {
                if (Pirates[i].IsNotDead)
                {
                    counter++;
                }
            }

            string presention = $"This ship's cpt {Pirates[0].Name} drunk {Pirates[0].DrinksTaken} rums. Is he alive?  - {Pirates[0].IsNotDead}\n" +
                                $"Ship has {counter} alive crew members. " 
                ; //TODO

            return presention;
        }

    }
}
