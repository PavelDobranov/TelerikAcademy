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
    using System.Linq;

    using SchoolClasses.Humans;
    using SchoolClasses.Interfaces;
    using System.Collections.Generic;

    public static class TestSchoolClasses
    {
        public static void Main()
        {
            // students
            var anqVeleva = new Student("Anq", "Veleva", 1);
            var kaloyanGeorgiev = new Student("Kaloyan", "Georgiev", 2);
            var martinIvanov = new Student("Martin", "Ivanov", 3);
            var rosenStefanov = new Student("Rosen", "Stefanov", 4);
            var boryanaIvanova = new Student("Boryana", "Ivanova", 1);
            var daniaelaKoleva = new Student("Daniela", "Koleva", 2);
            var spasRusev = new Student("Spas", "Rusev", 3);
            var milenaYordanova = new Student("Milena", "Yordanova", 4);

            // disciplines
            var mathematics = new Discipline("Mathematics", 3, 2);
            var physics = new Discipline("Physics", 4, 2);
            var biology = new Discipline("Biology", 4, 4);
            var chemistry = new Discipline("Chemistry", 2, 4);
            var history = new Discipline("History", 4, 1);
            var computerScience = new Discipline("Computer science", 2, 4);
            var sport = new Discipline("Sport", 1, 5);

            // teachers
            var angelStoyanov = new Teacher("Angel", "Stoyanov");
            angelStoyanov.AddDiscipline(mathematics);

            var ivelinaGeorgieva = new Teacher("Ivelina", "Georgieva");
            ivelinaGeorgieva.AddDiscipline(physics);

            var stefanGanev = new Teacher("Stefan", "Ganev");
            stefanGanev.AddDiscipline(biology);
            stefanGanev.AddDiscipline(chemistry);

            var snejanaTrifonova = new Teacher("Snejana", "Trifonova");
            snejanaTrifonova.AddDiscipline(history);

            var nikolayDelchev = new Teacher("Nikolay", "Delchev");
            nikolayDelchev.AddDiscipline(computerScience);

            var petarBogdanov = new Teacher("Petar", "Bogdanov");
            petarBogdanov.AddDiscipline(sport);

            var allTeachers = new List<IHuman>() 
            {
                angelStoyanov, 
                ivelinaGeorgieva, 
                stefanGanev, 
                nikolayDelchev, 
                petarBogdanov 
            };

            // classes
            var firstClassStudents = new List<IHuman>() 
            { 
                anqVeleva,
                kaloyanGeorgiev,
                martinIvanov,
                rosenStefanov
            };

            var firstClass = new Class("8A", firstClassStudents);
            firstClass.AddHumans(allTeachers);

            var secondClassStudents = new List<IHuman>() 
            { 
                boryanaIvanova,
                daniaelaKoleva,
                spasRusev,
                milenaYordanova
            };

            var secondClass = new Class("8B", secondClassStudents);
            secondClass.AddHumans(allTeachers);

            var allClasses = new List<IClass>() { firstClass, secondClass };

            // school
            var school = new School("141 SOU", allClasses);

            Console.WriteLine("------------");
            Console.WriteLine("Test Student");
            Console.WriteLine("------------");
            Console.WriteLine(anqVeleva);

            Console.WriteLine("---------------");
            Console.WriteLine("Test Discipline");
            Console.WriteLine("---------------");
            Console.WriteLine(mathematics);

            Console.WriteLine("------------");
            Console.WriteLine("Test Teacher");
            Console.WriteLine("------------");
            Console.WriteLine(stefanGanev);

            Console.WriteLine("----------");
            Console.WriteLine("Test Class");
            Console.WriteLine("----------");
            PrintSchoolClass(firstClass);

            Console.WriteLine("-----------");
            Console.WriteLine("Test School");
            Console.WriteLine("-----------");
            PrintSchool(school);
        }

        private static void PrintSchoolClass(IClass schoolClass)
        {
            var teachers = schoolClass.Humans.Where(h => h.GetType() == typeof(Teacher)).ToList();
            var students = schoolClass.Humans.Where(h => h.GetType() == typeof(Student)).ToList();

            Console.WriteLine(schoolClass.ToString());
            Console.WriteLine("\nTeachers:");
            Console.WriteLine("~~~~~~~~~");
            PrintHumansCollection(teachers);
            Console.WriteLine("\nStudents:");
            Console.WriteLine("~~~~~~~~~");
            PrintHumansCollection(students);
        }

        private static void PrintSchool(ISchool school)
        {
            Console.WriteLine(school.ToString());

            Console.WriteLine("\nClasses:");
            Console.WriteLine("~~~~~~~~");

            foreach (var schoolClass in school.Classes)
            {
                PrintSchoolClass(schoolClass);
            }
        }

        private static void PrintHumansCollection(ICollection<IHuman> humans)
        {
            foreach (var human in humans)
            {
                Console.WriteLine(human);
                Console.WriteLine();
            }
        }
    }
}