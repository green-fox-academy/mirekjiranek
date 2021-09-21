using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class SharpieSet
    {
        private List<Sharpie> Sharpies;

        public SharpieSet()
        {
            Sharpies = new List<Sharpie>();
        }

        public void Add(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }

        public int CountUsable()
        {
            int numOfUsable = 0;
            foreach (var sharpie in Sharpies)
            {
                if (sharpie.inkAmount > 0)
                {
                    numOfUsable++;
                }
            }
            return numOfUsable;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < Sharpies.Count(); i++)
            {
                if (Sharpies[i].inkAmount == 0)
                {
                    Sharpies.RemoveAt(i);
                }
            }
        }
    }
}
