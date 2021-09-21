using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers_And_Students
{
    class Teacher
    {
        private string text = "the teacher is answering a question";

        public void GiveAnswer()
        {
            Console.WriteLine(text);
        }

        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
