namespace DataRepository
{
    using System.Collections.Generic;

    public static class StudentsData
    {
        private static ICollection<Student> students;

        static StudentsData()
        {
            StudentsData.students = new List<Student>();
            StudentsData.InitStudents();
        }

        public static ICollection<Student> GetStudents()
        {
            return new List<Student>(StudentsData.students);
        }

        private static void InitStudents()
        {
            var daniela = new Student("Daniela", "Ivanova", 17, "A21406", "+359888146237", "daniela.ivanova@abv.bg", 3);
            daniela.AddMark(6);
            daniela.AddMark(5);
            daniela.AddMark(5);

            var stefka = new Student("Stefka", "Ruseva", 22, "C03504", "+359887124336", "stefka.ruseva@gmail.com", 5);
            stefka.AddMark(4);
            stefka.AddMark(2);
            stefka.AddMark(4);

            var ivan = new Student("Ivan", "Bernardov", 26, "B52205", "+35927457801", "ivan.bernardov@gmail.com", 2);
            ivan.AddMark(6);
            ivan.AddMark(4);
            ivan.AddMark(5);

            var stefan = new Student("Stefan", "Ganev", 19, "A34106", "+359883214516", "stefan.ganev@yahoo.com", 4);
            stefan.AddMark(4);
            stefan.AddMark(2);
            stefan.AddMark(2);

            var anatoli = new Student("Anatoli", "Vrichev", 24, "A59303", "+359288098725", "anatoli.vrichev@abv.bg", 3);
            anatoli.AddMark(5);
            anatoli.AddMark(6);
            anatoli.AddMark(6);

            var boris = new Student("Boris", "Antonov", 27, "B23902", "+359527002300", "boris.antonov@abv.bg", 2);
            boris.AddMark(2);
            boris.AddMark(2);

            StudentsData.students.Add(daniela);
            StudentsData.students.Add(stefka);
            StudentsData.students.Add(ivan);
            StudentsData.students.Add(stefan);
            StudentsData.students.Add(anatoli);
            StudentsData.students.Add(boris);
        }
    }
}