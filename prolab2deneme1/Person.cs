using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prolab2_1.deneme
{
    abstract class Person
    {
        private string Isim;
        private string Soyisim;
        private string Cinsiyet;

        public Person(string Isim, string Soyisim, string Cinsiyet)
        {
            this.Isim = Isim;
            this.Soyisim = Soyisim;
            this.Cinsiyet = Cinsiyet;
        }
        public abstract string isim { get; set; }
        public abstract string soyisim { get; set; }

        public abstract string cinsiyet { get; set; }


        public void BilgileriGoster()
        {
            Console.WriteLine("****insanlarin bilgileri****");
            Console.WriteLine("$isim: {isim}");
            Console.WriteLine("$soyisim: {soyisim}");
            Console.WriteLine("$cinsiyet: {cinsiyet}");
        }
    }
}