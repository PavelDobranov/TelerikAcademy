// Problem 3. First before last
// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class FirstBeforeLastQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            // Linq query
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;

            // Lambda
            // var result = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);

            Console.WriteLine("----------------------");
            Console.WriteLine("First name before last");
            Console.WriteLine("----------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}