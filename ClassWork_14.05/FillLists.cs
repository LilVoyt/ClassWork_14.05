using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class FillLists
    {
        public static void FillStudents(List<Student> students)
        {
            students.Add(new Student("Alice", "Smith", new DateTime(2000, 1, 1), 4.5, 1));
            students.Add(new Student("Bob", "Johnson", new DateTime(2001, 2, 2), 4.2, 2));
            students.Add(new Student("Charlie", "Brown", new DateTime(2002, 3, 3), 4.0, 3));
            students.Add(new Student("John", "Doe", new DateTime(1999, 5, 15), 3.8, 1));
            students.Add(new Student("Emily", "Smith", new DateTime(2000, 3, 20), 4.2, 3));
            students.Add(new Student("Michael", "Johnson", new DateTime(1998, 7, 10), 3.9, 2));
            students.Add(new Student("Sophia", "Brown", new DateTime(2001, 1, 5), 4.5, 1));
            students.Add(new Student("Daniel", "Wilson", new DateTime(2000, 9, 25), 3.7, 2));
            students.Add(new Student("Olivia", "Clark", new DateTime(1999, 11, 8), 4.0, 3));
            students.Add(new Student("Ethan", "Lee", new DateTime(1998, 4, 30), 3.6, 4));
            students.Add(new Student("Emma", "Young", new DateTime(2001, 6, 12), 4.1, 1));
            students.Add(new Student("William", "Hall", new DateTime(1997, 8, 18), 3.9, 2));
            students.Add(new Student("Ava", "Taylor", new DateTime(2000, 2, 28), 4.3, 2));
            students.Add(new Student("James", "Martin", new DateTime(1999, 10, 3), 4.0, 2));
            students.Add(new Student("Isabella", "White", new DateTime(2001, 4, 17), 3.8, 4));
            students.Add(new Student("Alexander", "Anderson", new DateTime(2000, 12, 22), 4.4, 2));
            students.Add(new Student("Mia", "Brown", new DateTime(1998, 6, 7), 3.5, 3));
            students.Add(new Student("Benjamin", "Jones", new DateTime(1999, 9, 9), 4.2, 4));
        }

        public static void GetUniversities(List<University> universities)
        {
            universities.Add(new University(1, "Harvard University", "Cambridge"));
            universities.Add(new University(2, "Massachusetts Institute of Technology (MIT)", "Cambridge"));
            universities.Add(new University(3, "Stanford University", "Stanford"));
            universities.Add(new University(4, "California Institute of Technology (Caltech)", "Pasadena"));
            universities.Add(new University(5, "University of Oxford", "Oxford"));
        }
        public static void FillTeachers(List<Teacher> teachers)
        {
            teachers.Add(new Teacher("Alice", "Smith", new DateTime(1975, 1, 1), "Mathematics", 1, 4.5));
            teachers.Add(new Teacher("Bob", "Johnson", new DateTime(1980, 2, 2), "Physics", 2, 4.2));
            teachers.Add(new Teacher("Charlie", "Brown", new DateTime(1978, 3, 3), "Chemistry", 3, 4.0));
            teachers.Add(new Teacher("John", "Doe", new DateTime(1979, 5, 15), "Biology", 1, 3.8));
            teachers.Add(new Teacher("Emily", "Smith", new DateTime(1981, 3, 20), "History", 3, 4.2));
            teachers.Add(new Teacher("Michael", "Johnson", new DateTime(1977, 7, 10), "Computer Science", 2, 3.9));
            teachers.Add(new Teacher("Sophia", "Brown", new DateTime(1982, 1, 5), "Economics", 1, 4.5));
            teachers.Add(new Teacher("Daniel", "Wilson", new DateTime(1980, 9, 25), "Literature", 2, 3.7));
            teachers.Add(new Teacher("Olivia", "Clark", new DateTime(1979, 11, 8), "Philosophy", 3, 4.0));
            teachers.Add(new Teacher("Ethan", "Lee", new DateTime(1978, 4, 30), "Art", 4, 3.6));
            teachers.Add(new Teacher("Emma", "Young", new DateTime(1981, 6, 12), "Music", 1, 4.1));
            teachers.Add(new Teacher("William", "Hall", new DateTime(1976, 8, 18), "Engineering", 2, 3.9));
            teachers.Add(new Teacher("Ava", "Taylor", new DateTime(1980, 2, 28), "Law", 2, 4.3));
            teachers.Add(new Teacher("James", "Martin", new DateTime(1979, 10, 3), "Medicine", 2, 4.0));
            teachers.Add(new Teacher("Isabella", "White", new DateTime(1981, 4, 17), "Psychology", 4, 3.8));
            teachers.Add(new Teacher("Alexander", "Anderson", new DateTime(1980, 12, 22), "Physics", 2, 4.4));
            teachers.Add(new Teacher("Mia", "Brown", new DateTime(1978, 6, 7), "Chemistry", 3, 3.5));
            teachers.Add(new Teacher("Benjamin", "Jones", new DateTime(1979, 9, 9), "Mathematics", 4, 4.2));
        }
    }
}
