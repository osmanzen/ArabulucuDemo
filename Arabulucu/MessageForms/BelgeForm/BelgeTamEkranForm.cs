using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Arabulucu.MessageForms.BelgeForm
{
    public partial class BelgeTamEkranForm : DevExpress.XtraEditors.XtraForm
    {
        public BelgeTamEkranForm(string belgeYolu)
        {
            InitializeComponent();

            pdfViewer1.DocumentFilePath = belgeYolu + ".pdf";
        }
    }
}