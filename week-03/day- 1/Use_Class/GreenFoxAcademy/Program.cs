using System;

namespace GreenFoxAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            int counter = 0;
            int sum;
            do
            {
                sum = 0;
                diceSet.Roll();
                counter++;
                for (int i = 0; i < diceSet.GetCurrent().Length; i++)
                {
                    sum = sum + diceSet.GetCurrent(i);
                }
            }
            while (sum != diceSet.GetCurrent().Length * 6);

            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            {
                Console.Write(diceSet.GetCurrent(i) + " ");
            }
            Console.WriteLine($"Provedeno {counter} pokusů.");

        }
    }
}
