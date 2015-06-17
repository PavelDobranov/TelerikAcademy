// Problem 15. Replace tags
// Write a program that replaces in a HTML document given as string all the tags 
// <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;

class ReplaceTags
{
    static void Main()
    {
        string htmlDocument =
            "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course.\n"
            + "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string result = ReplaceAnchorTags(htmlDocument);

        Console.WriteLine("Result: \n{0}", result);
    }

    static string ReplaceAnchorTags(string document)
    {
        string[] existingTags = { "<a href=\"", "\">", "</a>" };
        string[] newTags = { "[URL=", "]", "[/URL]" };

        for (int i = 0; i < existingTags.Length; i++)
        {
            document = document.Replace(existingTags[i], newTags[i]);
        }

        return document;
    }
}