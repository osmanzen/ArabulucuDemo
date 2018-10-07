using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace ZenSoftModel.Entities
{
    [Table("Heyet")]
    public partial class Heyet : MyBaseEntity
    {
        public Heyet()
        {
            KarsiTaraflar = new HashSet<KarsiTaraf>();
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

        private string görevi { get; set; }
        public string Görevi
        {
            get { return görevi; }
            set
            {
                if (value == Görevi) return; görevi = value;
                OnPropertyChanged("Görevi");
            }
        }


        public virtual ICollection<KarsiTaraf> KarsiTaraflar { get; set; }
    }
}
