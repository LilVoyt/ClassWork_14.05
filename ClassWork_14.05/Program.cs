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
            Console.WriteLine(studentsList.SelectAllStudent());
            Console.WriteLine(studentsList.SelectStudentsUniversities("Harvard"));
            Console.WriteLine(studentsList.SelectByName("B"));
        }
    }
}
