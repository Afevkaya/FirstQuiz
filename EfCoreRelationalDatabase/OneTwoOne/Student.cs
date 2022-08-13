using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreRelationalDatabase.ManyToMany;

namespace EfCoreRelationalDatabase.OneTwoOne
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public ICollection<Course> Courses { get; set; }


    }
}
