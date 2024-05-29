/*
Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator
*/



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         // Read the input sentence
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();

//         // Reverse the words in the sentence
//         string reversedSentence = ReverseWordsInSentence(sentence);

//         // Print the result
//         Console.WriteLine("Reversed sentence:");
//         Console.WriteLine(reversedSentence);
//     }

//     static string ReverseWordsInSentence(string sentence)
//     {
//         // Define the separators
//         char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

//         // Split the sentence into words and separators
//         List<string> parts = new List<string>();
//         StringBuilder word = new StringBuilder();
        
//         foreach (char c in sentence)
//         {
//             if (separators.Contains(c))
//             {
//                 if (word.Length > 0)
//                 {
//                     parts.Add(word.ToString());
//                     word.Clear();
//                 }
//                 parts.Add(c.ToString());
//             }
//             else
//             {
//                 word.Append(c);
//             }
//         }

//         if (word.Length > 0)
//         {
//             parts.Add(word.ToString());
//         }

//         // Reverse the words
//         List<string> words = parts.Where(part => !separators.Contains(part[0])).ToList();
//         words.Reverse();

//         // Reconstruct the sentence
//         StringBuilder result = new StringBuilder();
//         int wordIndex = 0;

//         foreach (string part in parts)
//         {
//             if (separators.Contains(part[0]))
//             {
//                 result.Append(part);
//             }
//             else
//             {
//                 result.Append(words[wordIndex]);
//                 wordIndex++;
//             }
//         }

//         return result.ToString();
//     }
// }
