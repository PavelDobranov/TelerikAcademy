// Problem 1. Say Hello
// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        PrintName();
    }
    
    static void PrintName() 
    {
        Console.Write("Enter your name: ");
        string inputName = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", inputName);
    }
}