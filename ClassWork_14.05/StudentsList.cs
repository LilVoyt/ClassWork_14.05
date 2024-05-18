using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class StudentsList : UniversityPeople
    {
        public List<Student> list { get; set; }
        public StudentsList()
        {
            list = new List<Student>();
            FillLists.FillStudents(list);
        }
        
        public string SelectAllStudent()
        {
            var Arr = list.OrderBy(i => i.LastName).ToList();

            string res = "";
            foreach (Student student in Arr)
            {
                res += $"{student.FirstName} {student.LastName} \n";
            }


            return res;
        }
        public string SelectByName(string syb)
        {
            List<Student> Arr = list.Where(i => i.FirstName.StartsWith(syb)).ToList();
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

        public override void JoinByName(List<University> universities, string Name)
        {
            var res = this.list.Join(universities,
                student => student.UniversityID,
                university => university.ID,
                (student, university) => new
                {
                    UniversityName = string.Format($"{university.Name}"),
                    StudentName = string.Format($"{student.FirstName} {student.LastName}"),
                    Grade = string.Format($"Grade: {student.AvgGrade}")
                }
                ).Where(university => university.UniversityName == Name);
            foreach (var i in res)
            {
                Console.WriteLine($"{i.UniversityName} => {i.StudentName}, {i.Grade}");
            }

            using (StreamWriter sw = new StreamWriter($"{Name}_student.txt"))
            {
                string json = JsonConvert.SerializeObject(res);
                sw.WriteLine(json);
            }
        }
    }
}
