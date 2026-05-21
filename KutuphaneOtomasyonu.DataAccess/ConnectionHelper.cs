using System.Configuration;
using System.Data.SqlClient; // .NET 8 için Microsoft.Data.SqlClient paketini kullanıyorsanız, burayı değiştirmelisiniz.

namespace KutuphaneOtomasyonu.DataAccess
{
    public class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            // App.config içerisinde "KutuphaneDB" ismiyle tanımlanan connection string'i okur.
            return ConfigurationManager.ConnectionStrings["KutuphaneDB"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
