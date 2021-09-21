using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
         int hunger = 50;
         int thirst = 50;

        public Animal()
        {

        }

        public void Eat()
        {
            hunger--;
            Console.WriteLine($"hunger = {hunger}");
        }

        public void drink()
        {
            thirst--;
            Console.WriteLine($"hunger = {thirst}");

        }

        public void play()
        {
            hunger++;
            thirst++;
            Console.WriteLine($"hunger = {hunger}\nthirst = {thirst}");

        }
    }

}
