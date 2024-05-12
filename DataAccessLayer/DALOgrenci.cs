using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komutOgrEkle = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRMAIL,OGRSIFRE) values (@p1,@p2,@p3,@p5,@p6)", Baglanti.baglan);

            if (komutOgrEkle.Connection.State != ConnectionState.Open)
            {
                komutOgrEkle.Connection.Open();
            }

            komutOgrEkle.Parameters.AddWithValue("@p1", parametre.Ad);
            komutOgrEkle.Parameters.AddWithValue("@p2", parametre.Soyad);
            komutOgrEkle.Parameters.AddWithValue("@p3", parametre.Numara);
           
            komutOgrEkle.Parameters.AddWithValue("@p5", parametre.Mail);
            komutOgrEkle.Parameters.AddWithValue("@p6", parametre.Sifre);
            return komutOgrEkle.ExecuteNonQuery();

        }

        public static List<EntityOgrenci> OgrencileriListele()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand kmtOgrList = new SqlCommand("select * from TBLOGRENCI",Baglanti.baglan);
            if (kmtOgrList.Connection.State != ConnectionState.Open)
            {
                kmtOgrList.Connection.Open();
            }
            SqlDataReader reader = kmtOgrList.ExecuteReader();
            while(reader.Read()) { 
            EntityOgrenci entity = new EntityOgrenci();
                entity.Ogrenciid = Convert.ToInt32(reader["OGRID"].ToString());
                entity.Ad = reader["OGRAD"].ToString();
                entity.Soyad = reader["OGRSOYAD"].ToString();
                entity.Numara = reader["OGRNUMARA"].ToString();
                entity.Foto = reader["OGRFOTO"].ToString();
                entity.Mail = reader["OGRMAIL"].ToString();
                entity.Bakiye = Convert.ToDouble(reader["OGRBAKIYE"].ToString());
                degerler.Add(entity);

            }
            reader.Close();
            return degerler;

                 
        }

        public static bool OgrenciSil(int ogrenciid)
        {
            SqlCommand komutSil = new SqlCommand("Delete from TBLOGRENCI where OGRID =@p1",Baglanti.baglan);
            
            if (komutSil.Connection.State != ConnectionState.Open)
            {
                komutSil.Connection.Open();
            }
            komutSil.Parameters.AddWithValue("@p1", ogrenciid);
           
            return komutSil.ExecuteNonQuery() > 0;

        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand kmtOgrList = new SqlCommand("select * from TBLOGRENCI where OGRID=@p1", Baglanti.baglan);
            kmtOgrList.Parameters.AddWithValue("@p1",id);
            if (kmtOgrList.Connection.State != ConnectionState.Open)
            {
                kmtOgrList.Connection.Open();
            }
            SqlDataReader reader = kmtOgrList.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenci entity = new EntityOgrenci();
               
                entity.Ad = reader["OGRAD"].ToString();
                entity.Soyad = reader["OGRSOYAD"].ToString();
                entity.Numara = reader["OGRNUMARA"].ToString();
                entity.Foto = reader["OGRFOTO"].ToString();
                entity.Mail = reader["OGRMAIL"].ToString();
                entity.Bakiye = Convert.ToDouble(reader["OGRBAKIYE"].ToString());
                degerler.Add(entity);

            }
            reader.Close();
            return degerler;


        }

        public static bool OgrenciGuncelle(EntityOgrenci ogrenci)
        {
            SqlCommand komutGuncelle = new SqlCommand("update TBLOGRENCI set OGRAD=@p2,OGRSOYAD=@p3,OGRNUMARA=@p4,OGRMAIL=@p6,OGRSIFRE=@p7 where OGRID=@p1", Baglanti.baglan);
            if (komutGuncelle.Connection.State != ConnectionState.Open)
            {
                komutGuncelle.Connection.Open();
            }

            komutGuncelle.Parameters.AddWithValue("@p1", ogrenci.Ogrenciid);
            komutGuncelle.Parameters.AddWithValue("@p2", ogrenci.Ad);
            komutGuncelle.Parameters.AddWithValue("@p3", ogrenci.Soyad);
            komutGuncelle.Parameters.AddWithValue("@p4", ogrenci.Numara);
            
            komutGuncelle.Parameters.AddWithValue("@p6", ogrenci.Mail);
            komutGuncelle.Parameters.AddWithValue("@p7", ogrenci.Sifre);
            return komutGuncelle.ExecuteNonQuery() > 0;
            
        }

    }
}
