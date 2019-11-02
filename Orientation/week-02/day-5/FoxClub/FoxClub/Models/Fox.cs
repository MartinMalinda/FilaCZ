using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; private set; }
        public string Food { get; private set; }
        public string Drink { get; private set; }
        public List<string> Tricks { get; private set; }


        public Fox(string name)
        {
            this.Name = name;
            Food = "burger";
            Drink = "coke";
            Tricks = new List<string>();
            Tricks.Add("Lift a Car");
        }

    }
}
