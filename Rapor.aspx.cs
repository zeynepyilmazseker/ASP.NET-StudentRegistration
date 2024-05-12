using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using Microsoft.Reporting.WebForms;
using System.Data;
using DataAccessLayer;

namespace YazOkuluDersKayit
{
    public partial class Rapor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (!this.Page.IsPostBack)
            {
                string sql_string = "select * from TBLOGRENCI";
                SqlCommand komut = new SqlCommand(sql_string,Baglanti.baglan);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds, "DataSet1");

                ReportViewer1.Reset();
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Raporlar/Report1.rdlc");
                ReportDataSource rds = new ReportDataSource("DataSet_name", ds.Tables[0]);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.Refresh();


            } */
        }
    }
}