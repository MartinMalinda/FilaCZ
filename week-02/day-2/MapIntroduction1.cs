using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapIntroduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<int, char>();

            Console.WriteLine(map.Count()); // check number of elements

            map.Add(97, 'a'); // adding keys and values
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            Console.WriteLine();

            foreach (var item in map) // printing all keys and values
            {
                int key = item.Key;
                char value = item.Value;
                Console.WriteLine(key + " / " + value);

            }
            Console.WriteLine();

            map.Add(68, 'D'); // adding 7th element to map

            Console.WriteLine(map.Count()); // printing number of keyValue pairs

            Console.WriteLine();

            char mapValue; // getting the value of key 99
            if (map.TryGetValue(99, out mapValue))
            {
                Console.WriteLine(mapValue);
            }

            Console.WriteLine();

            map.Remove(97); // removing the key-value pair where with key 97

            Console.WriteLine(map.Count());

            Console.WriteLine();

            Console.WriteLine(map.ContainsKey(100)); // showing if map contains a value associated to key 100

            Console.WriteLine();

            map.Clear(); // removing all elements from dictionary

            Console.WriteLine(map.Count());

        }
    }
}
