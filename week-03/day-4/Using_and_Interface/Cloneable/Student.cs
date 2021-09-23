﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Student : Person,ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public Student()
        {
            this.previousOrganization = "School of Life";
        }

        public Student(string name, int age, string gender, string previousOrganization) :base(name,age,gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }



        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skiped {skippedDays} days from the course already");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public Object Clone()
        {
            Student newstudent = new Student();
            newstudent.age = age;
            newstudent.name = name;
            newstudent.gender = gender;
            newstudent.previousOrganization = previousOrganization;
            return newstudent;
        }
    }
}
