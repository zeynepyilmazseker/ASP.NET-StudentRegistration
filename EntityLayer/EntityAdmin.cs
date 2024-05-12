using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAdmin
    {
        private int id;
        private string ad;
        private string soyad;
        private string email;
        private string sifre;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Email { get => email; set => email = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
