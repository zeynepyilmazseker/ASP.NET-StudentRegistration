using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    public class DersDAL
    {
        public static List<EntityDers> DersleriListele()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand kmtDersList = new SqlCommand("select * from TBLDERSLER", Baglanti.baglan);
            if (kmtDersList.Connection.State != ConnectionState.Open)
            {
                kmtDersList.Connection.Open();
            }
            SqlDataReader reader = kmtDersList.ExecuteReader();
            while (reader.Read())
            {
                EntityDers entity = new EntityDers();
                entity.Dersid = Convert.ToInt32(reader["DERSID"].ToString());
                entity.DersAd = reader["DERSAD"].ToString();
                entity.MinKontenjan = Convert.ToInt32(reader["DERSMINKONTENJAN"].ToString());
                entity.MaxKontenjan = Convert.ToInt32(reader["DERSMAKSKONTENJAN"].ToString());

                degerler.Add(entity);

            }
            reader.Close();
            return degerler;


        }

        public static int DersKayıtEkle(EntityBasvuruFormu parameter)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@p1,@p2)", Baglanti.baglan);
            komut.Parameters.AddWithValue("@p1", parameter.BasOgrid);
            komut.Parameters.AddWithValue("@p2", parameter.BasDersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }


            return komut.ExecuteNonQuery();

        }

    }
}
