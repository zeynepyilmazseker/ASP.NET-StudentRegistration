using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataAccessLayer
{
    public class DalAdmin
    {
        public static int AdminEkle(EntityAdmin parametre)
        {
            SqlCommand komutAdminEkle = new SqlCommand("insert into TBLADMIN (Ad,Soyad,Email,Sifre) values (@p1,@p2,@p3,@p4)", Baglanti.baglan);

            if (komutAdminEkle.Connection.State != ConnectionState.Open)
            {
                komutAdminEkle.Connection.Open();
            }

            komutAdminEkle.Parameters.AddWithValue("@p1", parametre.Ad);
            komutAdminEkle.Parameters.AddWithValue("@p2", parametre.Soyad);
            komutAdminEkle.Parameters.AddWithValue("@p3", parametre.Email);
            komutAdminEkle.Parameters.AddWithValue("@p4", parametre.Sifre);
            
            return komutAdminEkle.ExecuteNonQuery();

        }

      
    }
}
