using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOPfourprinciple
{
    internal class Student : Person
    {
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{TCNo} - {Name} - {Surname} - {Department}";
        }
    }


}
