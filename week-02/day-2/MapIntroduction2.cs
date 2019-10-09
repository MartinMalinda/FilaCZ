using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapIntroduction2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("978-1-60309-452-8", "A Letter to Jo");
            map.Add("978-1-60309-459-7", "Lupus");
            map.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            map.Add("978-1-60309-461-0", "The Lab");


            map.Remove("978-1-60309-444-3");


            string key = "";

            foreach (var keyValuePair in map)
            {
                if (keyValuePair.Value == "The Lab")
                {
                    key = keyValuePair.Key;  
                }
            }
            map.Remove(key);

            map.Add("978-1-60309-450-4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            foreach (KeyValuePair<string, string> keyValuePair in map)
            {
                Console.WriteLine($"{keyValuePair.Value} (ISBN: {keyValuePair.Key})");
            }


            string value = "";

            foreach (var keyValuePair in map)
            {
                if (keyValuePair.Key == "478-0-61159-424-8")
                {
                    value = keyValuePair.Value;
                    Console.WriteLine(value);
                }         
            }
            Console.WriteLine(map.ContainsValue(value));


            foreach (var keyValuePair in map)
            {
                if (keyValuePair.Key == "978-1-60309-453-5")
                {
                    value = keyValuePair.Value;
                    Console.WriteLine(value);
                }
            }

            Console.ReadLine();

        }
    }
}
