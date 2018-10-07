using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("Buro")]
    public partial class Buro : MyBaseEntity
    {
        public Buro()
        {
            Davalari = new HashSet<Dava>();
            HesapBilgileri = new HashSet<HesapBilgileri>();
            TelefonBilgileri = new HashSet<TelefonBilgileri>();
        }

        private string adSoyad { get; set; }
        public string AdSoyad
        {
            get { return adSoyad; }
            set
            {
                if (value == AdSoyad) return; adSoyad = value;
                OnPropertyChanged("AdSoyad");
            }
        }

        private string tcKimlikNo { get; set; }
        public string TcKimlikNo
        {
            get { return tcKimlikNo; }
            set
            {
                if (value == TcKimlikNo) return; tcKimlikNo = value;
                OnPropertyChanged("TcKimlikNo");
            }
        }

        private string sicilNo { get; set; }
        public string SicilNo
        {
            get { return sicilNo; }
            set
            {
                if (value == SicilNo) return; sicilNo = value;
                OnPropertyChanged("SicilNo");
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


        private string ePosta { get; set; }
        public string EPosta
        {
            get { return ePosta; }
            set
            {
                if (value == EPosta) return; ePosta = value;
                OnPropertyChanged("EPosta");
            }
        }

        private string vergiNumarsi { get; set; }
        public string VergiNumarsi
        {
            get { return vergiNumarsi; }
            set
            {
                if (value == VergiNumarsi) return; vergiNumarsi = value;
                OnPropertyChanged("VergiNumarsi");
            }
        }

        private string komisyonIl { get; set; }
        public string KomisyonIl
        {
            get { return komisyonIl; }
            set
            {
                if (value == KomisyonIl) return; komisyonIl = value;
                OnPropertyChanged("KomisyonIl");
            }
        }

        private string komisyonIlce { get; set; }
        public string KomisyonIlce
        {
            get { return komisyonIlce; }
            set
            {
                if (value == KomisyonIlce) return; komisyonIlce = value;
                OnPropertyChanged("KomisyonIlce");
            }
        }

        public virtual ICollection<Dava> Davalari { get; set; }

        public virtual ICollection<HesapBilgileri> HesapBilgileri { get; set; }

        public virtual ICollection<TelefonBilgileri> TelefonBilgileri { get; set; }
    }
}
