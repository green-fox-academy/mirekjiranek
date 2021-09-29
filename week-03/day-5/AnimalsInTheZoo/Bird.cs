using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    public abstract class Bird : Animal
    {
        public Bird(string name, string gender, int age) :base(name, gender, age)
        {
            this.Name = name;
            this.Gender = gender;
            this.hair = "feather";
            this.Age = age;
        }
        public override void Greet()
        {
            
        }

        public override int GrowUp()
        {
            return ++Age;
        }

        public override void WantChild()
        {
            Console.WriteLine("want child from an egg.");
            
        }

        public override void WhatIEat()
        {
            Console.WriteLine("is feeded by insect");
        }
    }
}
