using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPfourprinciple
{
    //Encapsulation
    internal class Customer
    {
        private string _name;
        private string _surName;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                    _name = "Ahmet";
                else
                    _name = value;
            }
        }

        public string SurName
        {
            get { return _surName; }
            set
            {
                if (value == null)
                    _surName = "Evkaya";
                else
                    _surName = value;
            }
        }

        public override string ToString()
        {
            return $"{_name} - {_surName}";
        }
    }
}
