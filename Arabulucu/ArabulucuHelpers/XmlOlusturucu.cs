using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Arabulucu.ArabulucuHelpers
{
    public class XmlOlusturucu
    {
        XmlTextWriter XmlYazici { get; set; }
        string CDataText = "";
        int imlec = 0;
        int satir = 1;
        //KONUMLAR
        public string Sola = "0";
        public string Ortala = "1";
        public string Saga = "2";
        public string IkiYana = "3";
        public string Tablo3Aralik = "94,8,198";
        public string HucreCizgili = "borderCell";

        public XmlOlusturucu(XmlTextWriter _gelenYazici)
        {
            XmlYazici = _gelenYazici;
            StartTemplate();
            EndProperties();
            StartElements();
        }

        public void StartTemplate()
        {
            XmlYazici.WriteStartElement("template");
            XmlYazici.WriteAttributeString("format_id", "1.7");
            XmlYazici.WriteString("\n");
        }

        public void EndProperties()
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("properties");
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("pageFormat");
            XmlYazici.WriteAttributeString("mediaSizeName", "1");
            XmlYazici.WriteAttributeString("leftMargin", "70.875");
            XmlYazici.WriteAttributeString("rightMargin", "70.875");
            XmlYazici.WriteAttributeString("topMargin", "70.875");
            XmlYazici.WriteAttributeString("bottomMargin", "70.875");
            XmlYazici.WriteAttributeString("paperOrientation", "1");
            XmlYazici.WriteAttributeString("headerFOffset", "20.0");
            XmlYazici.WriteAttributeString("footerFOffset", "20.0");
            XmlYazici.WriteEndElement();
            XmlYazici.WriteEndElement();
            XmlYazici.WriteString("\n");
        }

        public void StartElements()
        {
            XmlYazici.WriteStartElement("elements");
            XmlYazici.WriteAttributeString("resolver", "hvl-default");
        }

        public void SatirEkle()
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("row");
            XmlYazici.WriteAttributeString("rowName", "row" + satir);
            XmlYazici.WriteAttributeString("border", "borderNone");
            XmlYazici.WriteAttributeString("borderWidth", "0.5");
            satir++;
        }

        public void SutunEkle()
        {

        }

        public void HucreEkle()
        {

        }

        public void TabloEkle(List<TabloVerisi> gelenListe, int sutunSayisi, string araliklar)
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("table");
            XmlYazici.WriteAttributeString("tableName", "Sabit");
            XmlYazici.WriteAttributeString("columnCount", sutunSayisi.ToString());
            XmlYazici.WriteAttributeString("columnSpans", araliklar);
            XmlYazici.WriteAttributeString("border", "borderNone");
            XmlYazici.WriteAttributeString("borderSpec", "31");
            XmlYazici.WriteAttributeString("borderColor", "-16777216");
            XmlYazici.WriteAttributeString("borderStyle", "borderStyle-plain");
            XmlYazici.WriteAttributeString("borderWidth", "1.0");
            for (int i = 1; i <= gelenListe.Count / sutunSayisi; i++)
            {
                for (int j = 1; j < sutunSayisi; j++)
                {
                    XmlYazici.WriteString("\n");
                    XmlYazici.WriteStartElement("cell");
                    XmlYazici.WriteAttributeString("border", gelenListe[i * j].hucreCizgi);
                    XmlYazici.WriteAttributeString("borderWidth", "0.5");
                    XmlYazici.WriteString("\n");
                    XmlYazici.WriteStartElement("paragraph");
                    XmlYazici.WriteAttributeString("Alignment", "0");
                    XmlYazici.WriteAttributeString("LeftIndent", "3.0");
                    XmlYazici.WriteAttributeString("RightIndent", "1.0");
                    XmlYazici.WriteAttributeString("LineSpacing", "0.5");
                    XmlYazici.WriteString("\n");
                    XmlYazici.WriteStartElement("content");
                    XmlYazici.WriteAttributeString("Alignment", "0");
                    XmlYazici.WriteAttributeString("LeftIndent", "3.0");
                    XmlYazici.WriteAttributeString("RightIndent", "1.0");
                    XmlYazici.WriteAttributeString("family", "Tahoma");
                    XmlYazici.WriteAttributeString("size", "9");
                    XmlYazici.WriteAttributeString("bold", gelenListe[i * j].kalin);
                    karakterBaslangici(gelenListe[i * j].metin);
                    CDataEkle(gelenListe[i * j].metin);

                    XmlYazici.WriteEndElement();
                    XmlYazici.WriteEndElement();
                    XmlYazici.WriteEndElement();
                }
                XmlYazici.WriteEndElement();
            }
            XmlYazici.WriteEndElement();
        }

        public void BaslikEkle(string baslik, string konum = "1", string size = "11", string kalinMi = "true", string altCizgi = "true")
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("paragraph");
            XmlYazici.WriteAttributeString("Alignment", konum);
            XmlYazici.WriteString("\n");

            XmlYazici.WriteStartElement("content");
            XmlYazici.WriteAttributeString("family", "Tahoma");
            XmlYazici.WriteAttributeString("size", size);
            XmlYazici.WriteAttributeString("bold", kalinMi);
            XmlYazici.WriteAttributeString("underline", altCizgi);

            karakterBaslangici(baslik);

            XmlYazici.WriteEndElement();
            XmlYazici.WriteEndElement();

            CDataEkle(baslik);
        }

        public void ParagrafEkle(List<Paragraf> pList, string konum = "")
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("paragraph");
            XmlYazici.WriteAttributeString("Alignment", konum);

            foreach (var p in pList)
            {
                XmlYazici.WriteString("\n");
                XmlYazici.WriteStartElement("content");
                XmlYazici.WriteAttributeString("bold", p.kalinMi);
                XmlYazici.WriteAttributeString("underline", p.altCizgi);
                XmlYazici.WriteAttributeString("family", p.family);
                XmlYazici.WriteAttributeString("size", p.size);
                karakterBaslangici(p.text);
                XmlYazici.WriteEndElement();
                CDataEkle(p.text);
            }
            XmlYazici.WriteEndElement();
        }

        public void ParagrafEkle(Paragraf p, string konum = "")
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("paragraph");
            XmlYazici.WriteAttributeString("Alignment", konum);

            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("content");
            XmlYazici.WriteAttributeString("bold", p.kalinMi);
            XmlYazici.WriteAttributeString("underline", p.altCizgi);
            XmlYazici.WriteAttributeString("family", p.family);
            XmlYazici.WriteAttributeString("size", p.size);
            karakterBaslangici(p.text);
            XmlYazici.WriteEndElement();
            CDataEkle(p.text);
            XmlYazici.WriteEndElement();
        }

        public void karakterBaslangici(string gelenYazi)
        {
            XmlYazici.WriteAttributeString("startOffset", imlec.ToString());
            XmlYazici.WriteAttributeString("length", (gelenYazi.Length + 1).ToString());
            imlec += gelenYazi.Length + 1;
        }

        public void CDataEkle(string gelenMetin)
        {
            CDataText += gelenMetin + "\n";
        }

        public void DosyaBitir()
        {
            EndElements();
            StartStyles();
            EndCData();
            EndTemplate();
        }

        public void EndElements()
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteEndElement();
        }

        public void StartStyles()
        {
            //STYLES
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("styles");

            //STYLE
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("style");
            XmlYazici.WriteAttributeString("name", "default");
            XmlYazici.WriteAttributeString("description", "Geçerli");
            XmlYazici.WriteAttributeString("family", "Dialog");
            XmlYazici.WriteAttributeString("size", "12");
            XmlYazici.WriteAttributeString("bold", "false");
            XmlYazici.WriteAttributeString("italic", "false");
            XmlYazici.WriteAttributeString("foreground", "-13421773");
            XmlYazici.WriteAttributeString("FONT_ATTRIBUTE_KEY", "javax.swing.plaf.FontUIResource[family=Dialog,name=Dialog,style=plain,size=12]");
            //STYLE
            XmlYazici.WriteEndElement();

            //STYLE
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("style");
            XmlYazici.WriteAttributeString("name", "hvl-default");
            XmlYazici.WriteAttributeString("family", "Times New Roman");
            XmlYazici.WriteAttributeString("size", "12");
            XmlYazici.WriteAttributeString("description", "Gövde");
            //STYLE
            XmlYazici.WriteEndElement();

            //STYLES
            XmlYazici.WriteEndElement();
        }

        public void EndCData()
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteStartElement("content");
            XmlYazici.WriteCData(CDataText);
            XmlYazici.WriteString("\n");
            XmlYazici.WriteEndElement();
        }

        public void EndTemplate()
        {
            XmlYazici.WriteString("\n");
            XmlYazici.WriteEndElement();
        }
    }

    public class TabloVerisi
    {
        public TabloVerisi()
        {
            kalin = "false";
            hucreCizgi = "borderNone";
        }
        public int satir { get; set; }
        public int sutun { get; set; }
        public string metin { get; set; }
        public string kalin { get; set; }
        public string hucreCizgi { get; set; }
    }

    public class Paragraf
    {
        public Paragraf(string _text, string _size = "10", string _kalinMi = "false", string _altCizgi = "false", string _family = "Tahoma")
        {
            text = _text;
            size = _size;
            kalinMi = _kalinMi;
            altCizgi = _altCizgi;
            family = _family;
        }

        public Paragraf(string _text)
        {
            text = _text;
            size = "10";
            kalinMi = "false";
            altCizgi = "false";
            family = "Tahoma";
        }

        public Paragraf(string _text, string _kalinMi)
        {
            text = _text;
            kalinMi = _kalinMi;
            altCizgi = "false";
            family = "Tahoma";
            size = "10";
        }

        public string text { get; set; }

        public string size { get; set; }

        public string kalinMi { get; set; }

        public string altCizgi { get; set; }

        public string family { get; set; }
    }
}
