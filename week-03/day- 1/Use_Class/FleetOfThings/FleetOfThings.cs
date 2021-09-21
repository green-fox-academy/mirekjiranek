using System;

namespace FleetOfThings
{
   public class FleetOfThings
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main()` method
            // - Download those, use those
            // - In the Main() method create a fleet

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            fleet.Add(new Thing ("Get Milk"));
            fleet.Add(new Thing("Remove the obstacles"));

            Thing standUp = new Thing("Stand Up");
            standUp.Complete();
            fleet.Add(standUp);

            Thing eatLunch = new Thing("Eat Lunch");
            eatLunch.Complete();
            fleet.Add(eatLunch);

            fleet.Print();

        }
    }
}
