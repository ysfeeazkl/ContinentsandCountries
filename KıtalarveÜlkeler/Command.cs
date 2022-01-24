using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KıtalarveÜlkeler
{
    public class Command
    {
        Bağlantı bağlantı = new Bağlantı();

        public SqlCommand command(string SqlCümlesi)
        {
            SqlCommand komut = new SqlCommand(SqlCümlesi, bağlantı.BağlantıAç());
            return komut;
        }



    }
}
