/*
Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted
*/

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         // Read the input text
//         Console.WriteLine("Enter the text:");
//         string text = Console.ReadLine();

//         // Extract and print unique sorted palindromes
//         List<string> palindromes = ExtractPalindromes(text);

//         // Print the result
//         Console.WriteLine("Palindromes:");
//         Console.WriteLine(string.Join(", ", palindromes));
//     }

//     static List<string> ExtractPalindromes(string text)
//     {
//         // Define a regular expression to match words
//         string pattern = @"\b\w+\b";
//         MatchCollection matches = Regex.Matches(text, pattern);

//         HashSet<string> palindromeSet = new HashSet<string>();

//         foreach (Match match in matches)
//         {
//             string word = match.Value;
//             if (IsPalindrome(word))
//             {
//                 palindromeSet.Add(word);
//             }
//         }

//         // Convert the set to a list and sort it
//         List<string> palindromes = palindromeSet.ToList();
//         palindromes.Sort();

//         return palindromes;
//     }

//     static bool IsPalindrome(string word)
//     {
//         int length = word.Length;
//         for (int i = 0; i < length / 2; i++)
//         {
//             if (word[i] != word[length - 1 - i])
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }
