using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            int i = 1;
            foreach (var task in Things)
            {
                Console.WriteLine($"{i}. {task.Print()}");
                i++;
                
            }
        }
    }
}
