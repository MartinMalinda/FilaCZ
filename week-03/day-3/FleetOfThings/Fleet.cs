using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public List<Thing> GetThing()
        {
            return things;
        }
    }
}