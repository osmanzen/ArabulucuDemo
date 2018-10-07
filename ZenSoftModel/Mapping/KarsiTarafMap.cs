using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class KarsiTarafMap : EntityTypeConfiguration<KarsiTaraf>
    {
        public KarsiTarafMap()
        {
            HasOptional(x => x.Taraf).WithMany(x => x.KarsiTarafOlduklari).HasForeignKey(x => x.TarafID);
            HasOptional(x => x.Vekil).WithMany(x => x.KarsiTarafVekillikleri).HasForeignKey(x => x.VekilID);
            HasOptional(x => x.Dava).WithMany(x => x.KarsiTaraflar).HasForeignKey(x => x.DavaID);
            
            HasMany(x => x.Heyetleri).WithMany(x => x.KarsiTaraflar).Map(m => { m.ToTable("KarsiTarafHeyetleri"); m.MapLeftKey("KarsiTarafID"); m.MapRightKey("HeyetID"); });
        }
    }
}
