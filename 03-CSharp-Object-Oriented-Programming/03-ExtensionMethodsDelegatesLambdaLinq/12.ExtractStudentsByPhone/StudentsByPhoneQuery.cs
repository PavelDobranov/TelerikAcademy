// Problem 12. Extract students by phone
// Extract all students with phones in Sofia.
// Use LINQ.

namespace ExtractStudentsByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class StudentsByPhoneQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(Console.WriteLine);

            string sofiaCode = "+3592";

            // Linq query
            var result = from student in students
                         where student.Phone.Contains(sofiaCode)
                         select student;

            // Lambda
            //var result = students.Where(st => st.Phone.Contains(sofiaCode));

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Students with phones in Sofia");
            Console.WriteLine("-----------------------------");

            result.ForEach(Console.WriteLine);
        }
    }
}