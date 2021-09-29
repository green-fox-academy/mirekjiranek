using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        private int Intoxication;
        private bool Live;
        private string Name;

        private Random r = new Random();

        public Pirate(string name)
        {
            this.Intoxication = 0;
            this.Live = true;
            this.Name = name;

        }
        public string GetName()
        {
            return Name;
        }
        public bool getLive()
        {
            if (Live)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DrinkSomeRum(int numOfRums)
        {
            Intoxication += numOfRums;
        }
        public int RumInfo()
        {
            return Intoxication;
        }
        public void HowsItGoingMate()
        {
            if (!Live)
            {
                Console.WriteLine("he's dead");
            }
            else if (Intoxication < 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                Intoxication = 0;
            }
        }
        public void Brawl(Pirate pirate)
        {
            if (!Live)
            {
                Console.WriteLine("he's dead");
            }
            else
            {
                // 1 == this dies, 2 == other dies, 3 == both die
                int rInt = r.Next(1, 4);
                switch (rInt)
                {
                    case 1:
                        Die();
                        break;
                    case 2:
                        pirate.Die();
                        break;
                    case 3:
                        Die();
                        pirate.Die();
                        break;
                }

            }

        }

        public bool Die()
        {
            return Live = false;
        }
    }
}
