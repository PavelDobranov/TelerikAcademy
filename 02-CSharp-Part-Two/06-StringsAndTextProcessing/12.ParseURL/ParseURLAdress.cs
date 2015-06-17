// Problem 12. Parse URL
// Write a program that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURLAdress
{
    static void Main()
    {
        string urlAddress = "http://telerikacademy.com/Courses/Courses/Details/212";

        Console.WriteLine("Result: ");
        PrintParsedUrl(urlAddress);
    }

    static void PrintParsedUrl(string urlAddress)
    {
        int index = 0;
        int length = urlAddress.IndexOf(':');
        string protocol = urlAddress.Substring(index, length);

        index = length + 3;
        length = urlAddress.IndexOf('/', index) - index;
        string server = urlAddress.Substring(index, length);

        index = urlAddress.LastIndexOf(server) + server.Length;
        length = urlAddress.Length - index;
        string resource = urlAddress.Substring(index, length);

        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[server] = \"{0}\"", resource);
    }
}