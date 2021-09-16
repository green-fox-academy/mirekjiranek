using System;

namespace Swap
{
    class Swap
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            Console.WriteLine($"a = {a} before, b = {b} before");
            int tempVar = a;
            a = b;
            b = tempVar;
            Console.WriteLine($"a = {a} now, b = {b} now");

        }
    }
}
