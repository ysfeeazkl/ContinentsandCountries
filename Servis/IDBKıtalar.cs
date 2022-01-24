using Servis.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis
{
    public interface IDBKıtalar
    {
        void insert(string SqlCümlesi);
        void update(string SqlCümlesi);
        void delete(string SqlCümlesi);

        List<KıtalarDTO> KıtalarListesi(string SqlCümlesi);
        List<ÜlkelerDTO> ÜlkelerListesi(string SqlCümlesi);
        List<ŞehirlerDTO> ŞehirlerListesi(string SqlCümlesi);
            
    }
}
