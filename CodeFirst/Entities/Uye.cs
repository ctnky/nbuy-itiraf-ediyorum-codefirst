using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Uye
    {
        public Uye()
        {
            Yorumlar = new HashSet<Yorum>();
            Itiraflar = new HashSet<Itiraf>();
            ItirafAlkislari = new HashSet<Alkis>();
        }

        public int UyeID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int UyeninSehriID { get; set; }

        public Sehir Sehir { get; set; }

        public ICollection<Yorum> Yorumlar { get; set; }
        public ICollection<Itiraf> Itiraflar { get; set; }
        public ICollection<Alkis> ItirafAlkislari { get; set; }
    }
}
