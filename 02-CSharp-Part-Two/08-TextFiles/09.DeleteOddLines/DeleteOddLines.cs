// Problem 9. Delete odd lines
// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    const string PATH = @"..\..\TestFiles\";
    const string INPUT_FILE = PATH + "test.txt";
    static List<string> evenLinesCollector = new List<string>();
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        CollectEvenLinesFromTextFIle();

        WriteToFile(evenLinesCollector);

        Console.WriteLine("File updated");
        Console.WriteLine(INPUT_FILE);
    }

    static void CollectEvenLinesFromTextFIle()
    {
        reader = new StreamReader(INPUT_FILE);

        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    evenLinesCollector.Add(line);
                }

                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }

    static void WriteToFile(List<string> collector)
    {
        writer = new StreamWriter(INPUT_FILE);

        using (writer)
        {
            foreach (var line in evenLinesCollector)
            {
                writer.WriteLine(line);
            }
        }
    }
}