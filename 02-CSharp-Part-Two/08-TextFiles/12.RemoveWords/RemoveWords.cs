// Problem 12. Remove words
// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    const string PATH = @"..\..\TestFiles\";
    const string WORDS_FILE = PATH + "words.txt";
    const string INPUT_FILE = PATH + "test.txt";
    static List<string> wordsCollector = new List<string>();
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        try
        {
            Console.Write("Enter output file name < filename.txt >: ");

            string fileName = Console.ReadLine();

            if (fileName == string.Empty)
            {
                throw new FileNotFoundException();
            }

            string outputFile = PATH + fileName;

            GetListedWords();

            UpdateFile(outputFile);

            Console.WriteLine("New file created");
            Console.WriteLine(outputFile);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Test files directory not found");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Test input/output file not found");
        }
        catch (IOException)
        {
            Console.WriteLine("IO exception error");
        }
    }

    static void GetListedWords()
    {
        reader = new StreamReader(WORDS_FILE);

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string word = line.Trim();
                wordsCollector.Add(word);
                line = reader.ReadLine();
            }
        }
    }

    static void UpdateFile(string outputFile)
    {
        reader = new StreamReader(INPUT_FILE);
        writer = new StreamWriter(outputFile);

        string line = reader.ReadLine();

        while (line != null)
        {
            foreach (var word in wordsCollector)
            {
                string RegularExpression = String.Concat("\\b", word, "\\b");

                line = Regex.Replace(line, RegularExpression, String.Empty);
                line = line.Trim();
                line = line.Replace("  ", " ");
            }
            writer.WriteLine(line);
            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();
    }
}