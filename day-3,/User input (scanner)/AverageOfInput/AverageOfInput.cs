using System;

namespace AverageOfInput
{
    class AverageOfInput
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Give me number 1: ");
            string a = Console.ReadLine();
            int aInt = int.Parse(a);

            Console.Write("Give me number 2: ");
            string b = Console.ReadLine();
            int bInt = int.Parse(b);

            Console.Write("Give me number 3: ");
            string c = Console.ReadLine();
            int cInt = int.Parse(c);

            Console.Write("Give me number 4: ");
            string d = Console.ReadLine();
            int dInt = int.Parse(d);

            Console.Write("Give me number 5: ");
            string e = Console.ReadLine();
            int eInt = int.Parse(e);

            int sum = aInt + bInt + cInt + dInt + cInt;
            double av = sum / 5;

            Console.WriteLine($"Sum: {sum}, Average: {av}.");
        }
    }
}
