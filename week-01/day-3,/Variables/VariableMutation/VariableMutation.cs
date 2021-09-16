using System;

namespace VariableMutation
{
    class VariableMutation
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10
            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b-7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c*2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d/5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(Math.Pow(e, 3));

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool isBigger1 = f1 > f2;
            Console.WriteLine($"Is f1 = {f1} bigger than f2 = {f2}? It's {isBigger1}.");

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool isBigger2 = (g2 * 2) > g1;
            Console.WriteLine($"Is double of g2 = {g2} bigger than g1 = {g1}? It's {isBigger2}.");

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            long remainder = h % 11;
            bool isAdivisor = remainder == 0;
            Console.WriteLine($"Is number 11 a divisor of number h = {h}? It's {isAdivisor}!");


            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            bool isHigher = i1 > Math.Pow(i2, 2) && i1 < Math.Pow(i2, 3);
            Console.WriteLine($"Is number i1 = {i1} higher than i2 = {i2} squared and also smaller than i2 = {i2} cubed? It's {isHigher}!");

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
            int jdiv3 = j % 3;
            int jdiv5 = j % 5;
            bool isDivisible = jdiv3 == 0 || jdiv5 == 0;
            Console.WriteLine($"Is number j = {j} divisible by 3 or 5? Its {isDivisible}!");
        }
    }
}
