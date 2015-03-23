// Problem 5. Order students
// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
// Rewrite the same with LINQ.

namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class OrderStudentsQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            // Lambda
            var result = students.OrderByDescending(st => st.FirstName)
                                 .ThenByDescending(st => st.LastName);

            // Linq query
            //var result = from student in students
            //             orderby student.FirstName descending, student.LastName descending
            //             select student;

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Sorted students by first name and last name in descending order");
            Console.WriteLine("---------------------------------------------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}