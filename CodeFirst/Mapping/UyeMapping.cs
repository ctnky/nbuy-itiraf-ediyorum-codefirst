using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class UyeMapping : EntityTypeConfiguration<Uye>
    {
        public UyeMapping()
        {
            HasKey(a => a.UyeID);

            Property(a => a.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(250);

            Property(a => a.Sifre)
                .IsRequired()
                .HasMaxLength(16)
                .HasColumnType("char");

            HasMany(a => a.ItirafAlkislari)
                .WithRequired(a => a.Uye)
                .HasForeignKey(a => a.AlkisiYapanUyeID);

            HasMany(a => a.Yorumlar)
                .WithRequired(a => a.Uye)
                .HasForeignKey(a => a.YorumYapanUyeID);

            HasMany(a => a.Itiraflar)
                .WithRequired(a => a.Uye)
                .HasForeignKey(a => a.ItirafiYapanUyeID);

            HasRequired(a => a.Sehir)
                .WithMany(a => a.Uyeler)
                .HasForeignKey(a=>a.UyeninSehriID);
        }
    }
}
