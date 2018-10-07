using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class TelefonBilgileriMap : EntityTypeConfiguration<TelefonBilgileri>
    {
        public TelefonBilgileriMap()
        {
            HasOptional(x => x.Buro).WithMany(x => x.TelefonBilgileri).HasForeignKey(x => x.BuroID);
            HasOptional(x => x.Taraf).WithMany(x => x.TelefonBilgileri).HasForeignKey(x => x.TarafID);
            HasOptional(x => x.Vekil).WithMany(x => x.TelefonBilgileri).HasForeignKey(x => x.VekilID);
        }
    }
}
