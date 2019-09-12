using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("How many girls will come to party? ");
            int girlsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("How many boys will come to party? ");
            int boysNumber = int.Parse(Console.ReadLine());

            bool boysAndGirlsMore20 = (girlsNumber + boysNumber) >= 20;
            bool boysAndGirlsEqual = girlsNumber == boysNumber;
            int people = (girlsNumber + boysNumber);

            if ((boysAndGirlsMore20) && boysAndGirlsEqual)
            {
                Console.WriteLine("The party is excellent!!");
            }
            else if ((boysAndGirlsMore20) && boysNumber != girlsNumber)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (people < 20 && girlsNumber >= 1)
            {
                Console.WriteLine("Averege party...");
            }
            else if (girlsNumber == 0)
            {
                Console.WriteLine("Sausage party!");
            }
            else
            {

            }
            Console.ReadLine();
        }
    }
}
