using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStringedInstruments
{
    public abstract class Instruments
    {
        string Name { get; set; }

        public Instruments (string name)
        {
            this.Name = name;
        }

        public abstract void Play();

    }
}
