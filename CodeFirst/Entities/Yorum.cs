using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public string YorumMetni { get; set; }
        public int YorumYapanUyeID { get; set; }
        public int YorumAlanItirafID { get; set; }
        public DateTime YorumTarihi { get; set; }

        public Uye Uye { get; set; }
        public Itiraf Itiraf { get; set; }
    }
}
