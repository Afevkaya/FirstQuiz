using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{

    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        //public TypeFile TypeFile { get; set; }
    }

    internal abstract class File
    {
        public abstract void AddToFile(User user);
    }

    internal class TxtFile: File
    {
        public override void AddToFile(User user)
        {
            Console.WriteLine("User txt uzantılı dosyaya kaydedildi.");
        }
    }

    internal class CsvFile : File
    {
        public override void AddToFile(User user)
        {
            Console.WriteLine("User csv uzantılı dosyaya kaydedildi.");
        }
    }

    internal class XlsFile: File
    {
        public override void AddToFile(User user)
        {
            Console.WriteLine("User xls uzantılı dosyaya kaydedildi.");
        }
    }

    /*internal class File
    {
        public void AddToFile(User user)
        {
            if (user.TypeFile == TypeFile.csv)
            {
                Console.WriteLine("Kullanıcı csv uzantılı dosyaya kaydedildi");
            }

            if (user.TypeFile == TypeFile.txt)
            {
                Console.WriteLine("Kullanıcı txt uzantılı dosyaya kaydedildi");
            }

            if (user.TypeFile == TypeFile.xls)
            {
                Console.WriteLine("Kullanıcı xls uzantılı dosyaya kaydedildi");
            }
        }
    }


    enum TypeFile
    {
        txt,
        xls,
        csv
    }*/
}
