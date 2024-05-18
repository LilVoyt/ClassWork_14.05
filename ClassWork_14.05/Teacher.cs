using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Department { get; set; }
        public int UniversityID { get; set; }
        public double Rating { get; set; }
        public Teacher(string firstName, string lastName, DateTime birthDay, string department, int universityID, double rating)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Department = department;
            UniversityID = universityID;
            Rating = rating;
        }
    }
}
