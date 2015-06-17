// Problem 13. Count words
// Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
// The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
// Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    const string PATH = @"..\..\TestFiles\";
    const string WORDS_FILE = PATH + "words.txt";
    const string TEST_FILE = PATH + "test.txt";
    const string OUTPUT_FILE = PATH + "result.txt";
    static List<string> wordsCollector = new List<string>();
    static List<int> wordsCounter = new List<int>();
    static StreamReader reader;
    static StreamWriter writer;

    static void Main()
    {
        try
        {
            GetListedWords();

            CountWordsInFile();

            int[] wordsCounterArray = wordsCounter.ToArray();

            string[] wordsCollectorArray = wordsCollector.ToArray();

            Array.Sort(wordsCounterArray, wordsCollectorArray);

            PrrintSortedWordsToFile(wordsCollectorArray, wordsCounterArray);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Test files directory not found");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Test input file not found");
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

    static void CountWordsInFile()
    {
        for (int i = 0; i < wordsCollector.Count; i++)
        {
            string currentWord = wordsCollector[i];
            int counter = 0;

            reader = new StreamReader(TEST_FILE);

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] splitedLine = line.Split(' ');

                    foreach (var word in splitedLine)
                    {
                        if (currentWord == word)
                        {
                            counter++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            wordsCounter.Add(counter);
        }
    }

    static void PrrintSortedWordsToFile(string[] wordsCollection, int[] countersCollection)
    {
        writer = new StreamWriter(OUTPUT_FILE);

        using (writer)
        {
            for (int i = 0; i < wordsCollection.Length; i++)
            {
                writer.WriteLine("{0} - {1}", wordsCollection[i], countersCollection[i]);
            }
        }
    }
}