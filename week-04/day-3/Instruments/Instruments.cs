using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class Instruments
    {
        public string Name { get; set; }

        public Instruments(string name)
        {
            this.Name = name;
        }

        public abstract void Play();

    }
}
