using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi
{
    interface IHastaKayitIslemi
    {
        void hastaKayidEt(String ad, String soyad, decimal tc, String cins, decimal yas, decimal boy, int kilo, String tani, String ilac, String tahlil, int ucret);
       
    }
}
