using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KıtalarveÜlkeler
{
    public class Bağlantı
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6TU5ELE\\SQLEXPRESS;Initial Catalog=DBKıtalar;Integrated Security=True");
        
        public SqlConnection BağlantıAç()
        {
            conn.Open();
            return conn;
        }

        public SqlConnection BağlantıKapat()
        {
            conn.Close();
            return conn;
        }
    }
}
