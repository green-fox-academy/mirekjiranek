using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    class Flower
    {
        private double currAmountWater;
        private bool iNeedWater;
        private string color;

        public Flower(string color)
        {
            this.currAmountWater = 0;
            this.iNeedWater = false;
            this.color = color;
        }

        public bool DoYouNeedWater()
        {
            if (currAmountWater < 5)
            {
                return iNeedWater = true;
            }
            else
            {
                return iNeedWater = false;
            }
        }
        public void Info()
        {
            if (iNeedWater)
            {
                Console.WriteLine($"The {color} flower needs water");
            }
            else
            {
                Console.WriteLine($"The {color} flower doesnt need water.");
            }
        }
        public double Watering(double amountOfWater)
        {
            if (currAmountWater < 5)
            {
                return currAmountWater + (amountOfWater * 0.75);
            }
            else
            {
                return currAmountWater;
            }
            
        }
    }
}
