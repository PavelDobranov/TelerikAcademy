// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area
// formatted with 2 digits after the decimal point.

using System;

public class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double circleRadius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * circleRadius;
        double circleArea = Math.PI * circleRadius * circleRadius;

        Console.WriteLine("Perimeter: {0:F2}", circlePerimeter);
        Console.WriteLine("Area: {0:F2}", circleArea);
    }
}