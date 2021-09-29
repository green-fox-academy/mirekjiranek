using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class Anagram
    {

        public bool IsAnagram(string input1, string input2)
        {
            char[] charInput1 = input1.ToArray();
            Array.Sort(charInput1);
            string SortedInput1 = new string(charInput1);
            char[] charInput2 = input2.ToArray();
            Array.Sort(charInput2);
            string SortedInput2 = new string(charInput2);

            if (input1.Length == input2.Length && SortedInput1 == SortedInput2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
