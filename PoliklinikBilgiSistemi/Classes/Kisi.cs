using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    abstract class Kisi
    {
        private String isim;
        private String soyisim;
        private decimal telNO;
        private decimal tc;

        public String Isim { get { return isim; } set { isim = value; } }
        public String Soyisim { get { return soyisim; } set { soyisim = value; } }
        public decimal TelNo { get { return telNO; } set { telNO = value; } }
        public decimal Tc { get { return tc; } set { tc = value; } }


    }
}
