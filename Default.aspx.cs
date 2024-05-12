using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersKayit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOgrEkle_Click(object sender, EventArgs e)
        {
           

         EntityOgrenci ogrenci = new EntityOgrenci();
            ogrenci.Ad = TxtAd.Text;
            ogrenci.Soyad = TxtSoyad.Text;
            ogrenci.Numara = TxtNumara.Text;
          
            ogrenci.Mail = TxtMail.Text;
            ogrenci.Sifre = TxtSifre.Text;
         BLLOgrenci.OgrenciEkleBLL(ogrenci);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Öğrenci başarıyla eklendi.');", true);
            Response.Redirect("OgrenciListesi.aspx");

        }
    }
}