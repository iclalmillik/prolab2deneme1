using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2_1.deneme
{
    public class Interfaces
    {
        public interface ILoginable
        {
            void Login();
        }

        public interface IProfitable
        {
            void GunlukKar();
            void GunlukZarar();
        }
    }
}