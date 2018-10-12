using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("Gorusme")]
    public partial class Gorusme : MyBaseEntity
    {
        private DateTime? gorusmeTarihi { get; set; }
        public DateTime? GorusmeTarihi
        {
            get { return gorusmeTarihi; }
            set
            {
                if (value == GorusmeTarihi) return; gorusmeTarihi = value;
                OnPropertyChanged("GorusmeTarihi");
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

        private string gorusmeAdi { get; set; }
        public string GorusmeAdi
        {
            get { return gorusmeAdi; }
            set
            {
                if (value == GorusmeAdi) return; gorusmeAdi = value;
                OnPropertyChanged("GorusmeAdi");
            }
        }

        private string aciklama { get; set; }
        public string Aciklama
        {
            get { return aciklama; }
            set
            {
                if (value == Aciklama) return; aciklama = value;
                OnPropertyChanged("Aciklama");
            }
        }

        private string gorusmeVeri { get; set; }
        public string GorusmeVeri
        {
            get { return gorusmeVeri; }
            set
            {
                if (value == GorusmeVeri) return; gorusmeVeri = value;
                OnPropertyChanged("GorusmeVeri");
            }
        }

        private bool gorusmeYapildi { get; set; }
        public bool GorusmeYapildi
        {
            get { return gorusmeYapildi; }
            set
            {
                if (value == GorusmeYapildi) return; gorusmeYapildi = value;
                OnPropertyChanged("GorusmeYapildi");
            }
        }

        public virtual Dava Dava { get; set; }
    }
}
