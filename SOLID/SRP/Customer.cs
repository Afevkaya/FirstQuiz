using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CreateCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri oluşturuldu");
        }

        /*public void AddToDb(Customer customer)
        {
            Console.WriteLine("Müşteri veritabanına eklendi");
        }*/
    }

    internal class Db
    {
        public void AddToDb(Customer customer)
        {
            Console.WriteLine("Müşteri veritabanına eklendi");
        }
    }
}
