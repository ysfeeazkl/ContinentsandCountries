using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.DTO
{
    public class ÜlkelerDTO
    {
        public int ÜlkeID { get; set; }
        public string ÜlkeAd { get; set; }
        public string ÜlkeResmi { get; set; }       
        public int ÜlkeKıtası { get; set; }

        public override string ToString()
        {
            return $"{ÜlkeAd}";
        }
    }
}
