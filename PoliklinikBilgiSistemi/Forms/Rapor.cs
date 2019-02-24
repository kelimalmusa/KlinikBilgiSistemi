using PoliklinikBilgiSistemi.Classes;
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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            HastaIslemi islem = new HastaIslemi();
            dgRapor.DataSource = islem.listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "";
            txtAraSoy.Text = "";
            nmAraTc.Value = 10000000000;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            String arananAd = txtAraAd.Text;
            String arananSoyad = txtAraSoy.Text;
            decimal aranaTc = nmAraTc.Value;

            HastaIslemi islem = new HastaIslemi();
            dgRapor.DataSource = islem.hastaArma(arananAd, arananSoyad, aranaTc);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HastaIslemi islem = new HastaIslemi();
            DataTable dt = (DataTable)dgRapor.DataSource;
            islem.hastaKayidEt(dt);
            MessageBox.Show("Bilgiler kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }
    }
}
