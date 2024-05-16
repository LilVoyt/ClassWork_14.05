using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public double AvgGrade { get; set; }
        public int UniversityID { get; set; }

        public Student(string firstName, string lastName, DateTime birthDay, double avgGrade, int universityID)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            AvgGrade = avgGrade;
            UniversityID = universityID;
        }
    }
}
