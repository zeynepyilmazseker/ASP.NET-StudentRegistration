using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciid;
        private string numara;
        private string mail;
        private string sifre;
        private double bakiye;
        private string foto;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

        public string Numara { get => numara; set => numara = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public int Ogrenciid { get => ogrenciid; set => ogrenciid = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}
