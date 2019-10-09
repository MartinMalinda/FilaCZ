using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> products = new Dictionary<string, double>();
            products.Add("Milk", 1.07);
            products.Add("Rice", 1.59);
            products.Add("Eggs", 3.14);
            products.Add("Cheese", 12.60);
            products.Add("Chicken Breasts", 9.40);
            products.Add("Apples", 2.31);
            products.Add("Tomato", 2.58);
            products.Add("Potato", 1.75);
            products.Add("Onion", 1.10);

            Dictionary<string, double> shoppingListBob = new Dictionary<string, double>();
            shoppingListBob.Add("Milk", 3);
            shoppingListBob.Add("Rice", 2);
            shoppingListBob.Add("Eggs", 2);
            shoppingListBob.Add("Cheese", 1);
            shoppingListBob.Add("Chicken Breasts", 4);
            shoppingListBob.Add("Apples", 1);
            shoppingListBob.Add("Tomato", 2);
            shoppingListBob.Add("Potato", 1);

            Dictionary<string, double> shoppingListAlice = new Dictionary<string, double>();
            shoppingListAlice.Add("Rice", 1);
            shoppingListAlice.Add("Eggs", 5);
            shoppingListAlice.Add("Chicken Breasts", 2);
            shoppingListAlice.Add("Apples", 1);
            shoppingListAlice.Add("Tomato", 10);



            double totalPriceBob = 0;

            foreach (KeyValuePair<string, double> product in products)
            {
                foreach (KeyValuePair<string, double> item in shoppingListBob)
                {
                    if (product.Key == item.Key)
                    {
                        double priceForAmount = product.Value * item.Value;
                        totalPriceBob += priceForAmount;
                    }
                }
            }
            Console.WriteLine($"Bob will pay {totalPriceBob}.");


            double totalPriceAlice = 0;

            foreach (KeyValuePair<string, double> product in products)
            {
                foreach (KeyValuePair<string, double> item in shoppingListAlice)
                {
                    if (product.Key == item.Key)
                    {
                        double priceForAmount = product.Value * item.Value;
                        totalPriceAlice += priceForAmount;
                    }
                }
            }
            Console.WriteLine($"Alice will pay {totalPriceAlice}.");


            double riceBob = shoppingListBob["Rice"];
            double riceAlice = shoppingListAlice["Rice"];
            if (riceBob > riceAlice)
            {
                Console.WriteLine($"Bob bought more rice ({riceBob})");
            }
            else
                Console.WriteLine($"Alice bought more rice ({riceAlice})");



            double potatoBob = 0;
            double potatoAlice = 0;

            if (shoppingListAlice.ContainsKey("Potato"))
            {
                potatoAlice = shoppingListAlice["Potato"];
            }

            if (shoppingListBob.ContainsKey("Potato"))
            {
                potatoBob = shoppingListBob["Potato"];
            }

            string result = potatoBob > potatoAlice ? ($"Bob bought more potatoes ({potatoBob})") : ($"Alice bought more potatoes ({potatoAlice})");
            Console.WriteLine(result);

            /*if (potatoBob > potatoAlice)
            {
                Console.WriteLine($"Bob bought more potatoes ({potatoBob})");
            }
            else
                Console.WriteLine($"Alice bought more potatoes ({potatoAlice})");*/

            Console.ReadLine();
        }
    }
}
