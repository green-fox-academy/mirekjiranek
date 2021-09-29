using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples
{
    public class Apple
    {
        //List<int> IntList = new List<int>();

        public string GetApple()
        {
            return "apple";
        }
        public int Sum(int[] IntList)
        {
            int sum = 0;
            if (IntList == null)
            {
                return sum;
            }
            foreach (var i in IntList)
            {
                sum += i; 
            }
            return sum;
        }
    }
}
