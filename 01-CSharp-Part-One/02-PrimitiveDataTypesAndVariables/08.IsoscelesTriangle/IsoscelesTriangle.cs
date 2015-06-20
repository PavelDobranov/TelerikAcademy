// Problem 8. Isosceles Triangle
// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
//
//   © ©
//
//  ©   ©
//
// © © © ©
// Note: The © symbol may be displayed incorrectly at the console so you may need to change the console
// character encoding to UTF-8 and assign a Unicode-friendly font in the console.
// Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless
// of how much effort you put to fix it.

using System;
using System.Text;

public class IsoscelesTriangle
{
    static void Main()
    {
        char copyrightSybol = '\u00A9';
        char spaceSybol = ' ';
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("{0}{1}\n", new string(spaceSybol, 3), copyrightSybol);
        Console.WriteLine("{0}{1}{2}{1}\n", new string(spaceSybol, 2), copyrightSybol, new string(spaceSybol, 1));
        Console.WriteLine("{0}{1}{2}{1}\n", new string(spaceSybol, 1), copyrightSybol, new string(spaceSybol, 3));
        Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}", copyrightSybol, spaceSybol);
    }
}