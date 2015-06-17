// Problem 2. Concatenate text files
// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTextFiles
{
    const string PATH = @"..\..\TestFiles\";
    const string FIRST_INPUT_FILE = PATH + "test01.txt";
    const string SECOND_INPUT_FILE = PATH + "test02.txt";
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        Console.Write("Enter output file name < filename.txt >: ");
        string fileName = Console.ReadLine();
        string outputFile = PATH + fileName;

        string fileContent = GetFileContent(FIRST_INPUT_FILE);

        WriteToFile(fileContent, outputFile);

        fileContent = GetFileContent(SECOND_INPUT_FILE);

        AppendToFile(fileContent, outputFile);

        Console.WriteLine("Concatenation complete");
        Console.WriteLine(outputFile);

    }

    static string GetFileContent(string file)
    {
        reader = new StreamReader(file);

        string fileContent = string.Empty;

        using (reader)
        {
            fileContent = reader.ReadToEnd();
        }

        return fileContent;
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