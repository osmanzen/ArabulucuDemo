using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;
using System.Globalization;
using System;

namespace Arabulucu.ArabulucuHelpers
{
    public static class EvrakOlusturucu
    {
        static Application wordApp;
        static object missing;
        static object readOnly;
        static object fileName;
        static Document doc;
        static string davetGirisText;
        static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arabulucu Evraklar\";



        //public static string dosyaKapakSayfasi(Dava _dava)
        //{
        //    _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Dosya Kapak Sayfası.docx";

        //    if (!File.Exists(_path))
        //    {
        //        System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
        //        return null;
        //    }
        //    else
        //    {
        //        wordApp = new Application();

        //        missing = System.Reflection.Missing.Value;
        //        readOnly = false;
        //        fileName = _path;

        //        doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
        //        ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
        //        ref missing, ref missing, ref missing, ref missing, ref missing);

        //        object dosyaNo = "dosyaNo";
        //        doc.Bookmarks.get_Item(ref dosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

        //        object arabulucuSehir = "arabulucuSehir";
        //        doc.Bookmarks.get_Item(ref arabulucuSehir).Range.Text = _dava.ArabuluculukBurosu.ToUpper();

        //        object buroDosyaNo = "buroDosyaNo";
        //        doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

        //        object basvuruTarihi = "basvuruTarihi";
        //        doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

        //        object bitisTarihi = "bitisTarihi";
        //        doc.Bookmarks.get_Item(ref bitisTarihi).Range.Text = _dava.BasvuruTarihi.Value.AddMonths(1).ToShortDateString();

        //        object basvurucu = "basvurucu";
        //        doc.Bookmarks.get_Item(ref basvurucu).Range.Text = _dava.Basvurucu.TarafAdi.ToUpper();

        //        object basvurucuVekili = "basvurucuVekili";
        //        doc.Bookmarks.get_Item(ref basvurucuVekili).Range.Text = _dava.BasvurucuVekili.AdiSoyadi.ToUpper();

        //        object karsiTaraf = "karsiTaraf";
        //        string karsiTarafText = "";
        //        List<KarsiTaraf> karsiTarafList = _dava.KarsiTaraflar.ToList();

        //        for (int i = 0; i < karsiTarafList.Count; i++)
        //        {
        //            if (i == 0)
        //            {
        //                karsiTarafText += karsiTarafList[i].Taraf.TarafAdi.ToUpper();
        //            }
        //            else
        //            {
        //                karsiTarafText += ",\n" + karsiTarafList[i].Taraf.TarafAdi.ToUpper();
        //            }
        //        }
        //        doc.Bookmarks.get_Item(ref karsiTaraf).Range.Text = karsiTarafText;

        //        object basvuruTuru = "basvuruTuru";
        //        doc.Bookmarks.get_Item(ref basvuruTuru).Range.Text = _dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi.ToUpper();

        //        object basvuruKonu = "basvuruKonu";
        //        string basvuruKonuText = "";
        //        List<DavaKonusu> basvuruKonuList = _dava.DavaKonulari.ToList();

        //        for (int i = 0; i < basvuruKonuList.Count; i++)
        //        {
        //            if (i == 0)
        //            {
        //                basvuruKonuText += basvuruKonuList[i].KonuAdi.ToUpper();
        //            }
        //            else
        //            {
        //                basvuruKonuText += ",\n" + basvuruKonuList[i].KonuAdi.ToUpper();
        //            }
        //        }
        //        doc.Bookmarks.get_Item(ref basvuruKonu).Range.Text = basvuruKonuText;

        //        string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".docx");

        //        doc.SaveAs2(path);

        //        doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
        //        doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

        //        wordApp.Quit();

        //        return path;
        //    }
        //}

        public static string ToplantiyaDavet(Dava _dava, Taraf karsiTaraf, Taraf davetEdilen, DateTime tTarihi)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Toplantıya Davet Mektubu.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                bool karsiTarafMi = true;
                if (_dava.Basvurucu == davetEdilen)
                {
                    davetGirisText = "Vekiliniz " + _dava.BasvurucuVekili.AdiSoyadi + " tarafından " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.ArabuluculukBurosu) + " Arabuluculuk Bürosuna İşveren " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(karsiTaraf.TarafAdi) + " ile aranızdaki Hukuki Uyuşmazlığın Dava Şartı Arabuluculuk Yolu ile çözümü için";
                    karsiTarafMi = false;
                }

                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object davetEdilenAdres = "davetEdilenAdres";
                doc.Bookmarks.get_Item(ref davetEdilenAdres).Range.Text = davetEdilen.Adres;

                if (!karsiTarafMi)
                {
                    object davetEdilenAdi = "davetEdilenAdi";
                    doc.Bookmarks.get_Item(ref davetEdilenAdi).Range.Text = davetEdilen.TarafAdi + "-" + davetEdilen.TCKimlikNo;

                    object girisTexti = "girisTexti";
                    doc.Bookmarks.get_Item(ref girisTexti).Range.Text = davetGirisText;
                }

                if (karsiTarafMi)
                {
                    object davetEdilenAdi = "davetEdilenAdi";
                    doc.Bookmarks.get_Item(ref davetEdilenAdi).Range.Text = davetEdilen.TarafAdi;

                    object basvurucuAdiSoyadi = "basvurucuAdiSoyadi";
                    doc.Bookmarks.get_Item(ref basvurucuAdiSoyadi).Range.Text = _dava.Basvurucu.TarafAdi;


                    object basvurucuVekil = "basvurucuVekil";
                    doc.Bookmarks.get_Item(ref basvurucuVekil).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                    object arabuluculukSehir = "arabuluculukSehir";
                    doc.Bookmarks.get_Item(ref arabuluculukSehir).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.ArabuluculukBurosu);
                }

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object sicilNo = "sicilNo";
                doc.Bookmarks.get_Item(ref sicilNo).Range.Text = _dava.Burosu.SicilNo;

                object karsiTarafAdi2 = "karsiTarafAdi2";
                doc.Bookmarks.get_Item(ref karsiTarafAdi2).Range.Text = karsiTaraf.TarafAdi;

                object toplantiTarihi = "toplantiTarihi";
                doc.Bookmarks.get_Item(ref toplantiTarihi).Range.Text = (String.Format("{0:D}", tTarihi)).ToUpper() + " GÜNÜ, SAAT " + (String.Format("{0:t}", tTarihi));

                object buroAdres = "buroAdres";
                doc.Bookmarks.get_Item(ref buroAdres).Range.Text = _dava.Burosu.Adres;

                object duzenlemeTarihi = "duzenlemeTarihi";
                doc.Bookmarks.get_Item(ref duzenlemeTarihi).Range.Text = DateTime.Now.ToShortDateString();

                object uzmanArabulucu = "uzmanArabulucu";
                doc.Bookmarks.get_Item(ref uzmanArabulucu).Range.Text = _dava.Burosu.AdSoyad + " (" + _dava.Burosu.SicilNo + ")";

                object arabuluculukBurosu = "arabuluculukBurosu";
                doc.Bookmarks.get_Item(ref arabuluculukBurosu).Range.Text = _dava.ArabuluculukBurosu.ToUpper();

                object buroDosyaNo2 = "buroDosyaNo2";
                doc.Bookmarks.get_Item(ref buroDosyaNo2).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo2 = "arabulucuDosyaNo2";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo2).Range.Text = _dava.ArabuluculukDosyaNo;

                object basvuruTarihi2 = "basvuruTarihi2";
                doc.Bookmarks.get_Item(ref basvuruTarihi2).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object calisilanYer = "calisilanYer";
                doc.Bookmarks.get_Item(ref calisilanYer).Range.Text = _dava.CalisilanYer.ToUpper();

                object basvuruTuru = "basvuruTuru";
                doc.Bookmarks.get_Item(ref basvuruTuru).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi);

                object basvuruKonusu = "basvuruKonusu";
                string txt = "";
                List<DavaKonusu> davaKonulariList = _dava.DavaKonulari.ToList();
                for (int i = 0; i < davaKonulariList.Count; i++)
                {
                    if (i == 0)
                    {
                        txt += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                    else
                    {
                        txt += ",\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                }
                doc.Bookmarks.get_Item(ref basvuruKonusu).Range.Text = txt;

                object sicilNo3 = "sicilNo3";
                doc.Bookmarks.get_Item(ref sicilNo3).Range.Text = _dava.Burosu.SicilNo;

                object vergiNo = "vergiNo";
                doc.Bookmarks.get_Item(ref vergiNo).Range.Text = _dava.Burosu.VergiNumarsi;

                object gorevYaptigiKomisyon = "gorevYaptigiKomisyon";
                doc.Bookmarks.get_Item(ref gorevYaptigiKomisyon).Range.Text = _dava.Burosu.KomisyonIl.ToUpper() + "/" + _dava.Burosu.KomisyonIlce.ToUpper();

                object buroAdres2 = "buroAdres2";
                doc.Bookmarks.get_Item(ref buroAdres2).Range.Text = _dava.Burosu.Adres;

                object buroTel = "buroTel";
                doc.Bookmarks.get_Item(ref buroTel).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara;

                object buroCep = "buroCep";
                doc.Bookmarks.get_Item(ref buroCep).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara;

                object buroFax = "buroFax";
                doc.Bookmarks.get_Item(ref buroFax).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara;

                object buroMail = "buroMail";
                doc.Bookmarks.get_Item(ref buroMail).Range.Text = _dava.Burosu.EPosta;

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string ToplantiyaDavet(Dava _dava, Taraf karsiTaraf, Vekil davetEdilen, DateTime tTarihi)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Toplantıya Davet Mektubu.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                davetGirisText = "Başvurucu - " + _dava.Basvurucu.TarafAdi + " Vekili olarak tarafınızdan " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.ArabuluculukBurosu) + " Arabuluculuk Bürosuna İşveren " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(karsiTaraf.TarafAdi) + " ile aranızdaki Hukuki Uyuşmazlığın Dava Şartı Arabuluculuk Yolu ile çözümü için";

                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object davetEdilenAdres = "davetEdilenAdres";
                doc.Bookmarks.get_Item(ref davetEdilenAdres).Range.Text = davetEdilen.Adres;

                object davetEdilenAdi = "davetEdilenAdi";
                doc.Bookmarks.get_Item(ref davetEdilenAdi).Range.Text = davetEdilen.AdiSoyadi + "-" + davetEdilen.TCKimlikNo;

                object girisTexti = "girisTexti";
                doc.Bookmarks.get_Item(ref girisTexti).Range.Text = davetGirisText;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object sicilNo = "sicilNo";
                doc.Bookmarks.get_Item(ref sicilNo).Range.Text = _dava.Burosu.SicilNo;

                object karsiTarafAdi2 = "karsiTarafAdi2";
                doc.Bookmarks.get_Item(ref karsiTarafAdi2).Range.Text = karsiTaraf.TarafAdi;

                object toplantiTarihi = "toplantiTarihi";
                doc.Bookmarks.get_Item(ref toplantiTarihi).Range.Text = (String.Format("{0:D}", tTarihi)).ToUpper() + " GÜNÜ, SAAT " + (String.Format("{0:t}", tTarihi));

                object buroAdres = "buroAdres";
                doc.Bookmarks.get_Item(ref buroAdres).Range.Text = _dava.Burosu.Adres;

                object duzenlemeTarihi = "duzenlemeTarihi";
                doc.Bookmarks.get_Item(ref duzenlemeTarihi).Range.Text = DateTime.Now.ToShortDateString();

                object uzmanArabulucu = "uzmanArabulucu";
                doc.Bookmarks.get_Item(ref uzmanArabulucu).Range.Text = _dava.Burosu.AdSoyad + " (" + _dava.Burosu.SicilNo + ")";

                object arabuluculukBurosu = "arabuluculukBurosu";
                doc.Bookmarks.get_Item(ref arabuluculukBurosu).Range.Text = _dava.ArabuluculukBurosu.ToUpper();

                object buroDosyaNo2 = "buroDosyaNo2";
                doc.Bookmarks.get_Item(ref buroDosyaNo2).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo2 = "arabulucuDosyaNo2";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo2).Range.Text = _dava.ArabuluculukDosyaNo;

                object basvuruTarihi2 = "basvuruTarihi2";
                doc.Bookmarks.get_Item(ref basvuruTarihi2).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object calisilanYer = "calisilanYer";
                doc.Bookmarks.get_Item(ref calisilanYer).Range.Text = _dava.CalisilanYer.ToUpper();

                object basvuruTuru = "basvuruTuru";
                doc.Bookmarks.get_Item(ref basvuruTuru).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi);

                object basvuruKonusu = "basvuruKonusu";
                string txt = "";
                List<DavaKonusu> davaKonulariList = _dava.DavaKonulari.ToList();
                for (int i = 0; i < davaKonulariList.Count; i++)
                {
                    if (i == 0)
                    {
                        txt += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                    else
                    {
                        txt += ",\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                }
                doc.Bookmarks.get_Item(ref basvuruKonusu).Range.Text = txt;

                object sicilNo3 = "sicilNo3";
                doc.Bookmarks.get_Item(ref sicilNo3).Range.Text = _dava.Burosu.SicilNo;

                object vergiNo = "vergiNo";
                doc.Bookmarks.get_Item(ref vergiNo).Range.Text = _dava.Burosu.VergiNumarsi;

                object gorevYaptigiKomisyon = "gorevYaptigiKomisyon";
                doc.Bookmarks.get_Item(ref gorevYaptigiKomisyon).Range.Text = _dava.Burosu.KomisyonIl.ToUpper() + "/" + _dava.Burosu.KomisyonIlce.ToUpper();

                object buroAdres2 = "buroAdres2";
                doc.Bookmarks.get_Item(ref buroAdres2).Range.Text = _dava.Burosu.Adres;

                object buroTel = "buroTel";
                doc.Bookmarks.get_Item(ref buroTel).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara;

                object buroCep = "buroCep";
                doc.Bookmarks.get_Item(ref buroCep).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara;

                object buroFax = "buroFax";
                doc.Bookmarks.get_Item(ref buroFax).Range.Text = _dava.Burosu.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara;

                object buroMail = "buroMail";
                doc.Bookmarks.get_Item(ref buroMail).Range.Text = _dava.Burosu.EPosta;

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string UcretSozlesmesi(Dava _dava, HesapBilgileri gelenHesap, DateTime gelenTarih)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Arabuluculuk Ücret Sözleşmesi.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object arabulucuSehir = "arabulucuSehir";
                doc.Bookmarks.get_Item(ref arabulucuSehir).Range.Text = _dava.ArabuluculukBurosu;

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object arabulucuAdi = "arabulucuAdi";
                doc.Bookmarks.get_Item(ref arabulucuAdi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuTC = "arabulucuTC";
                doc.Bookmarks.get_Item(ref arabulucuTC).Range.Text = _dava.Burosu.TcKimlikNo;

                object arabulucuSicil = "arabulucuSicil";
                doc.Bookmarks.get_Item(ref arabulucuSicil).Range.Text = _dava.Burosu.SicilNo;

                object arabulucuAdres = "arabulucuAdres";
                doc.Bookmarks.get_Item(ref arabulucuAdres).Range.Text = _dava.Burosu.Adres;

                string iletisimText = "";
                foreach (var item in _dava.Burosu.TelefonBilgileri)
                {
                    if (item.SabitCepFax == TelefonTipi.Sabit)
                        iletisimText += "Tel." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Fax)
                        iletisimText += "Fax." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Cep)
                        iletisimText += "GSM.." + item.Numara;

                    iletisimText += "-";
                }
                object arabulucuIletisim = "arabulucuIletisim";
                doc.Bookmarks.get_Item(ref arabulucuIletisim).Range.Text = iletisimText;

                if (_dava.Burosu.EPosta != null)
                {
                    object arabulucuEposta = "arabulucuEposta";
                    doc.Bookmarks.get_Item(ref arabulucuEposta).Range.Text = _dava.Burosu.EPosta;
                }

                object taraf1adi = "taraf1adi";
                doc.Bookmarks.get_Item(ref taraf1adi).Range.Text = _dava.Basvurucu.TarafAdi;

                object taraf1TC = "taraf1TC";
                doc.Bookmarks.get_Item(ref taraf1TC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object taraf1Adres = "taraf1Adres";
                doc.Bookmarks.get_Item(ref taraf1Adres).Range.Text = _dava.Basvurucu.Adres;

                object taraf1Vekili = "taraf1Vekili";
                doc.Bookmarks.get_Item(ref taraf1Vekili).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object taraf1vekilAdresi = "taraf1vekilAdresi";
                doc.Bookmarks.get_Item(ref taraf1vekilAdresi).Range.Text = _dava.BasvurucuVekili.Adres;

                List<Taraf> taraflarList = new List<Taraf>();
                foreach (var taraf in _dava.KarsiTaraflar)
                {
                    taraflarList.Add(taraf.Taraf);
                }

                object taraf2Adi = "taraf2Adi";
                doc.Bookmarks.get_Item(ref taraf2Adi).Range.Text = taraflarList[0].TarafAdi;

                if (taraflarList[0].Adres != null)
                {
                    object taraf2Adresi = "taraf2Adresi";
                    doc.Bookmarks.get_Item(ref taraf2Adresi).Range.Text = taraflarList[0].Adres;
                }

                //DİĞER TARAFLAR GELECEK


                object buroAvukatAdi = "buroAvukatAdi";
                doc.Bookmarks.get_Item(ref buroAvukatAdi).Range.Text = _dava.Burosu.AdSoyad;

                object taraf1Adi2 = "taraf1Adi2";
                doc.Bookmarks.get_Item(ref taraf1Adi2).Range.Text = _dava.Basvurucu.TarafAdi;

                object bankaAdi = "bankaAdi";
                doc.Bookmarks.get_Item(ref bankaAdi).Range.Text = gelenHesap.BankaAdi;

                object bankaSube = "bankaSube";
                doc.Bookmarks.get_Item(ref bankaSube).Range.Text = gelenHesap.SubeAdi;

                object bankaIBAN = "bankaIBAN";
                doc.Bookmarks.get_Item(ref bankaIBAN).Range.Text = gelenHesap.IBAN;

                object sozlesmeTarih = "sozlesmeTarih";
                doc.Bookmarks.get_Item(ref sozlesmeTarih).Range.Text = gelenTarih.ToShortDateString();

                object taraf1adi3 = "taraf1adi3";
                doc.Bookmarks.get_Item(ref taraf1adi3).Range.Text = _dava.Basvurucu.TarafAdi;

                object taraf1Vekili2 = "taraf1Vekili2";
                doc.Bookmarks.get_Item(ref taraf1Vekili2).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object arabulucuAdi2 = "arabulucuAdi2";
                doc.Bookmarks.get_Item(ref arabulucuAdi2).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuSicil2 = "arabulucuSicil2";
                doc.Bookmarks.get_Item(ref arabulucuSicil2).Range.Text = "(" + _dava.Burosu.SicilNo + ")";

                //DİĞER TARAFLAR GELECEK


                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string ToplantiTutanagi(Dava _dava)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Toplantı Tutanağı.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object basvurucuAdi = "basvurucuAdi";
                doc.Bookmarks.get_Item(ref basvurucuAdi).Range.Text = _dava.Basvurucu.TarafAdi;

                object basvurucuTC = "basvurucuTC";
                doc.Bookmarks.get_Item(ref basvurucuTC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object basvurucuVekil = "basvurucuVekil";
                doc.Bookmarks.get_Item(ref basvurucuVekil).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                if (_dava.BasvurucuVekili.BuroIl != null || _dava.BasvurucuVekili.BuroIlce != null)
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = _dava.BasvurucuVekili.BuroIl + " Barosu Sicil No." + _dava.BasvurucuVekili.SicilNo;
                }
                else if (_dava.BasvurucuVekili.SicilNo != null)
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = "Sicil No." + _dava.BasvurucuVekili.SicilNo;
                }
                else
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = "";
                }

                List<Taraf> karsiTarafList = new List<Taraf>();
                foreach (var karsiTaraf in _dava.KarsiTaraflar)
                {
                    karsiTarafList.Add(karsiTaraf.Taraf);
                }

                object karsiTaraf1adi = "karsiTaraf1adi";
                doc.Bookmarks.get_Item(ref karsiTaraf1adi).Range.Text = karsiTarafList[0].TarafAdi;

                string heyetTxt = "";
                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri != null)
                {
                    int i = 1;
                    foreach (var heyet in _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri)
                    {
                        heyetTxt += i + "- " + heyet.AdiSoyadi + " (TCKN. " + heyet.TCKimlikNo + ")\n";
                        i++;
                    }
                }
                object karsiTaraf1HeyetListesi = "karsiTaraf1HeyetListesi";
                doc.Bookmarks.get_Item(ref karsiTaraf1HeyetListesi).Range.Text = heyetTxt;

                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Vekil != null)
                {
                    object karsiTaraf1Vekili = "karsiTaraf1Vekili";
                    doc.Bookmarks.get_Item(ref karsiTaraf1Vekili).Range.Text = _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Vekil.AdiSoyadi;
                }
                else
                {
                    object karsiTaraf1Vekili = "karsiTaraf1Vekili";
                    doc.Bookmarks.get_Item(ref karsiTaraf1Vekili).Range.Text = "";
                }

                //TOPLANTI TARİH SAATİ GELECEK
                //object toplantiTarihSaat = "toplantiTarihSaat";
                //doc.Bookmarks.get_Item(ref toplantiTarihSaat).Range.Text = "";

                //TOPLANTI TARİH  GELECEK
                //object toplantiTarihi = "toplantiTarihi";
                //doc.Bookmarks.get_Item(ref toplantiTarihi).Range.Text = "";

                //TOPLANTI  SAATİ GELECEK
                //object toplantiSaati = "toplantiSaati";
                //doc.Bookmarks.get_Item(ref toplantiSaati).Range.Text = "";

                object basvurucuAdi2 = "basvurucuAdi2";
                doc.Bookmarks.get_Item(ref basvurucuAdi2).Range.Text = _dava.Basvurucu.TarafAdi;

                object basvurucuVekilAdi = "basvurucuVekilAdi";
                doc.Bookmarks.get_Item(ref basvurucuVekilAdi).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object arabulucuAdiSoyadi = "arabulucuAdiSoyadi";
                doc.Bookmarks.get_Item(ref arabulucuAdiSoyadi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuSicilNo = "arabulucuSicilNo";
                doc.Bookmarks.get_Item(ref arabulucuSicilNo).Range.Text = _dava.Burosu.SicilNo;

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string ToplantiErtelemeTutanagi(Dava _dava, DateTime yeniTarih)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Toplantı Ertelenmesi Tutanağı.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object basvurucuAdi = "basvurucuAdi";
                doc.Bookmarks.get_Item(ref basvurucuAdi).Range.Text = _dava.Basvurucu.TarafAdi;

                object basvurucuTC = "basvurucuTC";
                doc.Bookmarks.get_Item(ref basvurucuTC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object basvurucuVekil = "basvurucuVekil";
                doc.Bookmarks.get_Item(ref basvurucuVekil).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                if (_dava.BasvurucuVekili.BuroIl != null || _dava.BasvurucuVekili.BuroIlce != null)
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = _dava.BasvurucuVekili.BuroIl + " Barosu Sicil No." + _dava.BasvurucuVekili.SicilNo;
                }
                else if (_dava.BasvurucuVekili.SicilNo != null)
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = "Sicil No." + _dava.BasvurucuVekili.SicilNo;
                }
                else
                {
                    object basvurucuVekilBaroNo = "basvurucuVekilBaroNo";
                    doc.Bookmarks.get_Item(ref basvurucuVekilBaroNo).Range.Text = "";
                }

                List<Taraf> karsiTarafList = new List<Taraf>();
                foreach (var karsiTaraf in _dava.KarsiTaraflar)
                {
                    karsiTarafList.Add(karsiTaraf.Taraf);
                }

                object karsiTaraf1adi = "karsiTaraf1adi";
                doc.Bookmarks.get_Item(ref karsiTaraf1adi).Range.Text = karsiTarafList[0].TarafAdi;

                string heyetTxt = "";
                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri != null)
                {
                    int i = 1;
                    foreach (var heyet in _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri)
                    {
                        heyetTxt += i + "- " + heyet.AdiSoyadi + " (TCKN. " + heyet.TCKimlikNo + ")\n";
                        i++;
                    }
                }
                object karsiTaraf1HeyetListesi = "karsiTaraf1HeyetListesi";
                doc.Bookmarks.get_Item(ref karsiTaraf1HeyetListesi).Range.Text = heyetTxt;

                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Vekil != null)
                {
                    object karsiTaraf1Vekili = "karsiTaraf1Vekili";
                    doc.Bookmarks.get_Item(ref karsiTaraf1Vekili).Range.Text = _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Vekil.AdiSoyadi;
                }
                else
                {
                    object karsiTaraf1Vekili = "karsiTaraf1Vekili";
                    doc.Bookmarks.get_Item(ref karsiTaraf1Vekili).Range.Text = "";
                }

                //TOPLANTI TARİH SAATİ GELECEK
                //object toplantiTarihSaat = "toplantiTarihSaat";
                //doc.Bookmarks.get_Item(ref toplantiTarihSaat).Range.Text = "";

                //TOPLANTI TARİH  GELECEK
                //object toplantiTarihi = "toplantiTarihi";
                //doc.Bookmarks.get_Item(ref toplantiTarihi).Range.Text = "";

                //TOPLANTI  SAATİ GELECEK
                //object toplantiSaati = "toplantiSaati";
                //doc.Bookmarks.get_Item(ref toplantiSaati).Range.Text = "";

                object yeniToplantiGunu = "yeniToplantiGunu";
                doc.Bookmarks.get_Item(ref yeniToplantiGunu).Range.Text = (String.Format("{0:D}", yeniTarih));

                object yeniToplantiSaati = "yeniToplantiSaati";
                doc.Bookmarks.get_Item(ref yeniToplantiSaati).Range.Text = (String.Format("{0:t}", yeniTarih));

                object basvurucuAdi2 = "basvurucuAdi2";
                doc.Bookmarks.get_Item(ref basvurucuAdi2).Range.Text = _dava.Basvurucu.TarafAdi;

                object basvurucuVekilAdi = "basvurucuVekilAdi";
                doc.Bookmarks.get_Item(ref basvurucuVekilAdi).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object arabulucuAdiSoyadi = "arabulucuAdiSoyadi";
                doc.Bookmarks.get_Item(ref arabulucuAdiSoyadi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuSicilNo = "arabulucuSicilNo";
                doc.Bookmarks.get_Item(ref arabulucuSicilNo).Range.Text = _dava.Burosu.SicilNo;

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string AnlasmaTutanagi(Dava _dava, string gelenMetin, DateTime gelenBitisTarihi, DateTime gelenOdemeTarihi)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Anlaşma Tutanağı.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object arabulucuSehir = "arabulucuSehir";
                doc.Bookmarks.get_Item(ref arabulucuSehir).Range.Text = _dava.ArabuluculukBurosu;

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object arabulucuAdi = "arabulucuAdi";
                doc.Bookmarks.get_Item(ref arabulucuAdi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuTC = "arabulucuTC";
                doc.Bookmarks.get_Item(ref arabulucuTC).Range.Text = _dava.Burosu.TcKimlikNo;

                object arabulucuSicil = "arabulucuSicil";
                doc.Bookmarks.get_Item(ref arabulucuSicil).Range.Text = _dava.Burosu.SicilNo;

                object arabulucuAdres = "arabulucuAdres";
                doc.Bookmarks.get_Item(ref arabulucuAdres).Range.Text = _dava.Burosu.Adres;

                string iletisimText = "";
                foreach (var item in _dava.Burosu.TelefonBilgileri)
                {
                    if (item.SabitCepFax == TelefonTipi.Sabit)
                        iletisimText += "Tel." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Fax)
                        iletisimText += "Fax." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Cep)
                        iletisimText += "GSM.." + item.Numara;

                    iletisimText += "-";
                }
                object arabulucuIletisim = "arabulucuIletisim";
                doc.Bookmarks.get_Item(ref arabulucuIletisim).Range.Text = iletisimText;

                if (_dava.Burosu.EPosta != null)
                {
                    object arabulucuEposta = "arabulucuEposta";
                    doc.Bookmarks.get_Item(ref arabulucuEposta).Range.Text = _dava.Burosu.EPosta;
                }

                object taraf1adi = "taraf1adi";
                doc.Bookmarks.get_Item(ref taraf1adi).Range.Text = _dava.Basvurucu.TarafAdi;

                object taraf1TC = "taraf1TC";
                doc.Bookmarks.get_Item(ref taraf1TC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object taraf1Adres = "taraf1Adres";
                doc.Bookmarks.get_Item(ref taraf1Adres).Range.Text = _dava.Basvurucu.Adres;

                object taraf1Vekili = "taraf1Vekili";
                doc.Bookmarks.get_Item(ref taraf1Vekili).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object taraf1vekilAdresi = "taraf1vekilAdresi";
                doc.Bookmarks.get_Item(ref taraf1vekilAdresi).Range.Text = _dava.BasvurucuVekili.Adres;

                List<Taraf> taraflarList = new List<Taraf>();
                foreach (var taraf in _dava.KarsiTaraflar)
                {
                    taraflarList.Add(taraf.Taraf);
                }

                object taraf2Adi = "taraf2Adi";
                doc.Bookmarks.get_Item(ref taraf2Adi).Range.Text = taraflarList[0].TarafAdi;

                List<Taraf> karsiTarafList = new List<Taraf>();
                foreach (var karsiTaraf in _dava.KarsiTaraflar)
                {
                    karsiTarafList.Add(karsiTaraf.Taraf);
                }

                string heyetTxt = "";
                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri != null)
                {
                    int i = 1;
                    foreach (var heyet in _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri)
                    {
                        heyetTxt += i + "- " + heyet.AdiSoyadi + " (TCKN. " + heyet.TCKimlikNo + ")\n";
                        i++;
                    }
                }
                object taraf2Heyet = "taraf2Heyet";
                doc.Bookmarks.get_Item(ref taraf2Heyet).Range.Text = heyetTxt;

                if (taraflarList[0].Adres != null)
                {
                    object taraf2Adresi = "taraf2Adresi";
                    doc.Bookmarks.get_Item(ref taraf2Adresi).Range.Text = taraflarList[0].Adres;
                }

                object davaTuru = "davaTuru";
                doc.Bookmarks.get_Item(ref davaTuru).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi);

                object davaKonulari = "davaKonulari";
                string txt = "";
                List<DavaKonusu> davaKonulariList = _dava.DavaKonulari.ToList();
                for (int i = 0; i < davaKonulariList.Count; i++)
                {
                    if (i == 0)
                    {
                        txt += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                    else
                    {
                        txt += ",\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                }
                doc.Bookmarks.get_Item(ref davaKonulari).Range.Text = txt;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object bitisTarihi = "bitisTarihi";
                doc.Bookmarks.get_Item(ref bitisTarihi).Range.Text = gelenBitisTarihi.ToShortDateString();

                object duzenlemeYeri = "duzenlemeYeri";
                doc.Bookmarks.get_Item(ref duzenlemeYeri).Range.Text = _dava.Burosu.Adres;

                object belgeTarihSaat = "belgeTarihSaat";
                doc.Bookmarks.get_Item(ref belgeTarihSaat).Range.Text = string.Format("{0:dd/MM/yyyy hh:mm}", DateTime.Now);

                object anlasmaTuru = "anlasmaTuru";
                doc.Bookmarks.get_Item(ref anlasmaTuru).Range.Text = "ANLAŞMA";

                object arabulucuAdi2 = "arabulucuAdi2";
                doc.Bookmarks.get_Item(ref arabulucuAdi2).Range.Text = _dava.Burosu.AdSoyad;

                object buroAdres = "buroAdres";
                doc.Bookmarks.get_Item(ref buroAdres).Range.Text = _dava.Burosu.Adres;

                //ANLAŞMA METİNLERİ

                object kismenAnlasma = "kısmenAnlasma";
                doc.Bookmarks.get_Item(ref kismenAnlasma).Range.Text = "";

                object birdenFazlaAnlasma = "birdenFazlaAnlasma";
                doc.Bookmarks.get_Item(ref birdenFazlaAnlasma).Range.Text = "";

                object anlasmaMetni = "anlasmaMetni";
                doc.Bookmarks.get_Item(ref anlasmaMetni).Range.Text = gelenMetin;

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string KismiAnlasmaTutanagi(Dava _dava, AnlasmaMetniGerekenler formdanGelen)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Anlaşma Tutanağı.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object arabulucuSehir = "arabulucuSehir";
                doc.Bookmarks.get_Item(ref arabulucuSehir).Range.Text = _dava.ArabuluculukBurosu;

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object arabulucuAdi = "arabulucuAdi";
                doc.Bookmarks.get_Item(ref arabulucuAdi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuTC = "arabulucuTC";
                doc.Bookmarks.get_Item(ref arabulucuTC).Range.Text = _dava.Burosu.TcKimlikNo;

                object arabulucuSicil = "arabulucuSicil";
                doc.Bookmarks.get_Item(ref arabulucuSicil).Range.Text = _dava.Burosu.SicilNo;

                object arabulucuAdres = "arabulucuAdres";
                doc.Bookmarks.get_Item(ref arabulucuAdres).Range.Text = _dava.Burosu.Adres;

                string iletisimText = "";
                foreach (var item in _dava.Burosu.TelefonBilgileri)
                {
                    if (item.SabitCepFax == TelefonTipi.Sabit)
                        iletisimText += "Tel." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Fax)
                        iletisimText += "Fax." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Cep)
                        iletisimText += "GSM.." + item.Numara;

                    iletisimText += "-";
                }
                object arabulucuIletisim = "arabulucuIletisim";
                doc.Bookmarks.get_Item(ref arabulucuIletisim).Range.Text = iletisimText;

                if (_dava.Burosu.EPosta != null)
                {
                    object arabulucuEposta = "arabulucuEposta";
                    doc.Bookmarks.get_Item(ref arabulucuEposta).Range.Text = _dava.Burosu.EPosta;
                }

                object taraf1adi = "taraf1adi";
                doc.Bookmarks.get_Item(ref taraf1adi).Range.Text = _dava.Basvurucu.TarafAdi;

                object taraf1TC = "taraf1TC";
                doc.Bookmarks.get_Item(ref taraf1TC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object taraf1Adres = "taraf1Adres";
                doc.Bookmarks.get_Item(ref taraf1Adres).Range.Text = _dava.Basvurucu.Adres;

                object taraf1Vekili = "taraf1Vekili";
                doc.Bookmarks.get_Item(ref taraf1Vekili).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object taraf1vekilAdresi = "taraf1vekilAdresi";
                doc.Bookmarks.get_Item(ref taraf1vekilAdresi).Range.Text = _dava.BasvurucuVekili.Adres;

                List<Taraf> taraflarList = new List<Taraf>();
                foreach (var taraf in _dava.KarsiTaraflar)
                {
                    taraflarList.Add(taraf.Taraf);
                }

                object taraf2Adi = "taraf2Adi";
                doc.Bookmarks.get_Item(ref taraf2Adi).Range.Text = taraflarList[0].TarafAdi;

                List<Taraf> karsiTarafList = new List<Taraf>();
                foreach (var karsiTaraf in _dava.KarsiTaraflar)
                {
                    karsiTarafList.Add(karsiTaraf.Taraf);
                }

                string heyetTxt = "";
                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri != null)
                {
                    int i = 1;
                    foreach (var heyet in _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri)
                    {
                        heyetTxt += i + "- " + heyet.AdiSoyadi + " (TCKN. " + heyet.TCKimlikNo + ")\n";
                        i++;
                    }
                }
                object taraf2Heyet = "taraf2Heyet";
                doc.Bookmarks.get_Item(ref taraf2Heyet).Range.Text = heyetTxt;

                if (taraflarList[0].Adres != null)
                {
                    object taraf2Adresi = "taraf2Adresi";
                    doc.Bookmarks.get_Item(ref taraf2Adresi).Range.Text = taraflarList[0].Adres;
                }

                object davaTuru = "davaTuru";
                doc.Bookmarks.get_Item(ref davaTuru).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi);

                object davaKonulari = "davaKonulari";
                string txt = "";
                List<DavaKonusu> davaKonulariList = _dava.DavaKonulari.ToList();
                for (int i = 0; i < davaKonulariList.Count; i++)
                {
                    if (i == 0)
                    {
                        txt += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                    else
                    {
                        txt += ",\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                }
                doc.Bookmarks.get_Item(ref davaKonulari).Range.Text = txt;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object bitisTarihi = "bitisTarihi";
                doc.Bookmarks.get_Item(ref bitisTarihi).Range.Text = formdanGelen.AnlasmaTarihi.ToShortDateString();

                object duzenlemeYeri = "duzenlemeYeri";
                doc.Bookmarks.get_Item(ref duzenlemeYeri).Range.Text = _dava.Burosu.Adres;

                object belgeTarihSaat = "belgeTarihSaat";
                doc.Bookmarks.get_Item(ref belgeTarihSaat).Range.Text = string.Format("{0:dd/MM/yyyy hh:mm}", DateTime.Now);

                object anlasmaTuru = "anlasmaTuru";
                doc.Bookmarks.get_Item(ref anlasmaTuru).Range.Text = "KISMİ ANLAŞMA";

                object arabulucuAdi2 = "arabulucuAdi2";
                doc.Bookmarks.get_Item(ref arabulucuAdi2).Range.Text = _dava.Burosu.AdSoyad;

                object buroAdres = "buroAdres";
                doc.Bookmarks.get_Item(ref buroAdres).Range.Text = _dava.Burosu.Adres;

                //ANLAŞMA METİNLERİ

                object birdenFazlaAnlasma = "birdenFazlaAnlasma";
                doc.Bookmarks.get_Item(ref birdenFazlaAnlasma).Range.Text = "";

                object anlasmaMetni = "anlasmaMetni";
                doc.Bookmarks.get_Item(ref anlasmaMetni).Range.Text = "";

                object kısmenAnlasmaKıdem = "kısmenAnlasmaKıdem";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaKıdem).Range.Text = formdanGelen.NetKidemTazminati.ToString();

                object kısmenAnlasmaİhbar = "kısmenAnlasmaİhbar";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaİhbar).Range.Text = formdanGelen.NetIhbarTazminati.ToString();

                object kısmenAnlasmaUcret = "kısmenAnlasmaUcret";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaUcret).Range.Text = formdanGelen.NetUcretAlacagi.ToString();

                object kısmenAnlasmaYıllıkİzin = "kısmenAnlasmaYıllıkİzin";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaYıllıkİzin).Range.Text = formdanGelen.NetYillikIzinAlacagi.ToString();

                object kısmenAnlasmaFazlaCalisma = "kısmenAnlasmaFazlaCalisma";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaFazlaCalisma).Range.Text = formdanGelen.FazlaCalismaAlacagi.ToString();

                object kısmenAnlasmaResmiTatil = "kısmenAnlasmaResmiTatil";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaResmiTatil).Range.Text = formdanGelen.ResmiTatilCalisma.ToString();

                object kısmenAnlasmaNetUcret = "kısmenAnlasmaNetUcret";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaNetUcret).Range.Text = formdanGelen.NetTutar.ToString();

                object kısmenAnlasmaIBAN = "kısmenAnlasmaIBAN";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaIBAN).Range.Text = formdanGelen.IBAN.ToString();

                object kısmenAnlasmaOdemeTarihi = "kısmenAnlasmaOdemeTarihi";
                doc.Bookmarks.get_Item(ref kısmenAnlasmaOdemeTarihi).Range.Text = formdanGelen.OdemeTarihi.ToShortDateString();


                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }

        public static string BirdenFazlaAnlasmaTutanagi(Dava _dava, AnlasmaMetniGerekenler formdanGelen)
        {
            _path = System.Windows.Forms.Application.StartupPath + @"\Evraklar\Anlaşma Tutanağı.docx";

            if (!File.Exists(_path))
            {
                System.Windows.Forms.MessageBox.Show("Dosya bulunamadı.");
                return null;
            }
            else
            {
                wordApp = new Application();

                missing = System.Reflection.Missing.Value;
                readOnly = false;
                fileName = _path;

                doc = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly, ref readOnly,
                ref missing, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

                doc.Activate();

                object arabulucuSehir = "arabulucuSehir";
                doc.Bookmarks.get_Item(ref arabulucuSehir).Range.Text = _dava.ArabuluculukBurosu;

                object buroDosyaNo = "buroDosyaNo";
                doc.Bookmarks.get_Item(ref buroDosyaNo).Range.Text = _dava.BuroDosyaNo;

                object arabulucuDosyaNo = "arabulucuDosyaNo";
                doc.Bookmarks.get_Item(ref arabulucuDosyaNo).Range.Text = _dava.ArabuluculukDosyaNo;

                object arabulucuAdi = "arabulucuAdi";
                doc.Bookmarks.get_Item(ref arabulucuAdi).Range.Text = _dava.Burosu.AdSoyad;

                object arabulucuTC = "arabulucuTC";
                doc.Bookmarks.get_Item(ref arabulucuTC).Range.Text = _dava.Burosu.TcKimlikNo;

                object arabulucuSicil = "arabulucuSicil";
                doc.Bookmarks.get_Item(ref arabulucuSicil).Range.Text = _dava.Burosu.SicilNo;

                object arabulucuAdres = "arabulucuAdres";
                doc.Bookmarks.get_Item(ref arabulucuAdres).Range.Text = _dava.Burosu.Adres;

                string iletisimText = "";
                foreach (var item in _dava.Burosu.TelefonBilgileri)
                {
                    if (item.SabitCepFax == TelefonTipi.Sabit)
                        iletisimText += "Tel." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Fax)
                        iletisimText += "Fax." + item.Numara;
                    else if (item.SabitCepFax == TelefonTipi.Cep)
                        iletisimText += "GSM.." + item.Numara;

                    iletisimText += "-";
                }
                object arabulucuIletisim = "arabulucuIletisim";
                doc.Bookmarks.get_Item(ref arabulucuIletisim).Range.Text = iletisimText;

                if (_dava.Burosu.EPosta != null)
                {
                    object arabulucuEposta = "arabulucuEposta";
                    doc.Bookmarks.get_Item(ref arabulucuEposta).Range.Text = _dava.Burosu.EPosta;
                }

                object taraf1adi = "taraf1adi";
                doc.Bookmarks.get_Item(ref taraf1adi).Range.Text = _dava.Basvurucu.TarafAdi;

                object taraf1TC = "taraf1TC";
                doc.Bookmarks.get_Item(ref taraf1TC).Range.Text = _dava.Basvurucu.TCKimlikNo;

                object taraf1Adres = "taraf1Adres";
                doc.Bookmarks.get_Item(ref taraf1Adres).Range.Text = _dava.Basvurucu.Adres;

                object taraf1Vekili = "taraf1Vekili";
                doc.Bookmarks.get_Item(ref taraf1Vekili).Range.Text = _dava.BasvurucuVekili.AdiSoyadi;

                object taraf1vekilAdresi = "taraf1vekilAdresi";
                doc.Bookmarks.get_Item(ref taraf1vekilAdresi).Range.Text = _dava.BasvurucuVekili.Adres;

                List<Taraf> taraflarList = new List<Taraf>();
                foreach (var taraf in _dava.KarsiTaraflar)
                {
                    taraflarList.Add(taraf.Taraf);
                }

                object taraf2Adi = "taraf2Adi";
                doc.Bookmarks.get_Item(ref taraf2Adi).Range.Text = taraflarList[0].TarafAdi;

                List<Taraf> karsiTarafList = new List<Taraf>();
                foreach (var karsiTaraf in _dava.KarsiTaraflar)
                {
                    karsiTarafList.Add(karsiTaraf.Taraf);
                }

                string heyetTxt = "";
                if (_dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri != null)
                {
                    int i = 1;
                    foreach (var heyet in _dava.KarsiTaraflar.Where(x => x.TarafID == karsiTarafList[0].ID).FirstOrDefault().Heyetleri)
                    {
                        heyetTxt += i + "- " + heyet.AdiSoyadi + " (TCKN. " + heyet.TCKimlikNo + ")\n";
                        i++;
                    }
                }
                object taraf2Heyet = "taraf2Heyet";
                doc.Bookmarks.get_Item(ref taraf2Heyet).Range.Text = heyetTxt;

                if (taraflarList[0].Adres != null)
                {
                    object taraf2Adresi = "taraf2Adresi";
                    doc.Bookmarks.get_Item(ref taraf2Adresi).Range.Text = taraflarList[0].Adres;
                }

                object davaTuru = "davaTuru";
                doc.Bookmarks.get_Item(ref davaTuru).Range.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_dava.DavaKonulari.FirstOrDefault().DavaTuru.TurAdi);

                object davaKonulari = "davaKonulari";
                string txt = "";
                List<DavaKonusu> davaKonulariList = _dava.DavaKonulari.ToList();
                for (int i = 0; i < davaKonulariList.Count; i++)
                {
                    if (i == 0)
                    {
                        txt += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                    else
                    {
                        txt += ",\n" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(davaKonulariList[i].KonuAdi);
                    }
                }
                doc.Bookmarks.get_Item(ref davaKonulari).Range.Text = txt;

                object basvuruTarihi = "basvuruTarihi";
                doc.Bookmarks.get_Item(ref basvuruTarihi).Range.Text = _dava.BasvuruTarihi.Value.ToShortDateString();

                object bitisTarihi = "bitisTarihi";
                doc.Bookmarks.get_Item(ref bitisTarihi).Range.Text = formdanGelen.AnlasmaTarihi.ToShortDateString();

                object duzenlemeYeri = "duzenlemeYeri";
                doc.Bookmarks.get_Item(ref duzenlemeYeri).Range.Text = _dava.Burosu.Adres;

                object belgeTarihSaat = "belgeTarihSaat";
                doc.Bookmarks.get_Item(ref belgeTarihSaat).Range.Text = string.Format("{0:dd/MM/yyyy hh:mm}", DateTime.Now);

                object anlasmaTuru = "anlasmaTuru";
                doc.Bookmarks.get_Item(ref anlasmaTuru).Range.Text = "BİRDEN FAZLA İŞÇİ ALACAĞINDA ANLAŞMA";

                object arabulucuAdi2 = "arabulucuAdi2";
                doc.Bookmarks.get_Item(ref arabulucuAdi2).Range.Text = _dava.Burosu.AdSoyad;

                object buroAdres = "buroAdres";
                doc.Bookmarks.get_Item(ref buroAdres).Range.Text = _dava.Burosu.Adres;

                //ANLAŞMA METİNLERİ

                object kismenAnlasma = "kısmenAnlasma";
                doc.Bookmarks.get_Item(ref kismenAnlasma).Range.Text = "\r";

                object anlasmaMetni = "anlasmaMetni";
                doc.Bookmarks.get_Item(ref anlasmaMetni).Range.Text = "\r";

                object birdenFazlaKıdem = "birdenFazlaKıdem";
                doc.Bookmarks.get_Item(ref birdenFazlaKıdem).Range.Text = formdanGelen.NetKidemTazminati.ToString();

                object birdenFazlaİhbar = "birdenFazlaİhbar";
                doc.Bookmarks.get_Item(ref birdenFazlaİhbar).Range.Text = formdanGelen.NetIhbarTazminati.ToString();

                object birdenFazlaUcret = "birdenFazlaUcret";
                doc.Bookmarks.get_Item(ref birdenFazlaUcret).Range.Text = formdanGelen.NetUcretAlacagi.ToString();

                object birdenFazlaYıllıkİzin = "birdenFazlaYıllıkİzin";
                doc.Bookmarks.get_Item(ref birdenFazlaYıllıkİzin).Range.Text = formdanGelen.NetYillikIzinAlacagi.ToString();

                object birdenFazlaÇalışma = "birdenFazlaÇalışma";
                doc.Bookmarks.get_Item(ref birdenFazlaÇalışma).Range.Text = formdanGelen.FazlaCalismaAlacagi.ToString();

                object birdenFazlaResmi = "birdenFazlaResmi";
                doc.Bookmarks.get_Item(ref birdenFazlaResmi).Range.Text = formdanGelen.ResmiTatilCalisma.ToString();

                object birdenFazlaNetUcret = "birdenFazlaNetUcret";
                doc.Bookmarks.get_Item(ref birdenFazlaNetUcret).Range.Text = formdanGelen.NetTutar.ToString();

                object birdenFazlaIBAN = "birdenFazlaIBAN";
                doc.Bookmarks.get_Item(ref birdenFazlaIBAN).Range.Text = formdanGelen.IBAN.ToString();

                object birdenFazlaOdemeTarihi = "birdenFazlaOdemeTarihi";
                doc.Bookmarks.get_Item(ref birdenFazlaOdemeTarihi).Range.Text = formdanGelen.OdemeTarihi.ToShortDateString();

                string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                doc.SaveAs2(path + ".docx");

                doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);

                wordApp.Quit();

                return path;
            }
        }


        public static void Yenile(string path)
        {
            File.Delete(path + ".pdf");

            wordApp = new Microsoft.Office.Interop.Word.Application();
            doc = wordApp.Application.Documents.Open(path + ".docx");

            doc.ExportAsFixedFormat(path + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            doc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
            wordApp.Quit();
        }
    }
}
