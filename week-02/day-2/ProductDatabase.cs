using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> productDatabase = new Dictionary<string, int>();
            productDatabase.Add("Eggs", 200);
            productDatabase.Add("Milk", 200);
            productDatabase.Add("Fish", 400);
            productDatabase.Add("Apples", 150);
            productDatabase.Add("Bread", 50);
            productDatabase.Add("Chicken", 550);

            foreach (KeyValuePair<string, int> item in productDatabase)
            {
                if (item.Key == "Fish")
                {
                    Console.WriteLine($"Fish costs {item.Value}");
                }
            }


            int highestPrice = 0;

            foreach (KeyValuePair<string, int> item in productDatabase)
            {
                if (item.Value > highestPrice)
                {
                    highestPrice = item.Value;
                }
            }
            Console.WriteLine($"Highest price is: {highestPrice}");


            int totalPrice = 0;

            foreach (KeyValuePair<string, int> item in productDatabase)
            {
                totalPrice += item.Value;
                
            }
            Console.WriteLine($"Average price is: {totalPrice / productDatabase.Count}");


            int cheaperThan300 = 0;

            foreach (KeyValuePair<string, int> item in productDatabase)
            {
                if (item.Value < 300)
                {
                    cheaperThan300 += 1;
                }

            }
            Console.WriteLine($"{cheaperThan300} things cost less than 300.");

        
            Console.WriteLine(productDatabase.ContainsValue(125));


            int lowestPrice = 0;

            foreach (var item in productDatabase)
            {
                if (lowestPrice == 0 || lowestPrice > item.Value)
                {
                    lowestPrice = item.Value;
                }
            }
            Console.WriteLine($"Lowest price is: {lowestPrice}");

            Console.ReadLine();
        }
    }
}
