/*
A byte can only hold values from 0 to 255. When i reaches 255 and is incremented, 
it will overflow and wrap around to 0. 
This will cause an infinite loop because i will never reach 500.

Solution:To detect and warn about this problem without changing the existing code, 
we can add a condition to check for overflow and break the loop when it reach the bound.
*/


// using System;
// using static System.Console;

// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     WriteLine(i);
//     if (i == byte.MaxValue)
//                 {
//                     WriteLine("Warning: Byte overflow detected. The loop will restart from 0.");
//                     break;
//                 }
// }