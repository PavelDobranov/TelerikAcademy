// Problem 2. Print Company Information
// A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager 
// and prints it back on the console.

using System;
using System.Text;

public class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(companyName))
        {
            companyName = "(no company)";
        }

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(companyAddress))
        {
            companyAddress = "(no address)";
        }

        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(companyPhone))
        {
            companyPhone = "(no phone)";
        }

        Console.Write("Enter company fax number: ");
        string companyFax = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(companyFax))
        {
            companyFax = "(no fax)";
        }

        Console.Write("Enter company web site: ");
        string companyWeb = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(companyWeb))
        {
            companyWeb = "(no web site)";
        }

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(managerFirstName))
        {
            managerFirstName = "(no name)";
        }

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(managerLastName))
        {
            managerLastName = "(no name)";
        }

        Console.Write("Enter manager age: ");
        string managerAge = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(managerAge))
        {
            managerAge = "(no age)";
        }

        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(managerPhone))
        {
            managerPhone = "(no phone)";
        }

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: {0}", companyAddress);
        Console.WriteLine("Tel: {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax);
        Console.WriteLine("Web site: {0}", companyWeb);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}