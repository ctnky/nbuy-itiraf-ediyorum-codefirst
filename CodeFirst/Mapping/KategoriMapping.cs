using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            HasKey(a => a.KategoriID);

            Property(a => a.KategoriAdi)
                .IsRequired()
                .HasMaxLength(250);

            HasMany(a => a.Itiraflar)
             .WithRequired(a => a.Kategori)
             .HasForeignKey(a => a.ItirafinKategorisiID);
        }
    }
}
