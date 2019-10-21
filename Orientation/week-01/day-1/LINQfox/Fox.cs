using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQfox
{
    public enum FoxType
    {
        pallida,
        chama,
        arctic

    }
    public class Fox
    {
        public string Name { get; private set; }
        public FoxType Type { get; private set; }

        public string Color { get; private set; }

        public Fox(string name, FoxType type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
           

    }
}
