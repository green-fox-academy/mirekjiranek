using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount = 20;

        public Sharpie()
        {
            this.color = "blue";
            this.width = 25;
        }

        public void Use()
        {
            inkAmount -= 10;
        }
    }
}
