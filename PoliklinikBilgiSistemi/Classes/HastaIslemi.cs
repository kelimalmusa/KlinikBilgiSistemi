using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    class HastaIslemi : Islem, IHastaKayitIslemi
    {
        DateTime tarih = new DateTime();
        public override DataTable listele()
        {
            return dtHastalar;
        }
        public void hastaKayidEt(String ad, String soyad, decimal tc, String cins, decimal yas, decimal boy, int kilo, String tani, String ilac, String tahlil, int ucret)
        {
            tarih = System.DateTime.Now;
            dtHastalar.Rows.Add(ad, soyad, tc, cins, yas, boy, kilo, tani, ilac, tahlil, ucret, tarih.ToShortDateString());
            dsOtomasyon.WriteXml(XMLDosya, XmlWriteMode.WriteSchema);
        }
        public void hastaKayidEt(DataTable dt)
        {
            dsOtomasyon.Tables.Clear();
            dtHastalar = dt.Copy();
            dsOtomasyon.Tables.Add(dtHastalar);
            dsOtomasyon.Tables.Add(dtDoktorlar);
            dsOtomasyon.WriteXml(XMLDosya, XmlWriteMode.WriteSchema);
        }


        public DataTable hastaArma(String ad, String soyad, decimal tc)
        {
            var sonuc = from hasta in dtHastalar.AsEnumerable()
                        select hasta;

            if (ad != "")
            {
                sonuc = from hasta in sonuc
                        where hasta.Field<String>("HastaAdi").ToUpper().Contains(ad.ToUpper())
                        select hasta;
            }
            if (soyad != "")
            {
                sonuc = from hasta in sonuc
                        where hasta.Field<String>("HastaSoyadi").ToUpper().Contains(soyad.ToUpper())
                        select hasta;
            }
            if (tc != 10000000000)
            {
                sonuc = from hasta in sonuc
                        where hasta.Field<decimal>("HastaTc") == tc
                        select hasta;
            }
           
            if (sonuc.Count() > 0)
            {
                DataTable dtSonuc = sonuc.CopyToDataTable();
                return dtSonuc;
            }
            else
                return null;

        }

    }
}
