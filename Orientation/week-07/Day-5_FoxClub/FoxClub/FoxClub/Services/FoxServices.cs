using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Model;

namespace FoxClub.Services
{
    public class FoxServices
    {
        public List<Fox> Foxes;
        public FoxServices()
        {
            Foxes = new List<Fox>();
        }
        public void Save(string name)
        {
            if(!Foxes.Any(p => p.Name == name))
            {
                Foxes.Add(new Fox(name));
            }                     
        }
        public void UpdateFox(string name, string drink, string food)
        {
            Foxes.Where(f => f.Name == name).First().Drink = drink;
            Foxes.Where(f => f.Name == name).First().Food = food;
        }
        public void AddTrick(string name, string trick)
        {
            if(!FindFox(name).Tricks.Contains(trick))
            {
                FindFox(name).Tricks.Add(trick);
            }
        }
        public Fox FindFox(string name)
        {
            return Foxes.FirstOrDefault(f => f.Name == name);
        }
    }

}
