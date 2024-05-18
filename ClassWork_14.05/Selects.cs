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
    }
}
