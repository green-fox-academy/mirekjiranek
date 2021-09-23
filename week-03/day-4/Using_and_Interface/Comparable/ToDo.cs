using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    class ToDo : IComparable<ToDo>
    {
        private bool Completed { get; set; }
        private string Field { get; set; }
        public ToDo(bool completed, string field)
        {
            this.Completed = completed;
            this.Field = field;

        }

        public string Print()
        {
            return $"[{Completed} , {Field}]";
        }
        public int CompareTo(ToDo other)
        {
            if (Completed == other.Completed )
            {
                if (Field.CompareTo(other.Field) == -1) 
                {
                    return 0; 
                }
                else if (Field.CompareTo(other.Field) == 1)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            } 
            else if (Completed == true &&  other.Completed == false)
            {
                return 0;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
