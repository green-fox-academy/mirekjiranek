using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class StudentService
    {
        private readonly List<string> names;

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }
        public int Count()
        {
            return names.Count();
        }
        public bool Check(string check_name)
        {
            return names.Contains(check_name);
        }
    }
}
