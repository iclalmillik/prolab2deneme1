using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2_1.deneme
{

    public abstract class User : ILoginable
    {
        public string Kullanıcı { get; private set; }
        public string Sifre { get; private set; }

        public abstract void Login();
    }
}