using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStringedInstruments
{
    class ElectricGuitar : StringedInstruments
    {
        public ElectricGuitar(string name, int numOfStrings) : base(name, numOfStrings)
        {
            this.NumOfStrings = 6;

        }

        public override void Play()
        {
            Console.WriteLine($"{this.Name}, a {this.NumOfStrings}-stringed instrument");
            Sound();
        }

        public override void Sound()
        {
            Console.Write("twangs");
        }





    }
}

