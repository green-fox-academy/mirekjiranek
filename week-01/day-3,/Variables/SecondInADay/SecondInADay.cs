using System;

namespace SecondInADay
{
    class SecondInADay
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above

            int secondsInDay = 24 * 3600; // 24hours * 3600 (= 60mins * 60sec)
            int remSecs = secondsInDay - (currentHours * 3600) - (currentMinutes * 60) - currentSeconds;
            Console.WriteLine($"There are {remSecs} remaining in the day.");

        }
    }
}
