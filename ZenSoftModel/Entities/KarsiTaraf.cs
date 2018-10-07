using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("KarsiTaraf")]
    public partial class KarsiTaraf : MyBaseEntity
    {
        public KarsiTaraf()
        {
            Heyetleri = new HashSet<Heyet>();
            IlgiliKurumlari = new HashSet<Taraf>();
        }

        private Guid? tarafID { get; set; }
        public Guid? TarafID
        {
            get { return tarafID; }
            set
            {
                if (value == TarafID) return; tarafID = value;
                OnPropertyChanged("TarafID");
            }
        }

        private Guid? vekilID { get; set; }
        public Guid? VekilID
        {
            get { return vekilID; }
            set
            {
                if (value == VekilID) return; vekilID = value;
                OnPropertyChanged("VekilID");
            }
        }

        private Guid? davaID { get; set; }
        public Guid? DavaID
        {
            get { return davaID; }
            set
            {
                if (value == DavaID) return; davaID = value;
                OnPropertyChanged("DavaID");
            }
        }

        private string karsiTarafNot { get; set; }
        public string KarsiTarafNot
        {
            get { return karsiTarafNot; }
            set
            {
                if (value == KarsiTarafNot) return; karsiTarafNot = value;
                OnPropertyChanged("KarsiTarafNot");
            }
        }


        public virtual Taraf Taraf { get; set; }

        public virtual Vekil Vekil { get; set; }

        public virtual Dava Dava { get; set; }

        public virtual ICollection<Heyet> Heyetleri { get; set; }

        public virtual ICollection<Taraf> IlgiliKurumlari { get; set; }
    }
}
