using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farm
    {
        private List<Animal> Animals;
        private int maxNumOfAnimals = 3;

        public Farm()
        {
            Animals = new List<Animal>();
        }

        public void Breed(Animal animal)
        {
            if (Animals.Count >= maxNumOfAnimals)
            {
                Console.WriteLine("Maximum number of animals");
            }
            else
            {
                Animals.Add(animal);
            }
        }
        public void Sell()
        {
            if (Animals.Count == 0)
            {
                Console.WriteLine("There are no animals to sell");
            }
            else
            {
                Animals.RemoveAt(Animals.Count-1);
            }
        }
    }
}
