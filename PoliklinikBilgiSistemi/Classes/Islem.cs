using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikBilgiSistemi.Classes
{
    abstract public class Islem
    {
        public String XMLDosya = "poliklinikOtomasyonu.xml";
        public DataSet dsOtomasyon = new DataSet("Otomasyon");
        public DataTable dtHastalar = new DataTable("Hastalar");
        public DataTable dtDoktorlar = new DataTable("Doktorlar");


        public Islem()
        {
            dataSetOlustur();
        }
        private void dataSetOlustur()
        {
            if (System.IO.File.Exists(XMLDosya))
            {
                dsOtomasyon.ReadXml(XMLDosya);
                dtHastalar = dsOtomasyon.Tables[0];
                dtDoktorlar = dsOtomasyon.Tables[1];

            }
            else
            {
                dtHastalar.Columns.Add("HastaAdi", typeof(String));
                dtHastalar.Columns.Add("HastaSoyadi", typeof(String));
                dtHastalar.Columns.Add("HastaTc", typeof(decimal));
                dtHastalar.Columns.Add("HastalCinsiyeti", typeof(String));
                dtHastalar.Columns.Add("HastaYasi", typeof(decimal));
                dtHastalar.Columns.Add("HastaBoyu", typeof(decimal));
                dtHastalar.Columns.Add("HastaKilosu", typeof(int));
                dtHastalar.Columns.Add("HastalikTani", typeof(String));
                dtHastalar.Columns.Add("VerilenIlac", typeof(String));
                dtHastalar.Columns.Add("IstenenTahliller", typeof(String));
                dtHastalar.Columns.Add("AlinanUcret", typeof(int));
                dtHastalar.Columns.Add("Tarih", typeof(DateTime));
                dsOtomasyon.Tables.Add(dtHastalar);

                dtDoktorlar.Columns.Add("DoktorAdi", typeof(String));
                dtDoktorlar.Columns.Add("DoktorSoyadi", typeof(String));
                dtDoktorlar.Columns.Add("Email", typeof(String));
                dtDoktorlar.Columns.Add("Password", typeof(String));
                dtDoktorlar.Columns.Add("telefonNo", typeof(decimal));
                dtDoktorlar.Columns.Add("TC", typeof(decimal));
                dtDoktorlar.Columns.Add("Rol", typeof(String));
                dtDoktorlar.Columns.Add("KayitTarihi", typeof(DateTime));
                dsOtomasyon.Tables.Add(dtDoktorlar);

                dsOtomasyon.WriteXml(XMLDosya, XmlWriteMode.WriteSchema);
            }

        }
        public abstract DataTable listele();
    }
}
