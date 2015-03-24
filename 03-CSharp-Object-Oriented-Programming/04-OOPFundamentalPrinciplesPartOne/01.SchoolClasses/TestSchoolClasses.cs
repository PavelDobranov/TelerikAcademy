// Problem 1. School classes
// We are given a school. In the school there are classes of students. Each class has a set of teachers.
// Each teacher teaches a set of disciplines. Students have name and unique class number.
// Classes have unique text identifier. Teachers have name. Disciplines have name, number of 
// lectures and number of exercises. Both teachers and students are people. Students, classes, 
// Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
// encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace SchoolClasses
{
    using System;

    using SchoolClasses.Humans;

    public static class TestSchoolClasses
    {
        public static void Main()
        {
            var student = new Student("Martin", "Ivanov", 3);

            Console.WriteLine("------------");
            Console.WriteLine("Test Student");
            Console.WriteLine("------------");
            Console.WriteLine(student);

            var discipline = new Discipline("Philosophy", 5, 3);

            Console.WriteLine("---------------");
            Console.WriteLine("Test Discipline");
            Console.WriteLine("---------------");
            Console.WriteLine(discipline);

            var teacher = new Teacher("Angel", "Stoyanov");
            teacher.AddDiscipline(new Discipline("Mathematics", 3, 2));
            teacher.AddDiscipline(new Discipline("Physics", 4, 2));
            teacher.AddDiscipline(new Discipline("Computer science", 2, 4));

            Console.WriteLine("------------");
            Console.WriteLine("Test Teacher");
            Console.WriteLine("------------");
            Console.WriteLine(teacher);

            var schoolClass = new Class("8A");
            schoolClass.AddTeacher(new Teacher("Angel", "Stoyanov"));
            schoolClass.AddTeacher(new Teacher("Stefan", "Ganev"));
            schoolClass.AddTeacher(new Teacher("Mihail", "Popov"));

            Console.WriteLine("----------");
            Console.WriteLine("Test Class");
            Console.WriteLine("----------");
            Console.WriteLine(schoolClass);
        }
    }
}
