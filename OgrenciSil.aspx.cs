using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;



namespace YazOkuluDersKayit
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OGRID"]);
            EntityOgrenci ogrenci = new EntityOgrenci();
            ogrenci.Ogrenciid = id;
            BLLOgrenci.OgrenciSilBLL(ogrenci.Ogrenciid);
            Response.Redirect("OgrenciListesi.aspx");


        }
    }
}