// Problem 4. Triangle surface
// Write methods that calculate the surface of a triangle by given:
//  - Side and an altitude to it;
//  - Three sides;
//  - Two sides and an angle between them;
// Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("MENU:");
        Console.WriteLine("[1] --> Side and an altitude to it");
        Console.WriteLine("[2] --> Three sides");
        Console.WriteLine("[3] --> Two sides and an angle between them");
        Console.Write("Calculate the surface of a triangle by given: ");

        string choice = Console.ReadLine();

        double surface = 0;

        switch (choice)
        {
            case "1": surface = PrintSurfaceBySideAndAltitude(); break;
            case "2": surface = PrintSurfaceByThreeSides(); break;
            case "3": surface = PrintSurfaceByTwoSidesAndAngle(); break;
            default: Console.WriteLine("Incorrect input!"); break;
        }

        Console.WriteLine("Surface = {0:F3}", surface);
    }

    static double PrintSurfaceBySideAndAltitude()
    {
        Console.Write("Enter a side length: ");
        double side = double.Parse(Console.ReadLine());

        Console.Write("Enter an altitude: ");
        double altitude = double.Parse(Console.ReadLine());

        double surface = (side * altitude) / 2;

        return surface;
    }

    static double PrintSurfaceByThreeSides()
    {
        Console.Write("Enter the length of first side: ");
        double firstSide = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of second side: ");
        double secondSide = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of third side: ");
        double thirdSide = double.Parse(Console.ReadLine());

        double perimeter = firstSide + secondSide + thirdSide;

        double surface = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));

        return surface;
    }

    static double PrintSurfaceByTwoSidesAndAngle()
    {
        Console.Write("Enter the length of first side: ");
        double firstSide = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of second side: ");
        double secondSide = double.Parse(Console.ReadLine());

        Console.Write("Enter an angle: ");
        double angle = double.Parse(Console.ReadLine());

        double angleInRadians = (Math.PI * angle) / 180;

        double surface = (firstSide * secondSide * Math.Sin(angleInRadians)) / 2;

        return surface;
    }
}