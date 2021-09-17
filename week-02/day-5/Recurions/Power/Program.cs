using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power, so powerN(3, 2) is 9(3 squared).
            do
            {
                Console.Write("Base number: ");
                int baseInt = int.Parse(Console.ReadLine());
                Console.Write("Power number: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(pwrN(baseInt,n));

            } while (true);

        }
        static int pwrN(int baseInt, int n)
        {
          if (baseInt == 1)
            {
                return 1;
            }
          else if (n == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * pwrN(baseInt, n - 1);
            }
        }
    }
}
