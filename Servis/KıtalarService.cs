using KıtalarveÜlkeler;
using Servis.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis
{
    public class KıtalarService : IDBKıtalar
    {
        Bağlantı bağlantı = new Bağlantı();
        Command cmd = new Command();

        public void delete(string SqlCümlesi)
        {
            SqlCommand cmd1 = cmd.command(SqlCümlesi);
            cmd1.ExecuteNonQuery();
            bağlantı.BağlantıKapat();
        }

        public void insert(string SqlCümlesi)
        {
            SqlCommand cmd1 = cmd.command(SqlCümlesi);
            cmd1.ExecuteNonQuery();
            bağlantı.BağlantıKapat();
        }

        public void update(string SqlCümlesi)
        {
            SqlCommand cmd1 = cmd.command(SqlCümlesi);
            cmd1.ExecuteNonQuery();
            bağlantı.BağlantıKapat();
        }

        public List<KıtalarDTO> KıtalarListesi(string SqlCümlesi)
        {
            SqlCommand komut = new SqlCommand(SqlCümlesi, bağlantı.BağlantıAç());
            SqlDataReader dr = komut.ExecuteReader();
            List<KıtalarDTO> Kdto = new List<KıtalarDTO>();

            while (dr.Read())
            {
                Kdto.Add(new KıtalarDTO
                {
                    KıtaID = int.Parse(dr["KıtaID"].ToString()),
                    KıtaAd = dr["KıtaAd"].ToString(),
                    KıtaResmi = dr["KıtaResmi"].ToString(),
                });
            }
            bağlantı.BağlantıKapat();
            return Kdto;
        }

      

        public List<ÜlkelerDTO> ÜlkelerListesi(string SqlCümlesi)
        {
            SqlCommand komut = new SqlCommand(SqlCümlesi, bağlantı.BağlantıAç());
            SqlDataReader dr = komut.ExecuteReader();
            List<ÜlkelerDTO> Üdto = new List<ÜlkelerDTO>();

            while (dr.Read())
            {
                Üdto.Add(new ÜlkelerDTO
                {
                    ÜlkeID = int.Parse(dr["ÜlkeID"].ToString()),
                    ÜlkeAd = dr["ÜlkeAd"].ToString(),
                    ÜlkeResmi = dr["ÜlkeResmi"].ToString(),
                    ÜlkeKıtası = int.Parse(dr["ÜlkeKıtası"].ToString()),
                });
            }
            bağlantı.BağlantıKapat();
            return Üdto;
        }

        public List<ŞehirlerDTO> ŞehirlerListesi(string SqlCümlesi)
        {
            SqlCommand komut = new SqlCommand(SqlCümlesi, bağlantı.BağlantıAç());
            SqlDataReader dr = komut.ExecuteReader();
            List<ŞehirlerDTO> Şdto = new List<ŞehirlerDTO>();

            while (dr.Read())
            {
                Şdto.Add(new ŞehirlerDTO
                {                   
                    ŞehirID = int.Parse(dr["ŞehirID"].ToString()),
                    ŞehirAdı = dr["ŞehirAdı"].ToString(),
                    Nüfusu = dr["Nüfusu"].ToString(),
                    YüzÖlçümü = dr["YüzÖlçümü"].ToString(),
                    TelefonKodu = dr["TelefonKodu"].ToString(),
                    ÜlkesiID = int.Parse(dr["ÜlkesiID"].ToString()),
                    KıtasıID = int.Parse(dr["KıtasıID"].ToString()),
                });
            }
            bağlantı.BağlantıKapat();
            return Şdto;
        }
    }
}
