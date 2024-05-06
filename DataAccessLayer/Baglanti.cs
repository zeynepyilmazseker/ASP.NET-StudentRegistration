using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-8JJLI3A;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
