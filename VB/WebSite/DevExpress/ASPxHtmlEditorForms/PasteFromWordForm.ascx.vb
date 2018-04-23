Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Web.ASPxHtmlEditor.Localization
Imports DevExpress.Web.ASPxEditors

Partial Public Class PasteFromWordForm
	Inherits HtmlEditorUserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Localize()
	End Sub
	Private Sub Localize()
		lblDescription.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.PasteRtf_Instructions)
		ckbStripFont.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.PasteRtf_StripFont)
		btnOk.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonOk)
		btnCancel.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonCancel)
	End Sub
	Protected Overrides Function GetChildDxEdits() As ASPxEditBase()
		Return New ASPxEditBase() { lblDescription, ckbStripFont }
	End Function
	Protected Overrides Function GetChildDxButtons() As ASPxButton()
		Return New ASPxButton() { btnOk, btnCancel }
	End Function
End Class