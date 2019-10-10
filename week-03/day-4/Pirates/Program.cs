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
            Pirate jack = new Pirate();

            jack.DrinkSomeRum();
            jack.DrinkSomeRum();
            jack.DrinkSomeRum();
            jack.DrinkSomeRum();
            jack.DrinkSomeRum();

            jack.HowsItGoingMate();

            jack.HowsItGoingMate();

            jack.Die();

            jack.DrinkSomeRum();

            jack.HowsItGoingMate();


            Console.ReadKey();
        }
    }
}
