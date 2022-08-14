using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class SqlDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Add to SqlDatabase");
        }

        public void Update()
        {
            Console.WriteLine("Update to SqlDatabase");
        }

        public void Delete()
        {
            Console.WriteLine("Delete to SqlDatabase");
        }
    }

    internal class OracleDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Add to OracleDatabase");
        }

        public void Update()
        {
            Console.WriteLine("Update to OracleDatabase");
        }

        public void Delete()
        {
            Console.WriteLine("Delete to OracleDatabase");
        }
    }
}
