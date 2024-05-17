using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class Selects
    {
        public static void JoinStudUni(List<Student> students, List<University> universities, string UniName)
        {
            var res = students.Join(universities,
                student => student.UniversityID,
                university => university.ID,
                (student, university) => new
                {
                    UniversityName = string.Format($"{university.Name}"),
                    StudentName = string.Format($"{student.FirstName} {student.LastName}"),
                    Grade = string.Format($"Grade: {student.AvgGrade}")
                }
                ).Where(university => university.UniversityName == UniName);
            foreach(var i in res)
            {
                Console.WriteLine($"{i.UniversityName} => {i.StudentName}, {i.Grade}");
            }

            using(StreamWriter sw = new StreamWriter($"{UniName}.txt"))
            {
                string json = JsonConvert.SerializeObject(res);
                sw.WriteLine(json);
            }
        }

        public static void SelectTop(List<Student> students, int number)
        {
            var res = students.OrderByDescending(student => student.AvgGrade).Take(number);

            foreach(var student in res)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.AvgGrade}");
            }
        }
    }
}
