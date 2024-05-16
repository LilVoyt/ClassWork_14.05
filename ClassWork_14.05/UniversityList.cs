using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class UniversityList
    {
        public List<University> Universities { get; set; }
        public int UniversitiesNumber { get; set; }
        public UniversityList()
        {
            Universities = new List<University>();
            UniversitiesNumber = Universities.Count;
            FillLists.GetUniversities(Universities);
        }
    }
}
