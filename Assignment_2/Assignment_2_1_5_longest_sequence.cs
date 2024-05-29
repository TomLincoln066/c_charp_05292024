/*
Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one
*/

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Read the array of integers
//         Console.WriteLine("Enter the array of integers (space separated):");
//         int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

//         // Find the longest sequence of equal elements
//         int[] longestSequence = FindLongestSequence(array);

//         // Print the longest sequence
//         Console.WriteLine("Longest sequence of equal elements:");
//         Console.WriteLine(string.Join(" ", longestSequence));
//     }

//     static int[] FindLongestSequence(int[] array)
//     {
//         int maxLength = 0;
//         int maxStartIndex = 0;
//         int currentLength = 1;

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] == array[i - 1])
//             {
//                 currentLength++;
//             }
//             else
//             {
//                 if (currentLength > maxLength)
//                 {
//                     maxLength = currentLength;
//                     maxStartIndex = i - currentLength;
//                 }
//                 currentLength = 1;
//             }
//         }

//         // Check the last sequence
//         if (currentLength > maxLength)
//         {
//             maxLength = currentLength;
//             maxStartIndex = array.Length - currentLength;
//         }

//         // Create the longest sequence array
//         int[] longestSequence = new int[maxLength];
//         for (int i = 0; i < maxLength; i++)
//         {
//             longestSequence[i] = array[maxStartIndex + i];
//         }

//         return longestSequence;
//     }
// }
