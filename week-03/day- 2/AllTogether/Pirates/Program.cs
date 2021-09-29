using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirate pirate1 = new("pirate1");
            //Pirate pirate2 = new("pirate2");
            //pirate1.HowsItGoingMate();
            //pirate1.DrinkSomeRum();
            //pirate1.DrinkSomeRum();
            //pirate1.DrinkSomeRum();
            //pirate1.DrinkSomeRum();
            //pirate1.HowsItGoingMate();
            //pirate2.HowsItGoingMate();
            //pirate1.Brawl(pirate2);
            Ship ship1 = new("ship1");
            Ship ship2 = new("ship2");
            ship1.FillShip();
            ship2.FillShip();
            Console.WriteLine(ship1.CaptainInfo());
            Console.WriteLine("number of pirates: " + ship1.CrewInfo());
            Console.WriteLine(ship2.CaptainInfo());
            Console.WriteLine("number of pirates: " + ship2.CrewInfo());
            ship1.Battle(ship2);
            Console.WriteLine(ship1.CaptainInfo());
            Console.WriteLine("number of pirates: " + ship1.CrewInfo());
            Console.WriteLine(ship2.CaptainInfo());
            Console.WriteLine("number of pirates: " + ship2.CrewInfo());
        }
}
}
