using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public string Print()
        {
            return $"[{Values[0]},{Values[1]}],";
        }

        public int CompareTo(Domino domino2)
        {
            if (Values[0] > domino2.Values[0])
            {
                return 0;
            }
            else if (Values[0] < domino2.Values[0])
            {
                return -1;
            }
            else
            {
                if (Values[1] > domino2.Values[1])
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
}
