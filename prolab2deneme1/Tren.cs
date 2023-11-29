using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2_1.deneme
{
    class Tren : Araclar
    {

        public override float Id { get; set; }
        public override string YakitTuru { get; set; }
        public override int YolcuSayisi { get; set; }

        public Tren(float id, string yakit_turu, int yolcuSayisi)
            : base(yakit_turu, yolcuSayisi)
        {
            this.Id = id;
            this.YakitTuru = yakit_turu;
            this.YolcuSayisi = yolcuSayisi;
        }

        public new virtual void BilgileriGoster()
        {
            Console.WriteLine("*Tren Bilgileriniz*:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Yakıt Türü: {YakitTuru}");
            Console.WriteLine($"Yolcu Sayısı: {YolcuSayisi}");
        }

    }

}