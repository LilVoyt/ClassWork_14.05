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
        public static void JoinByName(ListToSelect listToSelect, List<University> universities, string Name)
        {
            listToSelect.JoinByName(universities, Name);
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
