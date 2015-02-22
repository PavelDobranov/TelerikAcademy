// Problem 5. Hexadecimal to binary
// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Number(16) = ");
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.WriteLine("Number(2) = {0}", ConvertHexadecimalToBinary(number));
    }

    static string ConvertHexadecimalToBinary(string number)
    {
        Queue<string> bits = new Queue<string>();

        for (int digit = 0; digit < number.Length; digit++)
        {
            switch (number[digit])
            {
                case '0': bits.Enqueue("0000"); break;
                case '1': bits.Enqueue("0001"); break;
                case '2': bits.Enqueue("0010"); break;                    
                case '3': bits.Enqueue("0011"); break;                    
                case '4': bits.Enqueue("0100"); break;                    
                case '5': bits.Enqueue("0101"); break;                    
                case '6': bits.Enqueue("0110"); break;                    
                case '7': bits.Enqueue("0111"); break;                    
                case '8': bits.Enqueue("1000"); break;                    
                case '9': bits.Enqueue("1001"); break;                    
                case 'A': bits.Enqueue("1010"); break;                    
                case 'B': bits.Enqueue("1011"); break;                    
                case 'C': bits.Enqueue("1100"); break;                    
                case 'D': bits.Enqueue("1101"); break;                    
                case 'E': bits.Enqueue("1110"); break;                    
                case 'F': bits.Enqueue("1111"); break;                    
            }
        }
        
        return string.Join("",bits);
    }
}