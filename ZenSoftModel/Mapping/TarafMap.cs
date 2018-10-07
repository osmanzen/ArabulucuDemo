using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class TarafMap : EntityTypeConfiguration<Taraf>
    {
        public TarafMap()
        {
            HasMany(x => x.Vekilleri).WithMany(x => x.VekiliOlduguTaraflar).Map(m => { m.ToTable("TarafVekilleri"); m.MapLeftKey("TarafID"); m.MapRightKey("VekilID"); });

            HasMany(x => x.IlgiliKarsiTaraflar).WithMany(x => x.IlgiliKurumlari).Map(m => { m.ToTable("IlgiliKurumlar"); m.MapLeftKey("TarafID"); m.MapRightKey("KarsiTarafID"); });

        }
    }
}
