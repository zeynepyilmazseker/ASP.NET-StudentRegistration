using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenciDers
    {
        private int ogrid;
        private string ad;
        private string soyad;
        private string numara;
        private string dersad;

        public int Ogrid { get => ogrid; set => ogrid = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Dersad { get => dersad; set => dersad = value; }
    }
}
