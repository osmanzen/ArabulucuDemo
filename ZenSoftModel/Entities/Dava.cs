using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenSoftModel.Entities
{
    [Table("Dava")]
    public partial class Dava : MyBaseEntity
    {
        public Dava()
        {
            DavaKonulari = new HashSet<DavaKonusu>();
            Gorusmeler = new HashSet<Gorusme>();
            KarsiTaraflar = new HashSet<KarsiTaraf>();
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

        private string buroDosyaNo { get; set; }
        public string BuroDosyaNo
        {
            get { return buroDosyaNo; }
            set
            {
                if (value == BuroDosyaNo) return; buroDosyaNo = value;
                OnPropertyChanged("BuroDosyaNo");
            }
        }
        
        private string arabuluculukDosyaNo;
        public string ArabuluculukDosyaNo
        {
            get { return arabuluculukDosyaNo; }
            set
            {
                if (value == ArabuluculukDosyaNo) return; arabuluculukDosyaNo = value;
                OnPropertyChanged("ArabuluculukDosyaNo");
            }
        }

        private string arabuluculukBurosu { get; set; }
        public string ArabuluculukBurosu
        {
            get { return arabuluculukBurosu; }
            set
            {
                if (value == ArabuluculukBurosu) return; arabuluculukBurosu = value;
                OnPropertyChanged("ArabuluculukBurosu");
            }
        }

        private string calisilanYer { get; set; }
        public string CalisilanYer
        {
            get { return calisilanYer; }
            set
            {
                if (value == CalisilanYer) return; calisilanYer = value;
                OnPropertyChanged("CalisilanYer");
            }
        }

        private DateTime? basvuruTarihi { get; set; }
        public DateTime? BasvuruTarihi
        {
            get { return basvuruTarihi; }
            set
            {
                if (value == BasvuruTarihi) return; basvuruTarihi = value;
                OnPropertyChanged("BasvuruTarihi");
            }
        }

        private DateTime? bitisTarihi { get; set; }
        public DateTime? BitisTarihi
        {
            get { return bitisTarihi; }
            set
            {
                if (value == BitisTarihi) return; bitisTarihi = value;
                OnPropertyChanged("BitisTarihi");
            }
        }


        private Guid? basvurucuID { get; set; }
        public Guid? BasvurucuID    
        {
            get { return basvurucuID; }
            set
            {
                if (value == BasvurucuID) return; basvurucuID = value;
                OnPropertyChanged("BasvurucuID");
            }
        }

        private Guid? basvurucuVekilID { get; set; }
        public Guid? BasvurucuVekilID
        {
            get { return basvurucuVekilID; }
            set
            {
                if (value == BasvurucuVekilID) return; basvurucuVekilID = value;
                OnPropertyChanged("BasvurucuVekilID");
            }
        }

        private string basvurucuNot { get; set; }
        public string BasvurucuNot
        {
            get { return basvurucuNot; }
            set
            {
                if (value == BasvurucuNot) return; basvurucuNot = value;
                OnPropertyChanged("BasvurucuNot");
            }
        }

        private string durum { get; set; }
        public string Durum
        {
            get { return durum; }
            set
            {
                if (value == Durum) return; durum = value;
                OnPropertyChanged("Durum");
            }
        }


        private string sonuc { get; set; }
        public string Sonuc
        {
            get { return sonuc; }
            set
            {
                if (value == Sonuc) return; sonuc = value;
                OnPropertyChanged("Sonuc");
            }
        }

        public virtual Taraf Basvurucu { get; set; }

        public virtual Vekil BasvurucuVekili { get; set; }

        public virtual Buro Burosu { get; set; }

        public virtual ICollection<DavaKonusu> DavaKonulari { get; set; }

        public virtual ICollection<Gorusme> Gorusmeler { get; set; }

        public virtual ICollection<KarsiTaraf> KarsiTaraflar { get; set; }
    }
}
