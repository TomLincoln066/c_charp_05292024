/*
Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism/.
*/

using System;

namespace OOPPrinciples
{
    // Abstraction: Abstract class Shape
    public abstract class Shape
    {
        // Encapsulation: Protected fields
        protected double width;
        protected double height;

        // Abstract method for area calculation
        public abstract double CalculateArea();

        // Encapsulation: Public properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }

    // Inheritance: Circle inherits from Shape
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.width = radius;  // For Circle, width will be used as radius
        }

        // Polymorphism: Overriding CalculateArea method
        public override double CalculateArea()
        {
            return Math.PI * width * width;  // Area of circle = πr²
        }
    }

    // Inheritance: Rectangle inherits from Shape
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Polymorphism: Overriding CalculateArea method
        public override double CalculateArea()
        {
            return width * height;  // Area of rectangle = width * height
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: Using Shape reference for different derived classes
            Shape myCircle = new Circle(5);
            Shape myRectangle = new Rectangle(4, 6);

            // Display the areas
            Console.WriteLine($"Area of the circle: {myCircle.CalculateArea()}");
            Console.WriteLine($"Area of the rectangle: {myRectangle.CalculateArea()}");
        }
    }
}
