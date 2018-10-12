using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenSoftModel.Entities
{
    [Table("SirketYetkilisi")]
    public class SirketYetkilisi : MyBaseEntity
    {
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

        private string yetkiliAdi { get; set; }
        public string YetkiliAdi
        {
            get { return yetkiliAdi; }
            set
            {
                if (value == YetkiliAdi) return; yetkiliAdi = value;
                OnPropertyChanged("YetkiliAdi");
            }
        }

        private string gorevi { get; set; }
        public string Gorevi
        {
            get { return gorevi; }
            set
            {
                if (value == Gorevi) return; gorevi = value;
                OnPropertyChanged("Gorevi");
            }
        }

        public virtual ICollection<KarsiTaraf> KarsiTaraf { get; set; }
    }
}
