using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ZenSoftModel.Entities
{
    public class MyBaseEntity : INotifyPropertyChanged, IEntity
    {
        public MyBaseEntity()
        {
            ID = Guid.NewGuid();
            AktifMi = true;
        }

        private Guid _ID { get; set; }
        [Key]
        public Guid ID
        {
            get { return _ID; }
            set
            {
                if (value == ID) return; _ID = value;
                OnPropertyChanged("ID");
            }
        }

        private bool aktifMi { get; set; }
        [Required]
        public bool AktifMi
        {
            get { return aktifMi; }
            set
            {
                if (value == AktifMi) return; aktifMi = value;
                OnPropertyChanged("AktifMi");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
