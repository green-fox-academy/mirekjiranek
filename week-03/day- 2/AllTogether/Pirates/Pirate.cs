using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        private int intoxication;
        private bool live;

        public Pirate()
        {
            this.intoxication = 0;
            this.live = true;

        }

        public void DrinkSomeRum()
        {
            intoxication++;
        }
        public void HowsItGoingMate()
        {
            if (!live)
            {
                Console.WriteLine("he's dead");
            } 
            else if (intoxication > 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                intoxication = 0;
            }
        }
        public void Brawl(Pirate pirate)
        {
            if (!live)
            {
                Console.WriteLine("he's dead");
            }
            else if ()//udělat 33% šanci že umře pirat1/pirat2/oba dva 

        }
        public bool Die()
        {
            return live = false;
        }
    }
}
