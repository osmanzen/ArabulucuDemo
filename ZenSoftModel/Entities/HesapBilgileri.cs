using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("HesapBilgileri")]
    public partial class HesapBilgileri : MyBaseEntity
    {
        private string bankaAdi { get; set; }
        public string BankaAdi
        {
            get { return bankaAdi; }
            set
            {
                if (value == BankaAdi) return; bankaAdi = value;
                OnPropertyChanged("BankaAdi");
            }
        }

        private string subeAdi { get; set; }
        public string SubeAdi
        {
            get { return subeAdi; }
            set
            {
                if (value == SubeAdi) return; subeAdi = value;
                OnPropertyChanged("SubeAdi");
            }
        }

        private string _IBAN { get; set; }
        public string IBAN
        {
            get { return _IBAN; }
            set
            {
                if (value == IBAN) return; _IBAN = value;
                OnPropertyChanged("IBAN");
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

        public virtual Buro Buro { get; set; }
    }
}
