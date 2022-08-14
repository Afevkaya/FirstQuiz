using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class DatabaseManager
    {
        private readonly IDal _dal;

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

        public void Delete()
        {
            _dal.Delete();
        }




        /*SqlDal sqlDal = new SqlDal();
        OracleDal oracleDal = new OracleDal();*/
        /*public void AddSql()
        {
            sqlDal.Add();
        }

        public void UpdateSql()
        {
            sqlDal.Update();
        }

        public void DeleteSql()
        {
            sqlDal.Delete();
        }

        public void AddOracle()
        {
            oracleDal.Add();
        }

        public void UpdateOracle()
        {
            oracleDal.Update();
        }

        public void DeleteOracle()
        {
            oracleDal.Delete();
        }*/


    }
}
