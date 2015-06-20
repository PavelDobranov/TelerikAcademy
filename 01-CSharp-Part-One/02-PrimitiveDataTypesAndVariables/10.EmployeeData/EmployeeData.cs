// Problem 10. Employee Data
// A marketing company wants to keep record of its employees. Each record would have the 
// following characteristics:
//  - First name
//  - Last name
//  - Age (0...100)
//  - Gender (m or f)
//  - Personal ID number (e.g. 8306112507)
//  - Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate 
// primitive data types. Use descriptive names. Print the data at the console.
using System;

public class EmployeeData
{
    static void Main()
    {
        string firstName = "Pesho";
        string lastName = "Ivanov";
        byte age = 23;
        char gender = 'm';
        ulong idNumber = 8306112507;
        ushort employeeNumber = 9768; // from 0 to 9999 --> ([2756]0000 [2756]9999)

        Console.WriteLine("Employee Data");
        Console.WriteLine("=============");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender == 'm' ? "male" : "female");
        Console.WriteLine("Personal ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: 2756{0}", employeeNumber);
    }
}