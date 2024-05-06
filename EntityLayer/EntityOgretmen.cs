using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogretmenid;
        private string ogrtadSoyad;
        private int ogrtbrans;


        public int OgretmenId { get => ogretmenid; set => ogretmenid = value; }
        public string OgrtAdSoyad { get => ogrtadSoyad; set => ogrtadSoyad = value; }
        public int OgrtBrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
