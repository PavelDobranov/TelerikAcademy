// Problem 6. Save sorted names
// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    const string PATH = @"..\..\TestFiles\";
    const string INPUT_FILE = PATH + "test.txt";
    static List<string> lineCollector = new List<string>();
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        Console.Write("Enter output file name < filename.txt >: ");
        string fileName = Console.ReadLine();
        string outputFile = PATH + fileName;

        AddFileRowsToList();

        lineCollector.Sort();

        WriteToOutputFile(outputFile);

        Console.WriteLine("New file with sorted lines created");
        Console.WriteLine(outputFile);
    }

    static void AddFileRowsToList()
    {
        reader = new StreamReader(INPUT_FILE);

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                lineCollector.Add(line);
                line = reader.ReadLine();
            }
        }
    }

    static void WriteToOutputFile(string outputFile)
    {
        writer = new StreamWriter(outputFile);

        using (writer)
        {
            foreach (string line in lineCollector)
            {
                writer.WriteLine(line);
            }
        }
    }
}