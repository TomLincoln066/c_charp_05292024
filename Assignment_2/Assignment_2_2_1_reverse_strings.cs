/*
Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop
*/

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Read the string from the console
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();

//         // Method 1: Using char array
//         string reversedUsingCharArray = ReverseUsingCharArray(input);
//         Console.WriteLine("Reversed using char array: " + reversedUsingCharArray);

//         // Method 2: Using for-loop
//         string reversedUsingForLoop = ReverseUsingForLoop(input);
//         Console.WriteLine("Reversed using for-loop: " + reversedUsingForLoop);
//     }

//     static string ReverseUsingCharArray(string input)
//     {
//         char[] charArray = input.ToCharArray();
//         Array.Reverse(charArray);
//         return new string(charArray);
//     }

//     static string ReverseUsingForLoop(string input)
//     {
//         string reversed = "";
//         for (int i = input.Length - 1; i >= 0; i--)
//         {
//             reversed += input[i];
//         }
//         return reversed;
//     }
// }
