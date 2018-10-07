using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class DavaMap : EntityTypeConfiguration<Dava>
    {
        public DavaMap()
        {
            HasOptional(x => x.Basvurucu).WithMany(x => x.Davalari).HasForeignKey(x => x.BasvurucuID);

            HasOptional(x => x.BasvurucuVekili).WithMany(x => x.Davalari).HasForeignKey(x => x.BasvurucuVekilID);

            HasOptional(x => x.Burosu).WithMany(x => x.Davalari).HasForeignKey(x => x.BuroID);

            HasMany(x => x.DavaKonulari).WithMany(x => x.KonusuOlduguDavalar).Map(m => { m.ToTable("DavaninKonulari"); m.MapLeftKey("DavaKonuID"); m.MapRightKey("DavaID"); });

        }
    }
}
