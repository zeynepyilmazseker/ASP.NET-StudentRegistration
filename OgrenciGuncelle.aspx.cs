using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluDersKayit
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OGRID"]);
            
            if(Page.IsPostBack == false) { 

            List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciDetayListeleBLL(id);
            TxtAd.Text = OgrList[0].Ad.ToString();
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].Foto.ToString();
            TxtMail.Text = OgrList[0].Mail.ToString();
            

            }

        }

        public void BtnOgrGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogrenci = new EntityOgrenci();
            ogrenci.Ogrenciid = id;
            ogrenci.Ad = TxtAd.Text;
            ogrenci.Soyad = TxtSoyad.Text;
            ogrenci.Numara = TxtNumara.Text;
            ogrenci.Foto = TxtFoto.Text;    
            ogrenci.Mail = TxtMail.Text;   
            ogrenci.Sifre = TxtSifre.Text;
            BLLOgrenci.OgrenciGuncelleBLL(ogrenci);
            Response.Redirect("OgrenciListesi.aspx");
      
           

        }
    }
}