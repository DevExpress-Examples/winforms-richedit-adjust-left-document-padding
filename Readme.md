<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to adjust left padding of a document in RichEditControl


<p><strong>Problem:</strong></p><p>Is there any way to remove an empty space at the left side of RichEditControl?</p><p><strong>Solution:</strong></p><p>This "space" is defined via the following property value of the first paragraph in the document:</p><p><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeParagraph_LeftIndenttopic"><u>Paragraph.LeftIndent</u></a><br />
<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeParagraph_FirstLineIndentTypetopic"><u>Paragraph.FirstLineIndentType</u></a><br />
<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeParagraph_FirstLineIndenttopic"><u>Paragraph.FirstLineIndent</u></a></p><p>Note that there are additional settings that affect the "spacing" depending on the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_ActiveViewTypetopic"><u>RichEditControl.ActiveViewType</u></a>:</p><p><strong>PrintLayout</strong> - <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSection_Marginstopic"><u>Section.Margins</u></a></p><p><strong>Simple</strong> - <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditSimpleView_Paddingtopic"><u>SimpleView.Padding</u></a></p><p><strong>Draft</strong> - <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditDraftView_Paddingtopic"><u>DraftView.Padding</u></a></p><p>This example illustrates how to adjust all these settings in code.</p>

<br/>


