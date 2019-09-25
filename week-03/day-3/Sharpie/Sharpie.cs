using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; } = 100;


        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
        }
        public void Use()
        {
            InkAmount -= 10;
            Console.WriteLine($"You used sharpie. Amount of ink became{InkAmount}");
        }
    }
    
}
