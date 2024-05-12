using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALOgrenciDers
    {
        public static List<EntityOgrenciDers> OgrenciDersListele()
        {
            List<EntityOgrenciDers> degerler = new List<EntityOgrenciDers>();
            SqlCommand kmtOgrList = new SqlCommand("SELECT TBLOGRENCI.OGRID, TBLOGRENCI.OGRAD, TBLOGRENCI.OGRSOYAD, TBLOGRENCI.OGRNUMARA, STUFF((SELECT ', ' + TBLDERSLER.DERSAD FROM TBLDERSLER INNER JOIN TBLBASVURUFORM ON TBLBASVURUFORM.DERSID = TBLDERSLER.DERSID WHERE TBLBASVURUFORM.OGRENCIID = TBLOGRENCI.OGRID FOR XML PATH('')), 1, 2, '') AS Dersler FROM TBLOGRENCI GROUP BY TBLOGRENCI.OGRID, TBLOGRENCI.OGRAD, TBLOGRENCI.OGRSOYAD, TBLOGRENCI.OGRNUMARA", Baglanti.baglan);
            if (kmtOgrList.Connection.State != ConnectionState.Open)
            {
                kmtOgrList.Connection.Open();
            }
            SqlDataReader reader = kmtOgrList.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenciDers entity = new EntityOgrenciDers();
                entity.Ogrid = Convert.ToInt32(reader["OGRID"].ToString());
                entity.Ad = reader["OGRAD"].ToString();
                entity.Soyad = reader["OGRSOYAD"].ToString();
                entity.Numara = reader["OGRNUMARA"].ToString();
                entity.Dersad = reader["Dersler"].ToString();
                degerler.Add(entity);

            }
            reader.Close();
            return degerler;


        }
    }
}
