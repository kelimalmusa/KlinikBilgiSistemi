using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikBilgiSistemi
{
    public partial class frmGirisForm : Form
    {
        public frmGirisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool girisControl(String kullanciAdi, String sifre)
        {
            StreamReader reader = new StreamReader("girisBilgi.txt");
            if ((reader.ReadLine() == kullanciAdi) && (reader.ReadLine() == sifre))
            {
                reader.Close();
                return true;
            }
            else
                return false;

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            String kullanciAdi;
            String sifre;
            kullanciAdi = txtKullanci.Text;
            sifre = txtSifre.Text;
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            if (islem.doktorArama(kullanciAdi, sifre))
            {
                Program.kullanici = kullanciAdi;
                frmAnaEkran anaEkran = new frmAnaEkran();
                anaEkran.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullancı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (girisControl(kullanciAdi, sifre))
            //{
            //    frmAnaEkran anaEkran = new frmAnaEkran();
            //    anaEkran.Show();
            //    this.Hide();
            //}
            //else if (kullanciAdi == "" || sifre == "")
            //    MessageBox.Show("Kullancı Adı veya Şifre Girilmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //    MessageBox.Show("Kullancı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullanci.Text = "";
            txtSifre.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtFormu kayitFormu = new frmKayıtFormu();
            kayitFormu.ShowDialog();
        }
    }
}
