using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("Taraf")]
    public partial class Taraf : MyBaseEntity
    {
        public Taraf()
        {
            Davalari = new HashSet<Dava>();
            KarsiTarafOlduklari = new HashSet<KarsiTaraf>();
            Vekilleri = new HashSet<Vekil>();
            IlgiliKarsiTaraflar = new HashSet<KarsiTaraf>();
            TelefonBilgileri = new HashSet<TelefonBilgileri>();
        }

        private string tCKimlikNo { get; set; }
        public string TCKimlikNo
        {
            get { return tCKimlikNo; }
            set
            {
                if (value == TCKimlikNo) return; tCKimlikNo = value;
                OnPropertyChanged("TCKimlikNo");
            }
        }

        private string tarafAdi { get; set; }
        public string TarafAdi
        {
            get { return tarafAdi; }
            set
            {
                if (value == TarafAdi) return; tarafAdi = value;
                OnPropertyChanged("TarafAdi");
            }
        }

        private string adres { get; set; }
        public string Adres
        {
            get { return adres; }
            set
            {
                if (value == Adres) return; adres = value;
                OnPropertyChanged("Adres");
            }
        }

        private int? kisiSirketKurum { get; set; }
        public int? KisiSirketKurum
        {
            get { return kisiSirketKurum; }
            set
            {
                if (value == KisiSirketKurum) return; kisiSirketKurum = value;
                OnPropertyChanged("KisiSirketKurum");
            }
        }

        private string eposta { get; set; }
        public string Eposta
        {
            get { return eposta; }
            set
            {
                if (value == Eposta) return; eposta = value;
                OnPropertyChanged("Eposta");
            }
        }


        public virtual ICollection<Dava> Davalari { get; set; }

        public virtual ICollection<KarsiTaraf> KarsiTarafOlduklari { get; set; }

        public virtual ICollection<Vekil> Vekilleri { get; set; }

        public virtual ICollection<KarsiTaraf> IlgiliKarsiTaraflar { get; set; }

        public virtual ICollection<TelefonBilgileri> TelefonBilgileri { get; set; }
    }
}
