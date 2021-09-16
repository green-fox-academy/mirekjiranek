using System;

namespace PartyIndicator
{
    class PartyIndicator
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            Console.Write("Number of firls: ");
            string girls = Console.ReadLine();
            int girlsInt = int.Parse(girls);

            Console.Write("Number of boys: ");
            string boys = Console.ReadLine();
            int boysInt = int.Parse(boys);

            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
            // it should print: Quite a cool party!
            // If there are less people coming than 20
            // it should print: Average party...
            // If no girls are coming, regardless the count of the people
            // it should print: Sausage party

            if ((girlsInt + boysInt >= 20) && (girlsInt == boysInt))
            {
                Console.WriteLine("The party is excellent!");
            }
            else if ((girlsInt + boysInt >= 20) && (girlsInt != boysInt) && (girlsInt > 0))
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if ((girlsInt + boysInt < 20) && (girlsInt > 0))
            {
                Console.WriteLine("Average party...");
            }
            else
            {
                Console.WriteLine("Sausage party");
            }






        }
    }
}

