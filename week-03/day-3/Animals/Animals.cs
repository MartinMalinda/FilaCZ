using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        public string Animal { get; set; }
        public int Hunger { get; set; } = 50;
        public int Thirst { get; set; } = 50;

        public Animals(string animal, int hunger,int thirst)
        {
            this.Animal = animal;
            this.Hunger = hunger;
            this.Thirst = thirst;
        }

        public void Eat()
        {
            Hunger--;
            Console.WriteLine($"{Animal} ate its food and level of hunger is {Hunger}");
        }
        public void Drink()
        {
            Thirst--;
            Console.WriteLine($"{Animal} drank its drink and level of thirst is {Thirst}");
        }
        public void Play()
        {
            Thirst++;
            Hunger++;
            Console.WriteLine($"{Animal} played a lot. Its level of thirst is {Thirst} and level of hunger is {Hunger}");
        }
    }
}
