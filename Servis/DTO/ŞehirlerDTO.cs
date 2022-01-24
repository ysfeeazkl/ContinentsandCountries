using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.DTO
{
    public class ŞehirlerDTO
    {
        public int ŞehirID { get; set; }
        public string YüzÖlçümü { get; set; }
        public string ŞehirAdı { get; set; }
        public string Nüfusu { get; set; }
        public string TelefonKodu { get; set; }
        public int ÜlkesiID { get; set; }
        public int KıtasıID { get; set; }
        public ÜlkelerDTO ülke { get; set; }

        public override string ToString()
        {
            return $"{ŞehirAdı}";
        }
    }
}
