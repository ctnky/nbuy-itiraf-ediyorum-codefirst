using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Itiraf
    {
        public Itiraf()
        {
            ItirafAlkislari = new HashSet<Alkis>();
            Yorumlar = new HashSet<Yorum>();
        }

        public int ItirafID { get; set; }
        public string ItirafBaslik { get; set; }
        public string ItirafMetin { get; set; }
        public DateTime? ItirafTarihi { get; set; }
        public int ItirafiYapanUyeID { get; set; }
        public byte ItirafinKategorisiID { get; set; }
        
        public Kategori Kategori { get; set; }
        public Uye Uye { get; set; }

        public ICollection<Alkis> ItirafAlkislari { get; set; }
        public ICollection<Yorum> Yorumlar { get; set; }
    }
}
