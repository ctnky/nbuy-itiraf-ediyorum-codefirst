using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Kategori
    {
        public Kategori()
        {
            Itiraflar = new HashSet<Itiraf>();
        }
        
        public byte KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public ICollection<Itiraf> Itiraflar { get; set; }
    }
}
