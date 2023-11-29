using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prolab2_1.deneme
{
    abstract class Araclar
    {
        private float id;
        private string yakit_turu;
        private int yolcu_sayisi;

        public Araclar(float id, string yakit_turu, int yolcu_sayisi)
        {
            this.id = id;
            this.yakit_turu = yakit_turu;
            this.yolcu_sayisi = yolcu_sayisi;

        }

        protected Araclar(string yakit_turu, int yolcuSayisi)
        {
            this.yakit_turu = yakit_turu;
            YolcuSayisi = yolcuSayisi;
        }

        public abstract float Id { get; set; }


        public abstract string YakitTuru { get; set; }


        public abstract int YolcuSayisi { get; set; }




        public void BilgileriGoster()
        {
            Console.WriteLine("*Araç Bilgileriniz*:");
            Console.WriteLine("$ID: {id}");
            Console.WriteLine("$Yakıt Türü: {yakit_turu}");
            Console.WriteLine("$Yolcu Sayısı: {yolcu_sayisi}");

        }



        public void yakitUcreti()
        {


        }
    }
}