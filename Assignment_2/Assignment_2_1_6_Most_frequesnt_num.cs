/*
Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
*/

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Read the array of integers
//         Console.WriteLine("Enter the array of integers (space separated):");
//         int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

//         // Find the most frequent number
//         int mostFrequentNumber = FindMostFrequentNumber(array);

//         // Print the result
//         Console.WriteLine($"The most frequent number is {mostFrequentNumber}");
//     }

//     static int FindMostFrequentNumber(int[] array)
//     {
//         Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
//         int maxFrequency = 0;
//         int mostFrequentNumber = array[0];

//         for (int i = 0; i < array.Length; i++)
//         {
//             int number = array[i];
//             if (frequencyDict.ContainsKey(number))
//             {
//                 frequencyDict[number]++;
//             }
//             else
//             {
//                 frequencyDict[number] = 1;
//             }

//             int currentFrequency = frequencyDict[number];
//             if (currentFrequency > maxFrequency || 
//                 (currentFrequency == maxFrequency && Array.IndexOf(array, mostFrequentNumber) > i))
//             {
//                 maxFrequency = currentFrequency;
//                 mostFrequentNumber = number;
//             }
//         }

//         return mostFrequentNumber;
//     }
// }
