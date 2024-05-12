using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessLayer;

namespace YazOkuluDersKayit
{
    public partial class Admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            string email = TxtMail.Text;
            string password = TxtSifre.Text;

            using (SqlConnection connection = new SqlConnection(Baglanti.baglan.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TBLADMIN WHERE Email = @p1 AND Sifre = @p2", connection);
                    command.Parameters.AddWithValue("@p1", email);
                    command.Parameters.AddWithValue("@p2", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Giriş başarılı, OgrenciListesi.aspx sayfasına yönlendir
                        Response.Redirect("OgrenciListesi.aspx");
                    }
                    else
                    {
                        // Hatalı giriş, hata mesajı göster
                        ClientScript.RegisterStartupScript(this.GetType(), "HataliGiris", "alert('Hatalı email veya şifre!');", true);
                    }
                }
                catch (Exception ex)
                {
                    // Hata oluştuğunda hata mesajı göster
                    ClientScript.RegisterStartupScript(this.GetType(), "Hata", "alert('Hata: " + ex.Message + "');", true);
                }
                finally
                {
                    // Bağlantıyı kapat
                    connection.Close();
                }
            }
        }

    }
}