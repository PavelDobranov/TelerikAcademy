// Problem 11. Extract students by email
// Extract all students that have email in abv.bg.
// Use string methods and LINQ.

namespace ExtractStudentsByEmail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class StudentsByEmailQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            string domain = "abv.bg";

            // Linq query
            var result = from student in students
                         where student.Email.Contains(domain)
                         select student;

            // Lambda
            //var result = students.Where(st => st.Email.Contains(domain));

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Students that have email in {0}", domain);
            Console.WriteLine("----------------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}