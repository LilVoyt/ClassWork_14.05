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
        public UniversityList()
        {
            Universities = new List<University>();
            FillLists.GetUniversities(Universities);
        }
    }
}
