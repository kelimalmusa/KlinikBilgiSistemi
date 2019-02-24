using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikBilgiSistemi.Forms
{
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }

        private void btnKayd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgKullanici.DataSource;
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            islem.doktorKayidet(dt);
            MessageBox.Show("Bilgiler kaydedildi");
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            dgKullanici.DataSource = islem.listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            DataTable dt = (DataTable)dgKullanici.DataSource;
            islem.doktorKayidet(dt);
            MessageBox.Show("Bilgiler kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
