// Problem 3. Line numbers
// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
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

        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                WriteToFile(lineNumber, line, outputFile);
                lineNumber++;
                line = reader.ReadLine();
            }
        }

        Console.WriteLine("New file with line numbers created");
        Console.WriteLine(outputFile);
    }

    static void WriteToFile(int lineNumber, string line, string outputFile)
    {
        writer = new StreamWriter(outputFile, true);

        using (writer)
        {
            writer.WriteLine("Line {0}: {1}", lineNumber, line);
        }
    }
}