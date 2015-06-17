//Problem 11. Prefix "test"
// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    const string PATH = @"..\..\TestFiles\";
    const string INPUT_FILE = PATH + "test.txt";
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        Console.Write("Enter output file name < filename.txt >: ");
        string fileName = Console.ReadLine();
        string outputFile = PATH + fileName;

        reader = new StreamReader(INPUT_FILE);
        writer = new StreamWriter(outputFile);

        string line = reader.ReadLine();

        while (line != null)
        {
            string resultLine = Regex.Replace(line, "\\btest[A-Za-z0-9_]*\\b", string.Empty);

            char[] separator = { ' ' };
            string[] lineToarray = resultLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            resultLine = string.Join(" ", lineToarray);

            writer.WriteLine(resultLine);
            line = reader.ReadLine();
        }
        reader.Close();
        writer.Close();

        Console.WriteLine("New File Created");
        Console.WriteLine(outputFile);
    }
}