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
    public partial class frmKayıtFormu : Form
    {
        public frmKayıtFormu()
        {
            InitializeComponent();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            txtName.Text = ""; txtSurname.Text = ""; txtPass.Text = ""; txtPassConfirm.Text = "";
            txtEmail.Text = ""; nmTelefon.Value = 0; cbRol.Text = "";

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Classes.DoktorIslemi islem = new Classes.DoktorIslemi();
            String ad = txtName.Text;
            String soyad = txtSurname.Text;
            String rol = cbRol.Text;
            decimal tc = nmTc.Value;
            decimal telNo = nmTelefon.Value;
            String sifre = txtPass.Text;
            string sifreTekrar = txtPassConfirm.Text;
            string email = txtEmail.Text;
            if (sifre == sifreTekrar)
            {
                islem.doktorKayidet(ad, soyad, sifre, email, tc, telNo, rol);
                MessageBox.Show("Kayidiniz olusturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Girdiginiz Sifreler birbirinden farkli!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
