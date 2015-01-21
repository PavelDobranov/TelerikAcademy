// Problem 14.* Print the ASCII Table
// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console
// (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. 
// You may skip them or display them differently.
// Note: You may need to use for-loops (learn in Internet how).

using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        int asciiMinValue = 0;
        int asciiMaxValue = 255;

        for (int charCode = asciiMinValue; charCode <= asciiMaxValue; charCode++)
        {
            Console.WriteLine(PrintFormatedAsciiRow(charCode));
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("* 0 to 31 --> Unprintable control codes");
        Console.WriteLine("used to control peripherals such as printers.");
        Console.WriteLine("127 --> Represents the command DEL");
        Console.ResetColor();
    }

    static string PrintFormatedAsciiRow(int charCode) 
    {
        int padding = 8;
        int controlCodesMax = 37;
        int delCommandCode = 127;

        string charDecimalRepresentation = charCode.ToString();
        string charOctalRepresentation = Convert.ToString(charCode, 8);
        string charHexadecimalRepresentation = Convert.ToString(charCode, 16);
        string charBinaryRepresentation = Convert.ToString(charCode, 2);
        string character = charCode <= controlCodesMax || charCode == delCommandCode ? "N/A *" : ((char)charCode).ToString();

        return string.Format("[DEC] {0} [OCT] {1} [HEX] {2} [BIN] {3} [CHAR] {4}", 
            charDecimalRepresentation.PadRight(padding, ' '),
            charOctalRepresentation.PadRight(padding, ' '),
            charHexadecimalRepresentation.PadRight(padding, ' '),
            charBinaryRepresentation.PadRight(padding, ' '), 
            character);
    }
}