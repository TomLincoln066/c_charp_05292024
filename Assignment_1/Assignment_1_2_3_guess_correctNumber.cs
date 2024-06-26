/*
Your program can create a random number between 1 and 3 with the following code:
------
int correctNumber = new Random().Next(3) + 1;
------
Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:

-----
int guessedNumber = int.Parse(Console.ReadLine());
-----

Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses.
*/

// using System;

// namespace GuessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Generate a random number between 1 and 3
//             int correctNumber = new Random().Next(3) + 1;

//             // Ask the user to guess the number
//             Console.WriteLine("Guess a number between 1 and 3:");

//             // Read the user's guess
//             int guessedNumber = int.Parse(Console.ReadLine());

//             // Check if the guess is within the valid range
//             if (guessedNumber < 1 || guessedNumber > 3)
//             {
//                 Console.WriteLine("Your guess is outside the valid range. Please guess a number between 1 and 3.");
//             }
//             else
//             {
//                 // Provide feedback on the user's guess
//                 if (guessedNumber < correctNumber)
//                 {
//                     Console.WriteLine("Your guess is too low.");
//                 }
//                 else if (guessedNumber > correctNumber)
//                 {
//                     Console.WriteLine("Your guess is too high.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Congratulations! You guessed the correct number.");
//                 }
//             }
//         }
//     }
// }

