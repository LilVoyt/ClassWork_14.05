﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class Program
    {
        static void Main()
        {
            StudentsList studentsList = new StudentsList();
            TeacherList teacherList = new TeacherList();
            UniversityList universityList = new UniversityList();
            Selects.JoinByName(teacherList, universityList.Universities, "Harvard University");
        }
    }
}
