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
            Students = new List<Student>();
            StudentsNumber = Students.Count;
            FillLists.FillStudents(Students);
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

        //public string SelectStudentsUniversities(string university)
        //{
        //    List<Student> Arr = Students.Where(i => i.UniversityName == university).ToList();
        //    string res = "";

        //    foreach (Student student in Arr)
        //    {
        //        res += $"{student.FirstName}, {student.LastName}, {student.UniversityName} \n";
        //    }

        //    WriteToFile(Arr, $"{university}_Students.txt");

        //    return res;
        //}

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
