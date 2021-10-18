using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Fox
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Color { get; private set; }

        public Fox(string name, string color, string type)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
}
