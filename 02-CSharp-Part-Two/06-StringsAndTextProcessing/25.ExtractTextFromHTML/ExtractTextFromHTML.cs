// Problem 25. Extract text from HTML
// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;

class ExtractTextFromHTML
{
    static void Main()
    {
        string document =
            "<html>"
            + "<head><title>News</title></head>\n"
            + "<body><p><a href=\"http://academy.telerik.com\">Telerik Academy\n"
            + "</a>aims to provide free real-world practical\n"
            + "training for young people who want to turn into\n"
            + "skillful .NET software engineers.</p></body>\n"
            + "</html>";

        Console.WriteLine("Result: ");
        PrintParsedHtml(document);
    }

    static void PrintParsedHtml(string document)
    {
        int colseTagIndex = document.IndexOf('>');

        while (colseTagIndex > -1)
        {
            if (colseTagIndex < document.Length - 1 && document[colseTagIndex + 1] != '<')
            {
                int openTagIndex = document.IndexOf('<', colseTagIndex);

                int textLength = openTagIndex - colseTagIndex - 1;

                string result = document.Substring(colseTagIndex + 1, textLength).Trim();

                Console.WriteLine(result);
            }

            colseTagIndex = document.IndexOf('>', colseTagIndex + 1);
        }
    }
}