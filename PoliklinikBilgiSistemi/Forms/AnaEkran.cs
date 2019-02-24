using PoliklinikBilgiSistemi.Classes;
using PoliklinikBilgiSistemi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikBilgiSistemi
{
    public partial class frmAnaEkran : Form
    {
        int ucret;
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public DateTime tarih = new DateTime();
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (nmTc.Value <= 0)
            {
                MessageBox.Show("Hasta T.C. Numarasi girilmeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtHastaAdi.Text == "" || txtHastaSoyAdi.Text == "")
            {
                MessageBox.Show("Hasta Adi ve Soyadi girilmeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (nmKilo.Value <= 0)
            {
                MessageBox.Show("Hasta Kilosu girilmeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtHastalikTani.Text == "")
            {
                MessageBox.Show("Tani girilmeli", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hasta yeni = new Hasta();
            yeni.Isim = txtHastaAdi.Text;
            yeni.Soyisim = txtHastaSoyAdi.Text;
            yeni.Tc = nmTc.Value;
            yeni.Yas = nmHastaYasi.Value;
            yeni.Kilo = Convert.ToInt32(nmKilo.Value);
            yeni.Boy = nmBoy.Value;
            ucret = Convert.ToInt32(nmUcret.Value);

            yeni.hastalik = new Hastalik();
            string tah = "";
            for (int i = 0; i < cbTahlil.CheckedItems.Count; i++)
            {
                tah += cbTahlil.CheckedItems[i].ToString() + " , ";

            }
            yeni.hastalik.Tani = txtHastalikTani.Text;
            yeni.hastalik.Tahlil = tah;
            if (rdErkek.Checked)
                yeni.Cinsiyet = "Erkek";
            else if (rdKiz.Checked)
                yeni.Cinsiyet = "Kiz";
            else yeni.Cinsiyet = "Bilinmeyen";

            yeni.hastalik.Ilac = txtVerilenIlac.Text;
            HastaIslemi islemYap = new HastaIslemi();

            islemYap.hastaKayidEt(yeni.Isim, yeni.Soyisim, yeni.Tc, yeni.Cinsiyet, yeni.Yas, yeni.Boy, yeni.Kilo, yeni.hastalik.Tani, yeni.hastalik.Ilac, yeni.hastalik.Tahlil, ucret);
            sonKayitListele(yeni);
            MessageBox.Show("Yeni Hasta Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }


        private void sonKayitListele(Hasta son)
        {
            listView.Items.Clear();
            listView.Items.Add("Hasta T.C Numarasi: " + son.Tc);
            listView.Items.Add("Hasta Adi Soyadi: " + son.Isim + " " + son.Soyisim);
            listView.Items.Add("Hasta Cinsiyeti: " + son.Cinsiyet);
            listView.Items.Add("Hasta Yasi/boyu/kilosu: " + son.Yas + "/" + son.Boy + "cm/" + son.Kilo + "kg");
            listView.Items.Add("Alinan Ucret: " + ucret);
            listView.Items.Add("Hastalik tani: " + son.hastalik.Tani);
            listView.Items.Add("Hastaya Verilen Ilac: " + son.hastalik.Ilac);
            string tah = "";
            for (int i = 0; i < cbTahlil.CheckedItems.Count; i++)
            {
                tah += cbTahlil.CheckedItems[i].ToString() + " , ";

            }
            listView.Items.Add("Hastadan Istenen Tahliller: " + tah);
            tarih = System.DateTime.Now;

            listView.Items.Add("Tarih: " + tarih.ToShortDateString());
        }


        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmrapor = new frmRapor();
            frmrapor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dogrulama dogru = new Dogrulama();
            dogru.Show();
            
        }
    }

}

