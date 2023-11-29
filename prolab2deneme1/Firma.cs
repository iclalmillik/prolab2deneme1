using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prolab2_1.deneme.Interfaces;

namespace Prolab2_1.deneme
{
    public class Firma : User, IProfitable
    {
        public float hizmetBedeli { get; private set; }

        Firma Afirmasi = new Firma();
        Firma Bfirmasi = new Firma();
        Firma Cfirasi = new Firma();
        Firma Dfirmasi = new Firma();
        Firma Ffirmasi = new Firma();

        List<Firma> firmaList = new List<Firma>();


        public Firma()
        {
            firmaList.Add(new Firma());
            this.hizmetBedeli = hizmetBedeli;
        }
        public void firmalariGoruntule()
        {
            Console.WriteLine("$Firmalar: {firmaList}");
        }
        public void firmaSil(Firma firma)
        {
            firmaList.Remove(firma);
        }
        public void firmaEkle(Firma firma)
        {
            firmaList.Add(firma);
        }

        public override void Login()
        {

        }

        public void GunlukKar()
        {

        }

        public void GunlukZarar()
        {

        }

    }
}