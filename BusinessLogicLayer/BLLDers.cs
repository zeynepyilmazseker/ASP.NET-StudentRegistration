using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListeleBLL()
        {
            return DALDers.DersleriListele();
        }

        public static int DersKayıtEkleBLL(EntityBasvuruFormu parameter)
        {
            if (parameter.BasDersid != 0 && parameter.BasOgrid != 0) {
                return DALDers.DersKayıtEkle(parameter);
            }
            return -1;
            
        }



    }
}
