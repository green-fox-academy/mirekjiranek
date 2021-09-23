using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", 20,"male","BME");

            Student JohnTheClone = (Student)student1.Clone();
            
        }
    }
}
