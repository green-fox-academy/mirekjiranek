using System;

namespace Cuboid
{
    class Cuboid
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            Console.Write("Strana a:");
            string a = Console.ReadLine();
            int aa = Int32.Parse(a);
            Console.Write("Strana b:");
            string b = Console.ReadLine();
            int bb = Int32.Parse(b);
            Console.Write("Strana c:");
            string c = Console.ReadLine();
            int cc = Int32.Parse(c);

            int surface = 2 * (aa * bb + aa * cc + bb * cc);
            int volume = aa * bb * cc;

            Console.WriteLine($"Surface area of the cuboid is {surface}. Volume of the cuboid is {volume}.");

        }
    }
}
