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
    public partial class OgrenciDers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenciDers> ogrDersList = BLLOgrenciDers.OgrenciDersListeleBLL();
            Repeater1.DataSource = ogrDersList;
            Repeater1.DataBind();
        }
    }
}