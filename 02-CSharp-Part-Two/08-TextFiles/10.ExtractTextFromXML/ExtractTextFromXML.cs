// Problem 10. Extract text from XML
// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

class ExtractTextFromXML
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
            for (int i = 0; i < line.Length; i++)
            {
                if ((line[i] != '<' && i == 0) || (line[i] != '<' && line[i - 1] == '>'))
                {
                    writer.WriteLine(GetText(i, line));
                }
            }

            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();

        Console.WriteLine("New File Created");
        Console.WriteLine(outputFile);
    }

    static string GetText(int startIndex, string line)
    {
        int endIndex = line.IndexOf('<', startIndex);

        if (endIndex == -1)
        {
            return line.Substring(startIndex);
        }
        else
        {
            int length = line.IndexOf('<', startIndex) - startIndex;
            return line.Substring(startIndex, length);
        }
    }
}