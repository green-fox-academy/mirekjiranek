using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers_And_Students
{
    class Student
    {
        private string text = "the student is actually learning";

        public void Learn()
        {
            Console.WriteLine(text);
        }

        public void Question(Teacher teacher)
        {
            teacher.GiveAnswer();
        }
    }
}
