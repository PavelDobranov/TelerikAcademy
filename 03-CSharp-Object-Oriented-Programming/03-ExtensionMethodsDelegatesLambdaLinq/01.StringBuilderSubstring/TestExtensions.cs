// Problem 1. StringBuilder.Substring
// Implement an extension method Substring(int index, int length) for the class StringBuilder 
// that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    public class TestExtensions
    {
        public static void Main()
        {
            string str = "some test string";

            var sb = new StringBuilder(str);

            int startIndex = 5;
            int length = 4;

            var result = sb.Substring(startIndex, length);

            Console.WriteLine(result.ToString());
        }
    }
}