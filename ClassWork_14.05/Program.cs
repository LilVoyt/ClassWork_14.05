using System;
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
            UniversityList universityList = new UniversityList();
            Selects.JoinStudUni(studentsList.Students, universityList.Universities, "Harvard University");
            Selects.SelectTop(studentsList.Students, 4);
        }
    }
}
