using System.Data.Entity.ModelConfiguration;
using ZenSoftModel.Entities;

namespace ZenSoftModel.Mapping
{
    public class GorusmeMap : EntityTypeConfiguration<Gorusme>
    {
        public GorusmeMap()
        {
            HasOptional(x => x.Dava).WithMany(x => x.Gorusmeler).HasForeignKey(x => x.DavaID);
        }
    }
}
