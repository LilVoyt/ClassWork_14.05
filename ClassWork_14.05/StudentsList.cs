using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class StudentsList
    {
        public List<Student> Students { get; set; }
        public int StudentsNumber { get; set; }
        public StudentsList()
        {
            Students = new List<Student>()
            {
                new Student("Alice", "Smith", new DateTime(2000, 1, 1), "MIT", 4.5),
                new Student("Bob", "Johnson", new DateTime(2001, 2, 2), "Harvard", 4.2),
                new Student("Charlie", "Brown", new DateTime(2002, 3, 3), "Stanford", 4.0),
                new Student("John", "Doe", new DateTime(1999, 5, 15), "MIT", 3.8),
                new Student("Emily", "Smith", new DateTime(2000, 3, 20), "Harvard", 4.2),
                new Student("Michael", "Johnson", new DateTime(1998, 7, 10), "Stanford", 3.9),
                new Student("Sophia", "Brown", new DateTime(2001, 1, 5), "Oxford", 4.5),
                new Student("Daniel", "Wilson", new DateTime(2000, 9, 25), "Cambridge", 3.7),
                new Student("Olivia", "Clark", new DateTime(1999, 11, 8), "Princeton", 4.0),
                new Student("Ethan", "Lee", new DateTime(1998, 4, 30), "Yale", 3.6),
                new Student("Emma", "Young", new DateTime(2001, 6, 12), "Caltech", 4.1),
                new Student("William", "Hall", new DateTime(1997, 8, 18), "MIT", 3.9),
                new Student("Ava", "Taylor", new DateTime(2000, 2, 28), "Harvard", 4.3),
                new Student("James", "Martin", new DateTime(1999, 10, 3), "Stanford", 4.0),
                new Student("Isabella", "White", new DateTime(2001, 4, 17), "Oxford", 3.8),
                new Student("Alexander", "Anderson", new DateTime(2000, 12, 22), "Cambridge", 4.4),
                new Student("Mia", "Brown", new DateTime(1998, 6, 7), "Princeton", 3.5),
                new Student("Benjamin", "Jones", new DateTime(1999, 9, 9), "Yale", 4.2)
            };
            StudentsNumber = Students.Count;
        }
        
        public string SelectAllStudent()
        {
            var Arr = Students.OrderBy(i => i.LastName).ToList();

            string res = "";
            foreach (Student student in Arr)
            {
                res += $"{student.FirstName} {student.LastName} \n";
            }


            return res;
        }

        public string SelectStudentsUniversities(string university)
        {
            List<Student> Arr = Students.Where(i => i.UniversityName == university).ToList();
            string res = "";

            foreach (Student student in Arr)
            {
                res += $"{student.FirstName}, {student.LastName}, {student.UniversityName} \n";
            }

            WriteToFile(Arr, $"{university}_Students.txt");

            return res;
        }

        public string SelectByName(string syb)
        {
            List<Student> Arr = Students.Where(i => i.FirstName.StartsWith(syb)).ToList();
            string res = "";

            foreach (Student student in Arr)
            {
                res += $"{student.FirstName} {student.LastName} \n";
            }

            WriteToFile(Arr, $"NamesStartsWith-{syb}.txt");

            return res;

        }

        public static void WriteToFile(List<Student> students, string path)
        {
            string json = JsonConvert.SerializeObject(students);
            using(StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(json);
            }
        }
        public static List<Student> ReadFromFile(string path)
        {
            List<Student> students = new List<Student>();
            using (StreamReader sr = new StreamReader(path))
            {
                students = JsonConvert.DeserializeObject<List<Student>>(sr.ReadToEnd());
            }
            return students;
        }
    }
}
