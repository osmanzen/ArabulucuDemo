using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenSoftModel.DTO
{
    public static class TarafTipi
    {
        public const int Kisi = 0;
        public const int Sirket = 1;
        public const int Kurum = 2;
    }

    public static class TelefonTipi
    {
        public const int Sabit = 0;
        public const int Cep = 1;
        public const int Fax = 2;
    }

    public static class EvrakTipi
    {
        public const int DosyaKapakSayfasi = 1;
        public const int ToplantiDavet = 2;
        public const int UcretSozlesmesi = 3;
        public const int ToplantiTutanagi = 4;
        public const int ToplantiErtelemeTutanagi = 5;
        public const int AnlasmaTutanagi = 6;
        public const int BirdenFazlaAnlasmaTutanagi = 7;
        public const int KismiAnlasmaTutanagi = 8;
        public const int AnlasamamaTutanagi = 9;
        public const int SonTutanak = 10;
        public const int BasSavcilik = 11;
    }

    public class Evrak
    {
        public int EvrakTipi { get; set; }

        public string EvrakAdi { get; set; }
    }

    public class AnlasmaMetniGerekenler
    {
        public decimal NetKidemTazminati { get; set; }
        public decimal NetIhbarTazminati { get; set; }
        public decimal NetUcretAlacagi { get; set; }
        public decimal NetYillikIzinAlacagi { get; set; }
        public decimal FazlaCalismaAlacagi { get; set; }
        public decimal ResmiTatilCalisma { get; set; }
        public decimal NetTutar { get; set; }
        public string IBAN { get; set; }
        public DateTime AnlasmaTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public bool KismiAnlasma { get; set; }
    }
}
