using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLAdmin
    {
        public static int AdminEkleBLL(EntityAdmin p)
        {
            if (p.Ad != null && p.Soyad != null  &&  p.Email != null && p.Sifre != null)
            {
                return DalAdmin.AdminEkle(p);
            }

            return -1;


        }

    }
}
