using System.Data.Entity;
using ZenSoftModel.Entities;
using ZenSoftModel.Mapping;

namespace ZenSoftDAL.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ArabulucuDBContext")
        {
            Configuration.AutoDetectChangesEnabled = true;
        }

        public virtual DbSet<Buro> Buro { get; set; }
        public virtual DbSet<Dava> Dava { get; set; }
        public virtual DbSet<DavaKonusu> DavaKonusu { get; set; }
        public virtual DbSet<DavaTuru> DavaTuru { get; set; }
        public virtual DbSet<Gorusme> Gorusme { get; set; }
        public virtual DbSet<HesapBilgileri> HesapBilgileri { get; set; }
        public virtual DbSet<Heyet> Heyet { get; set; }
        public virtual DbSet<KarsiTaraf> KarsiTaraf { get; set; }
        public virtual DbSet<Taraf> Taraf { get; set; }
        public virtual DbSet<TelefonBilgileri> TelefonBilgileri { get; set; }
        public virtual DbSet<Vekil> Vekil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BuroMap());
            modelBuilder.Configurations.Add(new DavaKonusuMap());
            modelBuilder.Configurations.Add(new DavaMap());
            modelBuilder.Configurations.Add(new GorusmeMap());
            modelBuilder.Configurations.Add(new HesapBilgileriMap());
            modelBuilder.Configurations.Add(new KarsiTarafMap());
            modelBuilder.Configurations.Add(new TarafMap());
            modelBuilder.Configurations.Add(new TelefonBilgileriMap());
        }
    }
}
