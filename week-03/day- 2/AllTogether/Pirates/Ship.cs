using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        Random randomValue = new Random();
        private List<Pirate> Crew;
        private string Name;

        public Ship(string name)
        {
            Crew = new List<Pirate>();
            this.Name = name;
        }
        //Getter
        private string GetName()
        {
            return Name;
        }
        public void FillShip()
        {
            //Fill the crew
            Crew.Add(new Pirate("Captain"));
            for (int i = 0; i < randomValue.Next(1, 114); i++)
            {
                Crew.Add(new Pirate($"Pirate{i}"));
            }
        }
        private Pirate GetCaptain()
        {
            foreach (Pirate i in Crew)
            {
                if (i.GetName() == "Captain")
                {
                    return i;
                }
            }
            return null;
        }
        public string CaptainInfo()
        {
            string isAlive = GetCaptain().getLive() ? "is alive" : "is dead";
            //get to Captain in list threw GetCaptain() method. Check if he's alive threw isAlive. Get the number of drinked rums and convert to string. 
            return $"{GetCaptain().GetName()} of boat {GetName()} {isAlive} and drinked {GetCaptain().RumInfo().ToString()} rums.}}";
        }
        public int CrewInfo()
        {
            int numOfAlive = 0;
            foreach (Pirate i in Crew)
            {
                if (i.getLive())
                {
                    numOfAlive++;
                }
            }
            return numOfAlive;
        }
        public bool Battle(Ship ship)
        {
            int ScoreThis = CrewInfo() - GetCaptain().RumInfo();
            int ScoreShip = ship.CrewInfo() - ship.GetCaptain().RumInfo();
            int numOfDeaths;
            if (ScoreThis > ScoreShip)
            {
                //antoher ship lost. Random number of pirates die
                for (int i = 0; i < (numOfDeaths = randomValue.Next(1, ship.Crew.Count)); i++)
                {
                    ship.Crew[i].Die();
                }
                //winning ship drink random number of rums(everybody)
                foreach (var i in this.Crew)
                {
                    i.DrinkSomeRum(randomValue.Next(1, 10));
                }
                Console.WriteLine($"ship named {GetName()} have won. There are {numOfDeaths} death on another ship named {ship.GetName()}");
                return true;
            }
            else
            {
                //this ship lost
                for (int i = 0; i < (numOfDeaths = randomValue.Next(1, this.Crew.Count)); i++)
                {
                    this.Crew[i].Die();
                }
                foreach (var i in ship.Crew)
                {
                    i.DrinkSomeRum(randomValue.Next(1, 10));
                }
                Console.WriteLine($"ship named {ship.GetName()} have won. There are {numOfDeaths} deaths on another ship named {GetName()}");
                return false;
            }
        }
    }
}
