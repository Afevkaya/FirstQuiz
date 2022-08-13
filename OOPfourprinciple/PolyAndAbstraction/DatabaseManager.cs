using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPfourprinciple.PolyAndAbstraction
{
    internal class DatabaseManager
    {
        private IDal _dal;

        public DatabaseManager(IDal dal)
        {
            _dal = dal;
        }

        public void Add()
        {
            _dal.Add();
        }

        public void Update()
        {
            _dal.Update();
        }

        public void Remove()
        {
            _dal.Remove();
        }
    }
}
