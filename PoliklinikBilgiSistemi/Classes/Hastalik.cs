using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    class Hastalik
    {
        private String tani;
        private String ilac;
        private String tahlil;

        /*public Hastalik(String tani,String ilac,List<String> tahlil)
        {
            Tani = tani;
            Ilac = ilac;
            Tahlil = tahlil;
        }*/
        public String Tani
        {
            get { return tani; }
            set { tani = value; }
        }
        public String Ilac
        {
            get { return ilac; }
            set { ilac = value; }
        }
        public String Tahlil
        {
            get { return tahlil; }
            set { tahlil = value; }
        }
    }
}
