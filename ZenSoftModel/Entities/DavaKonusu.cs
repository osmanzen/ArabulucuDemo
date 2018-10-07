using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("DavaKonusu")]
    public partial class DavaKonusu : MyBaseEntity
    {
        public DavaKonusu()
        {
            KonusuOlduguDavalar = new HashSet<Dava>();
        }

        private Guid? davaTuruID { get; set; }
        public Guid? DavaTuruID
        {
            get { return davaTuruID; }
            set
            {
                if (value == DavaTuruID) return; davaTuruID = value;
                OnPropertyChanged("DavaTuruID");
            }
        }
        
        private string konuAdi { get; set; }
        public string KonuAdi
        {
            get { return konuAdi; }
            set
            {
                if (value == KonuAdi) return; konuAdi = value;
                OnPropertyChanged("KonuAdi");
            }
        }

        public virtual DavaTuru DavaTuru { get; set; }

        public virtual ICollection<Dava> KonusuOlduguDavalar { get; set; }
    }
}
