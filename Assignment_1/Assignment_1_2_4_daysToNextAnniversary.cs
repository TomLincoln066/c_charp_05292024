/*
Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);
*/


// using System;

// namespace AgeCalculator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Define the birth date
//             DateTime birthDate = new DateTime(1995, 5, 29); // Change birthday here.

//             // Calculate the number of days old the person is
//             DateTime currentDate = DateTime.Now;
//             int daysOld = (currentDate - birthDate).Days;

//             // Output the number of days old
//             Console.WriteLine($"You are {daysOld} days old.");

//             // Calculate the days until the next 10,000-day anniversary
//             int daysToNextAnniversary = 10000 - (daysOld % 10000);
//             DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

//             // Output the date of the next 10,000-day anniversary
//             Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate.ToShortDateString()}.");
//         }
//     }
// }
