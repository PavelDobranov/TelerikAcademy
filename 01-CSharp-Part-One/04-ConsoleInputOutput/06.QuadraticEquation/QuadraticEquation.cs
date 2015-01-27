// Problem 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic equation
// ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a coefficient [a]: ");
        double aCoefficient = double.Parse(Console.ReadLine());

        Console.Write("Enter a coefficient [b]: ");
        double bCoefficient = double.Parse(Console.ReadLine());

        Console.Write("Enter a coefficient [c]: ");
        double cCoefficient = double.Parse(Console.ReadLine());

        double discriminant = (bCoefficient * bCoefficient) - (4 * aCoefficient * cCoefficient);
        double root1;
        double root2;

        if (discriminant > 0)
        {
            root1 = (-bCoefficient - Math.Sqrt(discriminant)) / (2 * aCoefficient);
            root2 = (-bCoefficient + Math.Sqrt(discriminant)) / (2 * aCoefficient);

            Console.WriteLine("Two real roots: x1 = {0} and  x2 = {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            root1 = -bCoefficient / (2 * aCoefficient);
            
            Console.WriteLine("One real root: {0}", root1);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
    }
}