using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStringedInstruments
{
    public abstract class StringedInstruments : Instruments
    {
        public int NumOfStrings { get; set; }

        public string Sound { get; set; }

        public StringedInstruments(string name, int numOfStrings, string sound) : base(name)
        {
            this.NumOfStrings = numOfStrings;
            this.Sound = sound;
        }
    }
}
