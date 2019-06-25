using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Alkis
    {
        public int AlkisID { get; set; }
        public int AlkisiYapanUyeID { get; set; }
        public int AlkisiAlanItirafID { get; set; }
        public DateTime AlkisTarihi { get; set; }

        public Uye Uye { get; set; }
        public Itiraf Itiraf { get; set; }
    }
}
