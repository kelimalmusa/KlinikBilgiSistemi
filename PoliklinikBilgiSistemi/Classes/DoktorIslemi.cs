using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    class DoktorIslemi : Islem
    {
        public bool doktorArama(decimal TC)
        {
            var sonuc = from doktor in dtDoktorlar.AsEnumerable()
                        select doktor;
            if (TC !=0)
            {
                sonuc = from doktor in sonuc
                        where doktor.Field<decimal>("TC")==TC&&doktor.Field<String>("Rol").Equals("Doktor")
                        select doktor;

            }
            if (sonuc.Count() > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean doktorArama(String isim, String password)
        {
            var sonuc = from doktor in dtDoktorlar.AsEnumerable()
                        select doktor;
            if (isim != "" && password != "")
            {
                sonuc = from doktor in sonuc
                        where doktor.Field<String>("DoktorAdi").ToUpper().Equals(isim.ToUpper()) && doktor.Field<String>("Password").ToUpper().Equals(password.ToUpper())
                        select doktor;

            }
            if (sonuc.Count() > 0)
            {
                return true;
            }
            return false;
        }
        DateTime tarih = new DateTime();
        public void doktorKayidet(String isim, String soyisim, String sifre, String email, decimal tc, decimal telNo, String rol)
        {
            tarih = System.DateTime.Now;
            dtDoktorlar.Rows.Add(isim, soyisim, email, sifre, telNo, tc, rol, tarih);
            dsOtomasyon.WriteXml(XMLDosya, XmlWriteMode.WriteSchema);
        }
        public void doktorKayidet(DataTable dt)
        {
            dsOtomasyon.Tables.Clear();
            dtDoktorlar = dt.Copy();
            dsOtomasyon.Tables.Add(dtHastalar);
            dsOtomasyon.Tables.Add(dtDoktorlar);
            
            dsOtomasyon.WriteXml(XMLDosya, XmlWriteMode.WriteSchema);
        }

        public override DataTable listele()
        {
            return dtDoktorlar;
        }
    }
}
