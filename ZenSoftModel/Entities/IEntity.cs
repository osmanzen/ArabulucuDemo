using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenSoftModel.Entities
{
    public interface IEntity
    {
        Guid ID { get; set; }

        bool AktifMi { get; set; }
    }
}
