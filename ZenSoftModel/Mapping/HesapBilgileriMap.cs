using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class HesapBilgileriMap : EntityTypeConfiguration<HesapBilgileri>
    {
        public HesapBilgileriMap()
        {
            HasOptional(x => x.Buro).WithMany(x => x.HesapBilgileri).HasForeignKey(x => x.BuroID);
        }
    }
}
