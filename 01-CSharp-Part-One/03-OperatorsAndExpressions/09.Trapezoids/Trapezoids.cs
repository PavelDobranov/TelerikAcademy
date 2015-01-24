// Problem 9. Trapezoids
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter the length of bottom side: a = ");
        double bottomSide = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of top side: b = ");
        double topSide = double.Parse(Console.ReadLine());

        Console.Write("Enter the height: h = ");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = CalculateTrapezoidArea(bottomSide, topSide, height);

        Console.WriteLine("Area: {0}", trapezoidArea);
    }

    static double CalculateTrapezoidArea(double bottomSide, double topSide, double height)
    {
        return (height * (bottomSide + topSide)) / 2;
    }
}