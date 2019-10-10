using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public enum PlantType
    {
        Tree,
        Flower
    }
    class Plants : Garden
    {
        public string Color { get; private set; }

        public bool NeedWater { get; private set; }

        public PlantType TypePlant { get; private set;}

        public Plants(PlantType typePlant, string color, bool needWater = true)
        {
            this.Color = color;
            this.TypePlant = typePlant;
        }

        public override void Watering(int amountOfWater, List<Plants> plants)
        {
            foreach (var plant in plants)
            {
                if ()
                {

                }
            }
        }
    }

    
}
