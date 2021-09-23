using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritanceExcercise
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor()
        {
            this.company = "Google";
            this.hiredStudents = 0;
        }
        public Sponsor(string name, int age, string gender, string company) :base(name, age, gender)
        {
            this.hiredStudents = 0;
            this.company = company;
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }
        public void Hire()
        {
            hiredStudents += 1;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
