using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.Office.Utils;

namespace RichEditLeftPadding {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            AdjustSimpleViewPadding();
            AdjustDraftViewPadding();

            richEditControl1.ActiveViewType = RichEditViewType.Simple;

            richEditControl1.Text = "Test";
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e) {
            //AdjustParagraphIndent();
            AdjustMargins();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AdjustParagraphIndent();
        }

        private void AdjustSimpleViewPadding() {
            richEditControl1.Views.SimpleView.Padding = new Padding(0);
        }

        private void AdjustDraftViewPadding() {
            richEditControl1.Views.DraftView.Padding = new Padding(0);
        }

        private void AdjustParagraphIndent() {
            richEditControl1.Document.Paragraphs[0].LeftIndent = Units.InchesToDocumentsF(0.5f);
            richEditControl1.Document.Paragraphs[0].FirstLineIndentType = ParagraphFirstLineIndent.Indented;
            richEditControl1.Document.Paragraphs[0].FirstLineIndent = Units.InchesToDocumentsF(0.5f);
        }

        private void AdjustMargins() {
            richEditControl1.Document.Sections[0].Margins.Left = Units.InchesToDocumentsF(2f);
        }
    }
}