using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceSet;

namespace GreenFoxAcademy
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet.DiceSet diceSet = new DiceSet.DiceSet();

            diceSet.Roll();
            bool completed = false;
            do //do while - looping(rolling dices) until all of them are 6
            {
                for (int i = 0; i < diceSet.GetCurrent().Length; i++) // for loop - rolling dices seperately
                {
                    if (diceSet.GetCurrent()[i] == 6)
                    {
                        continue;
                    }
                    diceSet.Reroll(i);
                }
                completed = true;
                for (int i = 0; i < diceSet.GetCurrent().Length; i++) // for loop - checks whether all of them are 6
                {
                    if (diceSet.GetCurrent()[i] != 6)
                    {
                        completed = false;
                    }
                }
            } while (!completed);
            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            {
                Console.WriteLine(diceSet.GetCurrent()[i]);
            }

            Console.ReadLine();
        }
    }
}