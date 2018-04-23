Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

Namespace ZBobb
	<UserRepositoryItem("RegisterAlphaBlendTextEdit")> _
	Public Class RepositoryItemAlphaBlendTextEdit
		Inherits RepositoryItemTextEdit
		Shared Sub New()
			RegisterAlphaBlendTextEdit()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Friend Const AlphaBlendTextEditName As String = "AlphaBlendTextEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return AlphaBlendTextEditName
			End Get
		End Property

		Private fBackAlpha As Integer
		Public Property BackAlpha() As Integer
			Get
				Return fBackAlpha
			End Get
			Set(ByVal value As Integer)
				Dim v As Integer = value
				If v > 255 Then
					v = 255
				End If
				fBackAlpha = v
				OnPropertiesChanged()
			End Set
		End Property

		Public Shared Sub RegisterAlphaBlendTextEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(AlphaBlendTextEditName, GetType(AlphaBlendTextEdit), GetType(RepositoryItemAlphaBlendTextEdit), GetType(TextEditViewInfo), New TextEditPainter(), True))
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			BeginUpdate()
			Try
				Dim source As RepositoryItemAlphaBlendTextEdit = CType(item, RepositoryItemAlphaBlendTextEdit)
				BackAlpha = source.BackAlpha
			Finally
				EndUpdate()
			End Try
		End Sub

		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			Appearance.BackColor = Color.Transparent
		End Sub
	End Class
End Namespace