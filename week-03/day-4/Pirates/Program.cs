using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirateJack = new Pirate("Jack", true);

            Pirate pirateBlackBeard = new Pirate("Black Beard");

            /*pirateJack.DrinkSomeRum();
            pirateJack.DrinkSomeRum();
            pirateJack.DrinkSomeRum();
            pirateJack.DrinkSomeRum();
            pirateJack.DrinkSomeRum();

            pirateJack.HowsItGoingMate();
            pirateJack.HowsItGoingMate();
            pirateJack.Die();
            pirateJack.DrinkSomeRum();
            pirateJack.HowsItGoingMate();*/

            pirateJack.Brawl(pirateBlackBeard);

            /*Pirate.Brawl(pirateJack, pirateBlackBeard);*/

            Ship blackPearl = new Ship("Black Pearl");

            blackPearl.FillShip();

            foreach (var pirate in blackPearl.Pirates)
            {
                Console.WriteLine(pirate.Name);
            }

            foreach (var pirate in blackPearl.Pirates)
            {
                pirate.DrinkSomeRum();
                pirate.HowsItGoingMate();
            }

            Console.WriteLine(blackPearl.ToString());


            Console.ReadKey();
        }
    }
}
