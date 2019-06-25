using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class SehirMapping : EntityTypeConfiguration<Sehir>
    {
        public SehirMapping()
        {
            HasKey(a => a.SehirID);

            Property(a => a.SehirAdi)
                .IsRequired()
                .HasMaxLength(150);

            HasMany(a => a.Uyeler)
               .WithRequired(a => a.Sehir)
               .HasForeignKey(a => a.UyeninSehriID);
        }
    }
}
