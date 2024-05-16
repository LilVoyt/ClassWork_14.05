using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_14._05
{
    internal class University
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public University(int ID, string name, string location)
        {
            this.ID = ID;
            this.Name = name;
            this.Location = location;
        }
    }
}
