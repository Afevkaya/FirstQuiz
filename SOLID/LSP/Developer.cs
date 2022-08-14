using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal abstract class Developer
    {
        public abstract void ProjeGelistir();
        //public abstract void SolidPrensipleriniUygula();
    }

    internal interface ISeniorDeveloper
    {
        public abstract void SolidPrensipleriniUygula();
    }

    internal class SeniorDeveloper : Developer, ISeniorDeveloper
    {
        public override void ProjeGelistir()
        {
            Console.WriteLine("Proje geliştiriliyor.");
        }

        public void SolidPrensipleriniUygula()
        {
            Console.WriteLine("Solid prensipleri uygulanıyor");
        }
    }

    internal class JuniorDeveloper : Developer
    {
        public override void ProjeGelistir()
        {
            Console.WriteLine("Proje geliştiriliyor.");
        }

        /*public override void SolidPrensipleriniUygula()
        {
            Console.WriteLine("Solid prensipleri uygulanıyor");
        }*/
    }
}
