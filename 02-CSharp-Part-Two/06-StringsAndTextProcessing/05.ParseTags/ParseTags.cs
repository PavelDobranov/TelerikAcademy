// Problem 5. Parse tags
// You are given a text. Write a program that changes the text in all regions surrounded 
// by the tags <upcase> and </upcase> to upper-case.
// The tags cannot be nested.

using System;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string result = ParseUpcaseTags(text);

        Console.WriteLine("Result: {0}", result);
    }

    static string ParseUpcaseTags(string text)
    {
        string startTag = "<upcase>";
        string endTag = "</upcase>";

        while (text.IndexOf(startTag) != -1)
        {
            int startIndex = text.IndexOf(startTag);

            int endIndex = text.IndexOf(endTag);

            string temp = text.Substring(startIndex + startTag.Length, endIndex - startIndex - startTag.Length);

            text = text.Replace(startTag + temp + endTag, temp.ToUpper());
        }

        return text;
    }
}