using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPfourprinciple
{
    internal class Person
    {
        public string TCNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{TCNo} - {Name} - {Surname}";
        }
    }
}
