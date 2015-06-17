// Problem 4. Compare text files
// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    const string PATH = @"..\..\TestFiles\";
    const string FIRST_INPUT_FILE = PATH + "test01.txt";
    const string SECOND_INPUT_FILE = PATH + "test02.txt";
    static StreamReader firstFileReader;
    static StreamReader secondFileReader;

    static void Main()
    {
        CompareFiles(FIRST_INPUT_FILE, SECOND_INPUT_FILE);
    }

    static void CompareFiles(string firstFile, string secondFile)
    {
        int totalLines = 0;
        int equalLines = 0;
        int differentLines = 0;

        firstFileReader = new StreamReader(firstFile);
        secondFileReader = new StreamReader(secondFile);

        using (firstFileReader)
        {            
            using (secondFileReader)
            {
                string firstFileLine = firstFileReader.ReadLine();
                string secondFileLine = secondFileReader.ReadLine();

                while (firstFileLine != null && secondFileLine != null)
                {
                    if (firstFileLine == secondFileLine)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    totalLines++;

                    firstFileLine = firstFileReader.ReadLine();
                    secondFileLine = secondFileReader.ReadLine();
                }
            }
        }
        
        Console.WriteLine("Total Lines: {0}", totalLines);
        Console.WriteLine("Equal Lines: {0}", equalLines);
        Console.WriteLine("Different Lines: {0}", differentLines);
    }
}