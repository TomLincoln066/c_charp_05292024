/*
1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would

become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
Your Mainmethod will look something like this:
static void Main(string[] args) {
int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);
}
The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
change the method to allow the desired length to be passed in, instead of just always
being 10.)
The PrintNumbersmethod should use a foror foreachloop to print out each item in the
array. The Reversemethod will be the hardest. Give it a try and see what you can make
happen. 
If you get
stuck, here’s a couple of hints:

Hint #1:To swap two values, you will need to place the value of one variable in a temporary
location to make the swap:
// Swapping a and b.
int a = 3;
int b = 5;
int temp = a;
a = b;
b = temp;

Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
and going up to the length of the array / 2. The number you use in the forloop will be the
index of the first number to swap, and the other one will be the length of the array minus
the index minus 1. This is to account for the fact that the array is 0-based. So basically,
you’ll be swapping array[index]with array[arrayLength – index – 1].
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10); // Change the argument to generate a different length array
        Console.WriteLine("Original array:");
        PrintNumbers(numbers);

        Reverse(numbers);
        Console.WriteLine("Reversed array:");
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1; // Filling the array with numbers 1 to length
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine(); // For a new line after printing the array
    }
}
