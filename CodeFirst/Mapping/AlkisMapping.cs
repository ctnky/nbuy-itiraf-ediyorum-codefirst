using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Mapping
{
    class AlkisMapping : EntityTypeConfiguration<Alkis>
    {
        public AlkisMapping()
        {
            HasKey(a => a.AlkisID);

            HasRequired(a => a.Uye)
               .WithMany(a => a.ItirafAlkislari)
               .HasForeignKey(a => a.AlkisiYapanUyeID);

            HasRequired(a => a.Itiraf)
              .WithMany(a => a.ItirafAlkislari)
              .HasForeignKey(a => a.AlkisiAlanItirafID);
        }
    }
}
