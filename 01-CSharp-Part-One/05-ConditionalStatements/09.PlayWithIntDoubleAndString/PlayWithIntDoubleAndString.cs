// Problem 9. Play with Int, Double and String
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//  - If the variable is int or double, the program increases it by one.
//  - If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Write("Enter a integer: ");
                int intInput = int.Parse(Console.ReadLine());

                Console.WriteLine("Result: {0}", intInput + 1);
                break;
            case "2":
                Console.Write("Enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());

                Console.WriteLine("Result: {0}", doubleInput + 1);
                break;
            case "3":
                Console.Write("Enter a string: ");
                string stringInput = Console.ReadLine();

                string symbol = "*";

                Console.WriteLine("Result: {0}{1}", stringInput, symbol);
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }
    }
}