using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("Vekil")]
    public partial class Vekil : MyBaseEntity
    {
        public Vekil()
        {
            Davalari = new HashSet<Dava>();
            KarsiTarafVekillikleri = new HashSet<KarsiTaraf>();
            VekiliOlduguTaraflar = new HashSet<Taraf>();
            TelefonBilgileri = new HashSet<TelefonBilgileri>();
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

        private string adiSoyadi { get; set; }
        public string AdiSoyadi
        {
            get { return adiSoyadi; }
            set
            {
                if (value == AdiSoyadi) return; adiSoyadi = value;
                OnPropertyChanged("AdiSoyadi");
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

        private string buroIl { get; set; }
        public string BuroIl
        {
            get { return buroIl; }
            set
            {
                if (value == BuroIl) return; buroIl = value;
                OnPropertyChanged("BuroIl");
            }
        }

        private string buroIlce { get; set; }
        public string BuroIlce
        {
            get { return buroIlce; }
            set
            {
                if (value == BuroIlce) return; buroIlce = value;
                OnPropertyChanged("BuroIlce");
            }
        }

        private string webAdresi { get; set; }
        public string WebAdresi
        {
            get { return webAdresi; }
            set
            {
                if (value == WebAdresi) return; webAdresi = value;
                OnPropertyChanged("WebAdresi");
            }
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


        public virtual ICollection<Dava> Davalari { get; set; }

        public virtual ICollection<KarsiTaraf> KarsiTarafVekillikleri { get; set; }

        public virtual ICollection<Taraf> VekiliOlduguTaraflar { get; set; }

        public virtual ICollection<TelefonBilgileri> TelefonBilgileri { get; set; }
    }
}
