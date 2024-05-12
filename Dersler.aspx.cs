using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace YazOkuluDersKayit
{
    public partial class Dersler : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["OGRID"]);
            if (Page.IsPostBack == false)
            {
                TextBox1.Text = Convert.ToString(id);
                TextBox1.Enabled = false;
                List<EntityDers> dersList = BLLDers.DersListeleBLL();
                DropDownList1.DataSource = BLLDers.DersListeleBLL();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "DERSID";
                DropDownList1.DataBind();

            }


        }

        protected void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            EntityBasvuruFormu entity = new EntityBasvuruFormu();
            entity.BasOgrid = id;
            entity.BasDersid = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            int sonuc = BLLDers.DersKayıtEkleBLL(entity);
            if (sonuc != -1) {
                Response.Redirect("OgrenciListesi.aspx");
            }
        }
    }
}