using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStringedInstruments
{
    abstract class StringedInstruments : Instruments
    {
        public int NumOfStrings { get; set; }



        public StringedInstruments(string name, int numOfStrings) : base(name)
        {
            this.NumOfStrings = numOfStrings;

        }

        public abstract void Sound();
    }
}
