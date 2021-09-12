using System;

namespace ConditionalVariableMutation
{
    class ConditionalVariableMutation
    {
        static void Main(string[] args)
        {
            double a = 24;
            int output1 = 0;
            // if a is even increment output1 by one
            if (a % 2 == 0)
            {
                Console.WriteLine(output1++);
            }

            int b = 13;
            string output2 = "";
            // if b is between 10 and 20 set output2 to "Sweet!"
            // if less than 10 set output2 to "Less!",
            // if more than 20 set output2 to "More!"
            if ((b >= 10) && (b <= 20))
            {
                Console.WriteLine(output2 = "Sweet!");
            }
            else if (b < 10)
            {
                Console.WriteLine("Less!");
            }
            else if (b > 20)
            {
                Console.WriteLine("More!");
            }

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            if ((credits >= 50) && (isBonus == false))
            {
                c = c - 2;
                Console.WriteLine(c);
            }
            else if ((credits < 50) && (isBonus == false))
            {
                c--;
                Console.WriteLine(c);
            }
            else if (isBonus) 
            {
                Console.WriteLine(c);
            }

            int d = 8;
            int time = 120;
            string output3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set output3 to "check"
            // if time is more than 200
            // set output3 to "Time output"
            // otherwise set output3 to "Run Forest Run!"
            if ((d % 4 == 0) && (time < 200)) 
            {
                Console.WriteLine(output3 = "check");
            }
            else if (time > 200)
            {
                Console.WriteLine(output3 = "Time output");
            }
            else
            {
                Console.WriteLine("Run Forest Run!");
            }
        }
    }
}
