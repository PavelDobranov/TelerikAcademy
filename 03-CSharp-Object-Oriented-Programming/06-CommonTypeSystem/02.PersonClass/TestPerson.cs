// Problem 4. Person class
// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value). 
// Override ToString() to display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

namespace PersonClass
{
    using System;

    class TestPerson
    {
        static void Main()
        {
            try
            {
                Person pesho = new Person("Petar");
                Person vankata = new Person("Ivan", 25);
                //Person joro = new Person("ivan25"); // throw ArgumentException

                // print information if age is not specified
                Console.WriteLine(pesho);

                // print information if age is specified
                Console.WriteLine(vankata);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}