using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        private Random randomValue = new Random();
        private int numOfCrew;
        private List<Pirate> Pirates;

        public Ship()
        { 
        }
        public void FillShip()
        {
            numOfCrew = randomValue.Next(1, 114);
            for (int i = 0; i < numOfCrew; i++)
            {
                Pirates.Add(Pirat new pirate[i])
            }

        }
    }
}
