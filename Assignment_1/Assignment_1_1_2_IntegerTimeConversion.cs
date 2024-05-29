// /*Here's a C# console application that converts an integer number of 
// centuries into years, days, hours, minutes, seconds, milliseconds, microseconds, and nanoseconds.
// */

// using System;

// namespace TimeConversion
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Enter number of centuries: ");
//             if (int.TryParse(Console.ReadLine(), out int centuries))
//             {
//                 // Constants
//                 int yearsInACentury = 100;
//                 int daysInAYear = 36524 / 100; 
//                 int hoursInADay = 24;
//                 int minutesInAnHour = 60;
//                 int secondsInAMinute = 60;
//                 int millisecondsInASecond = 1000;
//                 int microsecondsInAMillisecond = 1000;
//                 int nanosecondsInAMicrosecond = 1000;

//                 // Calculations
//                 long years = centuries * yearsInACentury;
//                 long days = years * daysInAYear;
//                 long hours = days * hoursInADay;
//                 long minutes = hours * minutesInAnHour;
//                 long seconds = minutes * secondsInAMinute;
//                 long milliseconds = seconds * millisecondsInASecond;
//                 long microseconds = milliseconds * microsecondsInAMillisecond;
//                 decimal nanoseconds = (decimal)microseconds * nanosecondsInAMicrosecond;

//                 // Output
//                 Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
//                 Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid integer number of centuries.");
//             }
//         }
//     }
// }
