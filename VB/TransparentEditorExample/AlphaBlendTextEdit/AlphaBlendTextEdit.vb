Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports TransparentEditorExample

Namespace ZBobb
	Public Class AlphaBlendTextEdit
		Inherits TextEdit
		Shared Sub New()
			RepositoryItemAlphaBlendTextEdit.RegisterAlphaBlendTextEdit()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemAlphaBlendTextEdit.AlphaBlendTextEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemAlphaBlendTextEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemAlphaBlendTextEdit)
			End Get
		End Property

		Protected Overrides Function CreateMaskBoxInstance() As TextBoxMaskBox
			Return New AlphaBlendTextBox(Me)
		End Function
	End Class
End Namespace