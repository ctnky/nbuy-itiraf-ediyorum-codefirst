using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class ItirafMapping : EntityTypeConfiguration<Itiraf>
    {
        public ItirafMapping()
        {
            HasKey(a => a.ItirafID);

            Property(a => a.ItirafBaslik)
                .IsRequired()
                .HasMaxLength(150);

            Property(a => a.ItirafMetin)
                .IsRequired()
                .HasMaxLength(1500);

            HasMany(a => a.ItirafAlkislari)
              .WithRequired(a => a.Itiraf)
              .HasForeignKey(a => a.AlkisiAlanItirafID);

            HasMany(a => a.Yorumlar)
              .WithRequired(a => a.Itiraf)
              .HasForeignKey(a => a.YorumAlanItirafID);

            HasRequired(a => a.Kategori)
                .WithMany(a => a.Itiraflar)
                .HasForeignKey(a => a.ItirafinKategorisiID);

            HasRequired(a => a.Uye)
                .WithMany(a => a.Itiraflar)
                .HasForeignKey(a => a.ItirafiYapanUyeID);
        }


    }
}
