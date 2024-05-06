using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruFormu
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public int BasDersid { get => basdersid; set => basdersid = value; }
        public int BasOgrid { get => basogrid; set => basogrid = value; }
    }
}
