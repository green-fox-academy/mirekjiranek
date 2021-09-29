using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    public abstract class Animal
    {
        protected int Age;
        protected string Name;
        protected string Gender;
        protected string hair;

        protected Animal(string name, string gender, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public abstract void Greet();
        public abstract void WantChild();
        public abstract void WhatIEat();
        public abstract int GrowUp();
    }
}
