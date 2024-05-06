using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private int dersid;
        private string dersAd;
        private int minKontenjan;
        private int maxKontenjan;


        public int Dersid { get => dersid; set => dersid = value; }
        public string DersAd { get => dersAd; set => dersAd = value; }
        public int MinKontenjan { get => minKontenjan; set => minKontenjan = value; }
        public int MaxKontenjan { get => maxKontenjan; set => maxKontenjan = value; }

    }
}
