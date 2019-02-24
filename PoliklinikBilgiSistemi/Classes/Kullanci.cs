using System;
using System.Data;

namespace PoliklinikBilgiSistemi.Classes
{
    class Kullanci : Kisi
    {
        private String email;
        private String sifre;
        private String sifreTekrar;
        private String rol;
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public String SifreTekrar
        {
            get { return sifreTekrar; }
            set { sifreTekrar = value; }
        }
        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }
    }
}
