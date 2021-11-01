using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Model
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public List<string> AllTricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public Fox(string name)
        {
            Name = name;
            Tricks = new List<string>();
            Food = "Salad";
            Drink = "Water";
            AllTricks = new List<string>() { "BackFlip", "KickFlip", "Fight", "Love", "Hate" };

        }
    }
}
