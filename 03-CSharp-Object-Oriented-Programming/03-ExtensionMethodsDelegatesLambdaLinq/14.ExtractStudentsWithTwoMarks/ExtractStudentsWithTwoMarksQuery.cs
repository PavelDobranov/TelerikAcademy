// Problem 14. Extract students with two marks
// Write down a similar program that extracts the students with exactly two marks "2".
// Use extension methods.

namespace ExtractStudentsWithTwoMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class ExtractStudentsWithTwoMarksQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(PrintStudentInfo);

            int mark = 2;
            int markCount = 2;

            var result = students
                            .Where(st => st.Marks.Where(m => m == mark).Count() == markCount)
                            .ToList();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Students that have exactly two marks (2)");
            Console.WriteLine("----------------------------------------");

            result.ForEach(PrintStudentInfo);
        }

        private static void PrintStudentInfo(Student student)
        {
            Console.WriteLine(student);
            Console.WriteLine("Marks: {0}\n", string.Join(", ", student.Marks));
        }
    }
}