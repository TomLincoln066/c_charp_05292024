/*
Try creating the two classes below, and make a simple program to work with them, as
described below
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value.
A constructor that takes just red, green, and blue, while alpha defaults to 255
(opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red,
green and blue values.
Create a Ball class:
The Ball class should have instance variables for size and color (the Color class you just
created). Let’s also add an instance variable that keeps track of the number of times it
has been thrown.
Create any constructors you feel would be useful.
Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
popped (has a size of 0).
A method that returns the number of times the ball has been thrown.
Write some code in your Main method to create a few balls, throw them around a few
times, pop a few, and try to throw them again, and print out the number of times that the
balls have been thrown. (Popped balls shouldn’t have 
*/

using System;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }

    // Constructor with alpha
    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    // Constructor without alpha, default alpha to 255
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    // Method to calculate grayscale value
    public int GetGrayscaleValue()
    {
        return (Red + Green + Blue) / 3;
    }
}

public class Ball
{
    public int Size { get; private set; }
    public Color Color { get; set; }
    private int throwCount;

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ball redBall = new Ball(10, new Color(255, 0, 0));
        Ball blueBall = new Ball(12, new Color(0, 0, 255));

        // Throw balls
        redBall.Throw();
        redBall.Throw();
        blueBall.Throw();

        // Pop the red ball
        redBall.Pop();

        // Try to throw the popped ball
        redBall.Throw();

        // Print throw counts
        Console.WriteLine($"Red Ball thrown: {redBall.GetThrowCount()} times");  // Expect 2
        Console.WriteLine($"Blue Ball thrown: {blueBall.GetThrowCount()} times"); // Expect 1
    }
}
