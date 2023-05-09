using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Bioskop.Konekcija
{
    internal class Konekcija
    {
        public static SqlConnection KonektujSe()
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["Bioskop"].ConnectionString);
            return veza;
        }
    }
}
