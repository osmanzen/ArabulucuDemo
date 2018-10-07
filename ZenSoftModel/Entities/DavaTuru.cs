using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("DavaTuru")]
    public partial class DavaTuru : MyBaseEntity
    {
        public DavaTuru()
        {
            DavaKonulari = new HashSet<DavaKonusu>();
        }

        private string turAdi { get; set; }
        public string TurAdi
        {
            get { return turAdi; }
            set
            {
                if (value == TurAdi) return; turAdi = value;
                OnPropertyChanged("TurAdi");
            }
        }

        public virtual ICollection<DavaKonusu> DavaKonulari { get; set; }
    }
}
