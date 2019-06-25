using CodeFirst.Entities;
using CodeFirst.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{

    public class ItirafEdiyorumDbContext : DbContext
    {
        public ItirafEdiyorumDbContext() : base("Server = CTNKYWORKS; Database = ItirafEdiyorumDb; Trusted_connection = true")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItirafEdiyorumDbContext, CodeFirst.Migrations.Configuration>());
        }

        public DbSet<Alkis> ItirafAlkislari { get; set; }
        public DbSet<Itiraf> Itiraflar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlkisMapping().ToTable("ItirafAlkislari"));
            modelBuilder.Configurations.Add(new ItirafMapping().ToTable("Itiraflar"));
            modelBuilder.Configurations.Add(new KategoriMapping().ToTable("Kategoriler"));
            modelBuilder.Configurations.Add(new SehirMapping().ToTable("Sehirler"));
            modelBuilder.Configurations.Add(new UyeMapping().ToTable("Uyeler"));
            modelBuilder.Configurations.Add(new YorumMapping().ToTable("Yorumlar"));

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
