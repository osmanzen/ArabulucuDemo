using Arabulucu.MessageForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu
{
    public static class ArabulucuHelper
    {
        static KayitBasariliForm kbForm;

        public static void KayitBasariliFormGetir()
        {
            if (kbForm == null)
            {
                kbForm = new KayitBasariliForm();
                kbForm.ShowDialog();
            }
            else
            {
                kbForm = null;
                kbForm = new KayitBasariliForm();
                kbForm.ShowDialog();
            }
        }

        public static void ButtonImageSearchIcon(ButtonEdit gelenBtn)
        {
            gelenBtn.Properties.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            gelenBtn.Properties.Buttons[0].Image = global::Arabulucu.Properties.Resources.icons8_search_16;
        }

        static List<Evrak> evrakListesi;
        public static List<Evrak> EvrakListesi()
        {
            if (evrakListesi == null)
            {
                evrakListesi = new List<Evrak>();

                Evrak yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.DosyaKapakSayfasi, EvrakAdi = "Dosya Kapak Sayfası" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.ToplantiDavet, EvrakAdi = "Toplantıya Davet Mektubu" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.UcretSozlesmesi, EvrakAdi = "Arabuluculuk Ücret Sözleşmesi" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.ToplantiTutanagi, EvrakAdi = "Toplantı Tutanağı" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.ToplantiErtelemeTutanagi, EvrakAdi = "Toplantı Ertelenmesi Tutanağı" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.AnlasmaTutanagi, EvrakAdi = "Anlaşma Tutanağı" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.AnlasamamaTutanagi, EvrakAdi = "Anlaşamama Tutanağı" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.SonTutanak, EvrakAdi = "Son Tutanak" };
                evrakListesi.Add(yeniEvrak);

                yeniEvrak = new Evrak() { EvrakTipi = EvrakTipi.BasSavcilik, EvrakAdi = "Başsavcılık Son Tutanağı" };
                evrakListesi.Add(yeniEvrak);
            }

            return evrakListesi;
        }
    }
}
