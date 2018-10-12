using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu.ArabulucuHelpers
{
    public static class BelgeOlusturucu
    {
        static string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arabulucu Evraklar\";
        static DirectoryInfo directoryInfo;
        static FileInfo fileInfo;
        static XmlOlusturucu xmlOlusturucu;
        static bool olusturmaBasarili;
        static string yeniDosyaAdi = "";
        static List<Paragraf> pList;
        static Paragraf p;
        static List<DavaKonusu> davaKonuList;

        public static void dosyaKapakSayfasi(Dava _dava)
        {

        }

        public static void ToplantiyaDavetMektubu(Dava _dava, List<Taraf> _karsiTaraflar, MyBaseEntity _davetEdilen)
        {
            using (XmlTextWriter createXML = new XmlTextWriter("temp.xml", UTF8Encoding.UTF8))
            {
                xmlOlusturucu = new XmlOlusturucu(createXML);

                xmlOlusturucu.BaslikEkle("ARABULUCU TARAFINDAN YAPILAN", "1", "11", "true", "false");
                xmlOlusturucu.BaslikEkle("DAVA ŞARTI ARABULUCULUK İLK TOPLANTIYA DAVET MEKTUBU", "1", "11", "true", "false");
                xmlOlusturucu.ParagrafEkle(new Paragraf(" "));

                if (_davetEdilen == _dava.Basvurucu)
                {
                    xmlOlusturucu.ParagrafEkle(pList = new List<Paragraf>() {
                        new Paragraf("        Sayın, " + _dava.Basvurucu.TarafAdi.ToUpper() + "-", "true"),
                        new Paragraf(_dava.Basvurucu.TCKimlikNo)
                    });
                    xmlOlusturucu.ParagrafEkle(new Paragraf("                  " + _dava.Basvurucu.Adres));
                    xmlOlusturucu.ParagrafEkle(new Paragraf(" "));
                    //PARAGRAF 1
                    p = new Paragraf("        Vekiliniz " + _dava.BasvurucuVekili.AdiSoyadi.ToUpper() + " tarafından " + _dava.ArabuluculukBurosu + "Arabuluculuk Bürosuna İşveren ", "true");
                    foreach (var taraf in _karsiTaraflar)
                    {
                        if (_karsiTaraflar.IndexOf(taraf) != 0)
                            p.text += ", ";
                        p.text += taraf.TarafAdi;
                    }
                    p.text += " ile aranızdaki Hukuki Uyuşmazlığın Dava Şartı Arabuluculuk Yolu ile çözümü için yapılan başvuru üzerine UYAP Arabulucu Portal tarafından " + _dava.BasvuruTarihi.Value.ToShortDateString() + " tarihinde " + _dava.BuroDosyaNo + " Büro numarası ve " + _dava.ArabuluculukDosyaNo + " Arabuluculuk Dosya numarası ile görevlendirilmiş T.C. Adalet Bakanlığındaki resmi sicile kayıtlı " + _dava.Burosu.SicilNo + " Sicil numaralı arabulucuyum.";
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 2
                    p = new Paragraf("      " + _dava.DavaKonulari.FirstOrDefault(x => x.AktifMi).DavaTuru.TurAdi + " uyuşmazlığı barışçıl olarak arabuluculuk yoluyla özmek için bu davet yazısını yazıyoruz. Taraflar arasındaki ");
                    davaKonuList = _dava.DavaKonulari.Where(x => x.AktifMi).ToList();
                    foreach (var konu in davaKonuList)
                    {
                        if (davaKonuList.IndexOf(konu) != 0)
                            p.text += ", ";
                        p.text += konu.KonuAdi;
                    }
                    p.text += " alacağından kaynaklanan hukuki uyuşmazlığının 6325 Sayılı Hukuk Uyuşmazlıklarında Arabuluculuk Kanunu kapsamında tarafların üzerinde serbestçe tasarruf edeceği iş ve işlemlerden doğan özel hukuk uyuşmazlığı olduğu anlaşılmaktadır.";
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 3
                    p = new Paragraf("      7036 Sayılı İş Mahkemeleri Kanunu uyarınca kanuna, bireysel veya toplu iş sözleşmesine dayanan işçi veya işveren alacağı ve tazminatı ile işe iade talebiyle açılan davalarda, arabulucuya başvurulmuş olması dava şartıdır.(İş M.K. m. 3/1).");
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 4
                    p = new Paragraf("      Arabuluculuk bürosuna başvurulmasından son tutanağın düzenlendiği tarihe kadar geçen sürede zaman aşımı durur ve hak düşürücü süre işlemez.(İş M.K. m. 3/17)");
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 5
                    pList = new List<Paragraf>();
                    p = new Paragraf("      Başvurucu-Davacı, arabuluculuk faaliyeti sonunda anlaşmaya ");
                    pList.Add(p);
                    p = new Paragraf("varılamadığına ", "true");
                    pList.Add(p);
                    p = new Paragraf("ilişkin son tutanağın aslını veya arabulucu tarafından onaylanmış bir örneğini dava dilekçesine eklemek zorundadır. Bu zorunluluğa uyulmaması halinde mahkemece davacıya, son tutanağın bir haftalık kesin süre içinde mahkemeye sunulması gerektiği, aksi takdirde davanın usulden reddedileceği ihtarını içeren davetiye gönderilir. İhtarın gereği yerine getirilmez ise dava dilekçesi karşı tarafa tebliğe çıkılmaksızın davanın usulden reddine karar verilir. Arabulucuya başvurulmadan dava açıldığının anlaşılması halinde herhangi bir işlem yapılmaksızın davanın, dava şartı yokluğu sebebiyle usulden reddine karar verilir.(İş M.K. m. 3/2)");
                    pList.Add(p);
                    xmlOlusturucu.ParagrafEkle(pList);

                    //PARAGRAF 6
                    p = new Paragraf("      Arabulucu, yapılan başvuruyu gönderildiği tarihten itibaren üç hafta içinde sonuçlandırır. Bu süre zorunlu hallerde arabulucu tarafından en fazla bir hafta uzatılabilir.(İş M.K. m. 3/10)");
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 7
                    p = new Paragraf("      Arabulucu, taraflara ulaşamaması, taraflar katılmadığı için görüşme yapılmaması yahut yapılan görüşmeler sonucunda anlaşmaya varılması veya varılamaması hallerinde Arabuluculuk faaliyetine son verir ve son tutanağı düzenleyerek durumu derhal arabuluculuk bürosuna bildirir.(İş M.K. m. 3/13)");
                    xmlOlusturucu.ParagrafEkle(p);

                    //PARAGRAF 8
                    pList = new List<Paragraf>();
                    p = new Paragraf("      Tarafların arabuluculuk faaliyeti sonunda ");
                    pList.Add(p);
                    p = new Paragraf("anlaşmaları ", "true");
                    pList.Add(p);
                    p = new Paragraf("halinde, arabuluculuk ücreti, Arabuluculuk Asgari Ücret Tarifesinin eki Arabuluculuk Ücret Tarifesinin İkinci Kısmına göre aksi kararlaştırılmadıkça taraflarca eşit şekilde karşılanır. (Anlaşılan bedelin %6'sı) Bu durumda ücret, Tarifenin Birinci Kısmında belirlenen iki saatlik ücret tutarından az olamaz. (İlk 2 Saat için KDV Dahil 280 TL) (İş M.K. m. 3/13)");
                    pList.Add(p);
                    xmlOlusturucu.ParagrafEkle(pList);

                    //PARAGRAF 9
                    pList = new List<Paragraf>();
                    p = new Paragraf("      Arabuluculuk faaliyeti sonunda taraflara ulaşılamaması, tarafların katılmadığı için görüşme yapılmaması veya iki saatten az süren görüşmeler sonunda tarafların ");
                    pList.Add(p);
                    p = new Paragraf("anlaşamamaları ", "false");
                    pList.Add(p);
                    p = new Paragraf("hallerinde, iki saatlik ücret tutarı Tarifenin Birinci Kısmına göre Adalet Bakanlığı bütçesinden ödenir. (İlk iki saat için KDV Dahil 280 TL) İki saatten fazla süren görüşmeler sonunda tarafların anlaşamamaları halinde ise iki saati aşan kısıma ilişkin ücret aksi kararlaştırılmadıkça taraflarca eşit şekilde Tarifenin Birinci Kısmına göre karşılanır. Adalet Bakanlığı bütçesinden ödenen ve taraflarca karşılanan arabuluculuk ücreti, yargılama giderlerinden sayılır. (İş M.K. m. 3/14)");
                    pList.Add(p);
                    xmlOlusturucu.ParagrafEkle(pList);

                    p = new Paragraf("      Arabuluculuk görüşmelerine taraflar bizzat, kanuni temsilcileri veya avukatları aracılığıyla katılabilirler. İşverenin yazılı belgeyleyle yetkilendirdiği çalışanı da görüşmelerde işvereni temsil edebilir ve son tutanağı imzalayabilir.(İş M.K. m. 3/18) ");
                    xmlOlusturucu.ParagrafEkle(p);
                }

                xmlOlusturucu.DosyaBitir();
                olusturmaBasarili = true;
            }

            if (olusturmaBasarili)
            {
                directoryInfo = new DirectoryInfo(defaultPath + _dava.ID + @"\İlk Toplantıya Davet Mektupları\" + @"\");
                directoryInfo.Create();
                fileInfo = new FileInfo(System.Windows.Forms.Application.StartupPath + @"\temp.xml");

                yeniDosyaAdi = defaultPath + _dava.ID + @"\İlk Toplantıya Davet Mektupları\İlk Toplantıya Davet Mektubu - ";
                if (_davetEdilen == _dava.BasvurucuVekili)
                {
                    yeniDosyaAdi += _dava.BasvurucuVekili.AdiSoyadi;
                }
                else
                {
                    yeniDosyaAdi += (_davetEdilen as Taraf).TarafAdi;
                }

                string sonDosyaAdi = yeniDosyaAdi;
                int sayac = 1;

            DosyaIsimlendir:
                if (File.Exists(sonDosyaAdi + ".udf"))
                {
                    sayac++;
                    sonDosyaAdi = yeniDosyaAdi + "(" + sayac + ")";
                    goto DosyaIsimlendir;
                }

                fileInfo.MoveTo(sonDosyaAdi + ".udf");

                DialogResult yanit = MessageBox.Show(yeniDosyaAdi + "\nBaşarıyla Oluşturuldu ve Kaydedildi. Dosyayı Açmak İstermisiniz?", "Kaydedildi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (yanit == DialogResult.Yes)
                {
                    Process.Start(fileInfo.FullName);
                }
            }
        }
    }
}
