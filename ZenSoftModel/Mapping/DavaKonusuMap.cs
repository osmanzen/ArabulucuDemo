using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class DavaKonusuMap : EntityTypeConfiguration<DavaKonusu>
    {
        public DavaKonusuMap()
        {
            HasOptional(x => x.DavaTuru).WithMany(x => x.DavaKonulari).HasForeignKey(x => x.DavaTuruID);
        }
    }
}
