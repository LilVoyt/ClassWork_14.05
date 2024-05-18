using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class TeacherList : UniversityPeople
    {
        public List<Teacher> list { get; set; }
        public TeacherList()
        {
            list = new List<Teacher>();
            FillLists.FillTeachers(list);
        }

        public override void JoinByName(List<University> universities, string Name)
        {
            var res = this.list.Join(universities,
                teacher => teacher.UniversityID,
                university => university.ID,
                (teacher, university) => new
                {
                    UniversityName = university.Name,
                    TeacherName = string.Format($"{teacher.FirstName} {teacher.LastName}"),
                    TeacherRating = teacher.Rating
                }).Where(university => university.UniversityName == Name).
                OrderByDescending(teacher => teacher.TeacherRating);
            foreach (var i in res)
            {
                Console.WriteLine($"{i.UniversityName} => {i.TeacherName}, {i.TeacherRating}");
            }

            using(StreamWriter sw = new StreamWriter($"{Name}_teacher.txt"))
            {
                string json = JsonConvert.SerializeObject(res);
                sw.WriteLine(json);
            }
        }
    }
}
