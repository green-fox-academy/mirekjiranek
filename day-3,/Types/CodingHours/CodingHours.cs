using System;

namespace CodingHours
{
    class CodingHours
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            int HoursInDay = 6;
            int NumOfWeeks = 17;
            int WorkHours = 52;
            //Hours in day multiplied by 5 days in a week multiplied by number of weeks
            Console.WriteLine((HoursInDay * 5) * (NumOfWeeks));
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("Percentage of coding hours: "+(((float)HoursInDay *5 / WorkHours) * 100) +"%");

        }
    }
}
