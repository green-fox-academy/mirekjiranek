using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        private int gasAmount;

        public Station()
        {
            this.gasAmount = 1000;
        }

        public void Refill(Car car)
        {
            gasAmount = gasAmount - car.GetCapacity();
            car.Refill();
        }
    }
}
