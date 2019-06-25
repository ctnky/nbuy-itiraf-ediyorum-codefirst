using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Sehir
    {
        public Sehir()
        {
            Uyeler = new HashSet<Uye>();
        }

        public int SehirID { get; set; }
        public string SehirAdi { get; set; }

        public ICollection<Uye> Uyeler { get; set; }
    }
}
