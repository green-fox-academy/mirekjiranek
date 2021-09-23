using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritanceExcercise
{
    class Cohort
    {
        private string name;
        public List<Student> Students;
        public List<Mentor> Mentors;

        public Cohort(string name)
        {
            this.name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine($"The {name} has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
