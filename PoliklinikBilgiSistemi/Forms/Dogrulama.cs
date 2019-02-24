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
    public partial class Dogrulama : Form
    {
        public Dogrulama()
        {
            InitializeComponent();
        }

        private void btnDogrulama_Click(object sender, EventArgs e)
        {
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            decimal tc = Convert.ToDecimal(txtTc.Text);
            if (islem.doktorArama(tc))
            {
                Kullanıcılar frmKullanici = new Kullanıcılar();
                frmKullanici.Show();
                this.Hide();
            }
            else MessageBox.Show("Bu Bolume Sadece Doktor girebilir\nLütfen T.C. Numaranızı Kontrol Ediniz ya da Doktorla İrtibata Geçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            
        }
    }
}
