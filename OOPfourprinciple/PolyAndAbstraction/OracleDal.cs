using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPfourprinciple.PolyAndAbstraction;

namespace OOPfourprinciple
{
    internal class OracleDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Add to Oracle database");
        }

        public void Update()
        {
            Console.WriteLine("Update to Oracle database ");
        }

        public void Remove()
        {
            Console.WriteLine("Delete to Oracle database");
        }
    }
}
