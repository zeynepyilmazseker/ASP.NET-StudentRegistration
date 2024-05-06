using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluDersKayit
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrList = BLLOgrenci.OgrenciListeleBLL();
            Repeater1.DataSource = ogrList;
            Repeater1.DataBind();

        }
    }
}