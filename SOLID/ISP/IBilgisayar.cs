using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal interface IBilgisayar : IMacBook, IMicrosoft
    {
        //void IosProjeGeliştir();
        void Videoİzle();
        
        //void OyunOyna();
    }

    internal interface IMacBook
    {
        void IosProjeGeliştir();
    }

    internal interface IMicrosoft 
    {
        void OyunOyna();
    }

    internal class MacBookBilgisayar : IMacBook
    {
        public void IosProjeGeliştir()
        {
            Console.WriteLine("Ios proje geliştiriliyor");
        }

        public void Videoİzle()
        {
            Console.WriteLine("Video izleniyor");
        }

        /*public void OyunOyna()
        {
            Console.WriteLine("Oyun oynanıyor");
        }*/
    } 

    internal class MonsterBilgisayar : IMicrosoft
    {
        /*public void IosProjeGeliştir()
        {
            Console.WriteLine("Ios proje geliştiriliyor");
        }*/

        public void Videoİzle()
        {
            Console.WriteLine("Video izleniyor");
        }

        public void OyunOyna()
        {
            Console.WriteLine("Oyun oynanıyor");
        }
    }
}
