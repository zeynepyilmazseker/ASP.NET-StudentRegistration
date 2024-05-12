using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YazOkuluDersKayit
{
    public partial class AdminKayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdminKayit_Click(object sender, EventArgs e)
        {
            EntityAdmin admin = new EntityAdmin();
            admin.Ad = TxtAd.Text;
            admin.Soyad = TxtSoyad.Text;
            admin.Email = TxtMail.Text;
            admin.Sifre = TxtSifre.Text;
            BLLAdmin.AdminEkleBLL(admin);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Admin kaydı başarıyla tamamlandı.');", true);
            Response.Redirect("AdminGiris.aspx");
        }
    }
}