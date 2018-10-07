using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("TelefonBilgileri")]
    public partial class TelefonBilgileri : MyBaseEntity
    {
        private string numara { get; set; }
        public string Numara
        {
            get { return numara; }
            set
            {
                if (value == Numara) return; numara = value;
                OnPropertyChanged("Numara");
            }
        }

        private int? sabitCepFax { get; set; }
        public int? SabitCepFax
        {
            get { return sabitCepFax; }
            set
            {
                if (value == SabitCepFax) return; sabitCepFax = value;
                OnPropertyChanged("SabitCepFax");
            }
        }

        private Guid? buroID { get; set; }
        public Guid? BuroID
        {
            get { return buroID; }
            set
            {
                if (value == BuroID) return; buroID = value;
                OnPropertyChanged("BuroID");
            }
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

        public virtual Buro Buro { get; set; }

        public virtual Taraf Taraf { get; set; }

        public virtual Vekil Vekil { get; set; }
    }
}
