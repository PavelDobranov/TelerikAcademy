// Problem 7. Replace sub-string
// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubString
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
            string line = reader.ReadLine();
            string newLine = ReplaceSubstrings(line);
         
            WriteToFile(newLine, outputFile);
       
            while (line != null)
            {
                newLine = ReplaceSubstrings(line);
                AppendToFile(newLine, outputFile);
                line = reader.ReadLine();
            }
        }

        Console.WriteLine("New file created");
        Console.WriteLine(outputFile);
    }

    static string ReplaceSubstrings(string line)
    {
        string[] separator = { "start" };
        string[] separatedLine = line.Split(separator, StringSplitOptions.None);
        string newLine = string.Join("finish", separatedLine);

        return newLine;
    }

    static void WriteToFile(string content, string outputFile)
    {
        writer = new StreamWriter(outputFile, false);

        using (writer)
        {
            writer.WriteLine(content);
        }
    }

    static void AppendToFile(string content, string outputFile)
    {
        writer = new StreamWriter(outputFile, true);

        using (writer)
        {
            writer.WriteLine(content);
        }
    }
}