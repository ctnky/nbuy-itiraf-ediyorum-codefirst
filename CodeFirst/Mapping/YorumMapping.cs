using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class YorumMapping : EntityTypeConfiguration<Yorum>
    {
        public YorumMapping()
        {
            HasKey(a => a.YorumID);

            Property(a => a.YorumMetni)
                .IsRequired()
                .HasMaxLength(350);

            HasRequired(a => a.Uye)
                .WithMany(a => a.Yorumlar)
                .HasForeignKey(a => a.YorumYapanUyeID);

            HasRequired(a => a.Itiraf)
               .WithMany(a => a.Yorumlar)
               .HasForeignKey(a => a.YorumAlanItirafID);
        }
    }
}
