Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Utils

Namespace RichEditLeftPadding

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AdjustSimpleViewPadding()
            AdjustDraftViewPadding()
            richEditControl1.ActiveViewType = RichEditViewType.Simple
            richEditControl1.Text = "Test"
        End Sub

        Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            'AdjustParagraphIndent();
            AdjustMargins()
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            AdjustParagraphIndent()
        End Sub

        Private Sub AdjustSimpleViewPadding()
            richEditControl1.Views.SimpleView.Padding = New Padding(0)
        End Sub

        Private Sub AdjustDraftViewPadding()
            richEditControl1.Views.DraftView.Padding = New Padding(0)
        End Sub

        Private Sub AdjustParagraphIndent()
            richEditControl1.Document.Paragraphs(0).LeftIndent = Units.InchesToDocumentsF(0.5F)
            richEditControl1.Document.Paragraphs(0).FirstLineIndentType = ParagraphFirstLineIndent.Indented
            richEditControl1.Document.Paragraphs(0).FirstLineIndent = Units.InchesToDocumentsF(0.5F)
        End Sub

        Private Sub AdjustMargins()
            richEditControl1.Document.Sections(0).Margins.Left = Units.InchesToDocumentsF(2F)
        End Sub
    End Class
End Namespace
