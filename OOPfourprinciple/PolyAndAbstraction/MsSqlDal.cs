using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPfourprinciple.PolyAndAbstraction;

namespace OOPfourprinciple
{
    internal class MsSqlDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Add to Sql database");
        }

        public void Update()
        {
            Console.WriteLine("Update to Sql database ");
        }

        public void Remove()
        {
            Console.WriteLine("Delete to Sql database");
        }
    }
}
