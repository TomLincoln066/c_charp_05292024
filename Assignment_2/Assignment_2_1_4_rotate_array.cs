/*
Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
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

//         // Read the integer k
//         Console.WriteLine("Enter the number of rotations:");
//         int k = int.Parse(Console.ReadLine());

//         // Calculate the sum array after k rotations
//         int[] sumArray = CalculateSumAfterRotations(array, k);

//         // Print the sum array
//         Console.WriteLine("Sum array after rotations:");
//         Console.WriteLine(string.Join(" ", sumArray));
//     }

//     static int[] CalculateSumAfterRotations(int[] array, int k)
//     {
//         int n = array.Length;
//         int[] sumArray = new int[n];

//         // Perform k rotations
//         for (int r = 1; r <= k; r++)
//         {
//             int[] rotatedArray = new int[n];

//             // Calculate the rotated array
//             for (int i = 0; i < n; i++)
//             {
//                 int newPosition = (i + r) % n;
//                 rotatedArray[newPosition] = array[i];
//             }

//             // Sum the rotated array into sumArray
//             for (int i = 0; i < n; i++)
//             {
//                 sumArray[i] += rotatedArray[i];
//             }
//         }

//         return sumArray;
//     }
// }
