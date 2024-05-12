using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null  && p.Mail != null && p.Sifre != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }

            return -1;


        }

        public static List<EntityOgrenci> OgrenciListeleBLL()
        {
            return DALOgrenci.OgrencileriListele();
        }

        public static bool OgrenciSilBLL(int ogrenciid)
        {
            if(ogrenciid != 0)
            {
                return DALOgrenci.OgrenciSil(ogrenciid);
            }
            return false;

        }

        public static List<EntityOgrenci> OgrenciDetayListeleBLL(int id)
        {
            return DALOgrenci.OgrenciDetay(id);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci ogrenci)
        {
            if (ogrenci.Ad != null && ogrenci.Soyad != null && ogrenci.Numara != null  && ogrenci.Mail != null)
            {
                return DALOgrenci.OgrenciGuncelle(ogrenci);
            }
            return false;
        }

    }
}
