using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    class Hasta : Kisi
    {
        private decimal yas;
        private decimal boy;
        private int kilo;
        private String cinsiyet;
        public Hastalik hastalik;

        public decimal Yas
        {
            get { return yas; }
            set { yas = value; }
        }
        public decimal Boy
        {
            get { return boy; }
            set { boy = value; }
        }
        public int Kilo
        {
            get { return kilo; }
            set { kilo = value; }
        }
        public String Cinsiyet
        {
            get
            { return cinsiyet; }
            set { cinsiyet = value; }
        }
    }
}
