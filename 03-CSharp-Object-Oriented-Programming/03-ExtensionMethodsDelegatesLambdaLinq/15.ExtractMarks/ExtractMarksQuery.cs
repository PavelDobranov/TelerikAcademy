// Problem 15. Extract marks
// Extract all Marks of the students that enrolled in 2006.
// (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

namespace ExtractMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataRepository;
    using IEnumerableExtensions;

    public static class ExtractMarksQuery
    {
        public static void Main()
        {
            var students = StudentsData.GetStudents();

            Console.WriteLine("------------");
            Console.WriteLine("All students");
            Console.WriteLine("------------");

            students.ForEach(PrintStudentInfo);

            var result = students
                            .Where(st => st.FacultyNumber[4] == '0' && st.FacultyNumber[5] == '6')
                            .ToList();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("All marks of the students that enrolled in 2006");
            Console.WriteLine("-----------------------------------------------");

            result.ForEach(PrintStudentInfo);
        }

        private static void PrintStudentInfo(Student student)
        {
            Console.WriteLine(student);
            Console.WriteLine("Marks: {0}\n", string.Join(", ", student.Marks));
        }
    }
}