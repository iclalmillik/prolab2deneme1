using prolab2deneme1;
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
        public string firmaIsim { get; set; }

        public override string ToString()
        {
            return firmaIsim;
        }
        /* Firma Afirmasi = new Firma();
         Firma Bfirmasi = new Firma();
         Firma Cfirasi = new Firma();
         Firma Dfirmasi = new Firma();
         Firma Ffirmasi = new Firma();
         List<Firma> firmaList;
        */
        public Firma(string firmaIsim)
        {
            //firmaList.Add(new Firma());
            this.firmaIsim = firmaIsim;

        }
        public void firmalariGoruntule()
        {
            Console.WriteLine("$Firmalar: {firmaList}");
        }
        public void firmaSil(Firma firma)
        {
            //firmaList.Remove(firma);
        }
        public void firmaEkle(Firma firma)
        {
            //firmaList.Add(firma);
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

        internal void firmaEkle(object txtveri)
        {
            throw new NotImplementedException();
        }

        internal void firmaEkle()
        {
            throw new NotImplementedException();
        }
    }
}