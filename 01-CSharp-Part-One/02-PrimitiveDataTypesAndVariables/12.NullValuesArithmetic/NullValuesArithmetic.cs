// Problem 12. Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("integer with null value: a = {0}", a);
        Console.WriteLine("real number with null value: b = {0}\n", b);

        // Case 1
        a = a.GetValueOrDefault() + 3;
        Console.WriteLine("Case 1: [ a = a.GetValueOrDefault() + 3 ]");
        Console.WriteLine("result --> a = {0}\n", a);

        // Case 2
        b = b.GetValueOrDefault() + 6.25;
        Console.WriteLine("Case 2: [ b = b.GetValueOrDefault() + 6.25 ]");
        Console.WriteLine("result --> b = {0}\n", b);

        // Case 3
        a = a.Value + null;
        Console.WriteLine("Case 3: [ a = a.Value + null ]");
        Console.WriteLine("result --> a = {0}\n", a);

        // Case 4
        b = b.Value + null;
        Console.WriteLine("Case 4: [ b = b.Value + null ]");
        Console.WriteLine("result --> b = {0}\n", b);
    }
}