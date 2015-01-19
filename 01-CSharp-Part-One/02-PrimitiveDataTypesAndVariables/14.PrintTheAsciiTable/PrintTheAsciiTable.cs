// Problem 14.* Print the ASCII Table
// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console
// (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. 
// You may skip them or display them differently.
// Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheAsciiTable
{
    static void Main()
    {
        byte asciiMinValue = 0;
        byte asciiMaxValue = 255;

        for (byte charCode = asciiMinValue; charCode <= asciiMaxValue; charCode++)
        {
            PrintFormatedAsciiRow(charCode);   
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n* 0 to 31 --> Unprintable Control Codes\nUsed to Control Peripherals Such as Printers.\n127 --> Represents The Command DEL\n");
        Console.ResetColor();
    }

    static void PrintFormatedAsciiRow(byte charCode) 
    {
        byte padding = 6;
        string charDecimalRepresentation = charCode.ToString().PadRight(padding, ' ');
        string charOctalRepresentation = Convert.ToString(charCode, 8).PadRight(padding, ' '); // Octal representation
        string charHexadecimalRepresentation = Convert.ToString(charCode, 16).PadRight(padding, ' '); // Hexadecimal representation
        string charBinaryRepresentation = Convert.ToString(charCode, 2).PadRight(padding, ' '); // Binary representation
        char character = (char)charCode;

        Console.WriteLine("[DEC] {0} [OCT] {1} [HEX] {2} [BIN] {3} [CHAR] {4}", charDecimalRepresentation, charOctalRepresentation, charHexadecimalRepresentation, charBinaryRepresentation, character);
    }
}