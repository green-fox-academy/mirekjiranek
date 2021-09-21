using System;

namespace Teachers_And_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            Student student1 = new();
            Teacher teacher = new();
            //student.Learn();
            //teacher.GiveAnswer();

            //student.Question(teacher);
            teacher.Teach(student1);
            
        }
    }
}
