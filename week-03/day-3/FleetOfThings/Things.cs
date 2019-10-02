using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class Thing
    {
/*        private string name;
        private bool completed;*/

        public string Name { get; private set; }
        public bool Completed { get; private set; }

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            Completed = true;
        }
    }
}