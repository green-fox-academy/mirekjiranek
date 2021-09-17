using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(AddNumber(5));

        }
        static int AddNumber(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + AddNumber(n - 1);
            }
        }
    }
}
