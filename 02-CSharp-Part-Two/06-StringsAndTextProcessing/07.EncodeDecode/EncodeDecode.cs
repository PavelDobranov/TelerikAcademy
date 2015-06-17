// Problem 7. Encode/decode
// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string
// with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        string encoded = EncodeDecodeText(input, key);
        Console.WriteLine("Encoded: {0}", encoded);

        string decoded = EncodeDecodeText(encoded, key);
        Console.WriteLine("Decoded: {0}", decoded);
    }

    static string EncodeDecodeText(string text, string key)
    {
        StringBuilder result = new StringBuilder();

        int keyIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ key[keyIndex]));
            keyIndex++;

            if (keyIndex == key.Length - 1)
            {
                keyIndex = 0;
            }
        }
        return result.ToString();
    }
}