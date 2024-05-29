/*
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly.
*/

// using System;

// namespace ArrayCopy
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create the initial array with 10 items
//             int[] originalArray = new int[10];

//             // Populate the original array with some values
//             for (int i = 0; i < originalArray.Length; i++)
//             {
//                 originalArray[i] = i * 2;
//             }

//             // Create a second array with the same length as the original array
//             int[] copiedArray = new int[originalArray.Length];

//             // Copy values from the original array to the new array
//             for (int i = 0; i < originalArray.Length; i++)
//             {
//                 copiedArray[i] = originalArray[i];
//             }

//             // Print the contents of the original array
//             Console.WriteLine("Original Array:");
//             for (int i = 0; i < originalArray.Length; i++)
//             {
//                 Console.Write(originalArray[i] + " ");
//             }
//             Console.WriteLine();

//             // Print the contents of the copied array
//             Console.WriteLine("Copied Array:");
//             for (int i = 0; i < copiedArray.Length; i++)
//             {
//                 Console.Write(copiedArray[i] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
