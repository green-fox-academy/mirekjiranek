using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritanceExcercise
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name , int age, string gender, string level) :base(name,age,gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            this.level = "intermediate";
        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} {level} mentor");
        }
    }
}
