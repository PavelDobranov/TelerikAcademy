// Problem 13. Extract students by marks
// Select all students that have at least one mark Excellent (6) into a new anonymous class
// that has properties – FullName and Marks.
// Use LINQ.

namespace ExtractStudentsByMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class StudentsByMarksQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(PrintStudentInfo);

            int mark = 6;

            // Linq query
            var result = from student in students
                         where student.Marks.Contains(mark)
                         select new
                         {
                             FullName = student.FirstName + " " + student.LastName,
                             Marks = student.Marks
                         };

            // Lambda
            //var result = students.Where(st => st.Marks.Contains(mark))
            //                     .Select(st =>
            //                     {
            //                         return new
            //                         {
            //                             FullName = st.FirstName + " " + st.LastName,
            //                             Marks = st.Marks
            //                         };
            //                     });

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Students that have at least one mark Excellent (6)");
            Console.WriteLine("--------------------------------------------------");

            result.ForEach(st => Console.WriteLine("{0}, Marks {1}", st.FullName, string.Join(", ", st.Marks)));
        }

        private static void PrintStudentInfo(Student student)
        {
            Console.WriteLine(student);
            Console.WriteLine("Marks: {0}\n", string.Join(", ", student.Marks));
        }
    }
}