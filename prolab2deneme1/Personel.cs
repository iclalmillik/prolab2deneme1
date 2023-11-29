using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2_1.deneme
{
    class Personel : Person
    {
        public override string isim { get; set; }
        public override string soyisim { get; set; }
        public override string cinsiyet { get; set; }
        public float Ucret { get; set; }
        public Personel(string isim, string Soyisim, string Cinsiyet, float Ucret)
            : base(isim, Soyisim, Cinsiyet)
        {
            this.isim = isim;
            this.soyisim = Soyisim;
            this.cinsiyet = Cinsiyet;
            this.Ucret = Ucret;
        }


        public new virtual void BilgileriGoster()
        {
            Console.WriteLine("***** İnsanların Bilgileri *****");
            Console.WriteLine($"İsim: {isim}");
            Console.WriteLine($"Soyisim: {soyisim}");
            Console.WriteLine($"Cinsiyet: {cinsiyet}");
            Console.WriteLine("Ucreti: {ucret}");
        }


    }

}
