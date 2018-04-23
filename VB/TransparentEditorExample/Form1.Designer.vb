Imports Microsoft.VisualBasic
Imports System
Namespace TransparentEditorExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.nwindDataSet = New TransparentEditorExample.nwindDataSet()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customersTableAdapter = New TransparentEditorExample.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.alphaBlendTextEdit9 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit8 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit7 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit6 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit5 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit4 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit3 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit2 = New ZBobb.AlphaBlendTextEdit()
			Me.alphaBlendTextEdit1 = New ZBobb.AlphaBlendTextEdit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.alphaBlendTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(13, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(79, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Company Name:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(204, 15)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(72, 13)
			Me.labelControl2.TabIndex = 3
			Me.labelControl2.Text = "Contact Name:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(13, 41)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(65, 13)
			Me.labelControl3.TabIndex = 5
			Me.labelControl3.Text = "Contact Title:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(204, 41)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(43, 13)
			Me.labelControl4.TabIndex = 7
			Me.labelControl4.Text = "Address:"
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(13, 67)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(23, 13)
			Me.labelControl5.TabIndex = 9
			Me.labelControl5.Text = "City:"
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(204, 67)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(37, 13)
			Me.labelControl6.TabIndex = 11
			Me.labelControl6.Text = "Region:"
			' 
			' labelControl7
			' 
			Me.labelControl7.Location = New System.Drawing.Point(13, 93)
			Me.labelControl7.Name = "labelControl7"
			Me.labelControl7.Size = New System.Drawing.Size(61, 13)
			Me.labelControl7.TabIndex = 13
			Me.labelControl7.Text = "Postal Code:"
			' 
			' labelControl8
			' 
			Me.labelControl8.Location = New System.Drawing.Point(204, 93)
			Me.labelControl8.Name = "labelControl8"
			Me.labelControl8.Size = New System.Drawing.Size(43, 13)
			Me.labelControl8.TabIndex = 15
			Me.labelControl8.Text = "Country:"
			' 
			' labelControl9
			' 
			Me.labelControl9.Location = New System.Drawing.Point(13, 119)
			Me.labelControl9.Name = "labelControl9"
			Me.labelControl9.Size = New System.Drawing.Size(34, 13)
			Me.labelControl9.TabIndex = 17
			Me.labelControl9.Text = "Phone:"
			' 
			' labelControl10
			' 
			Me.labelControl10.Location = New System.Drawing.Point(204, 119)
			Me.labelControl10.Name = "labelControl10"
			Me.labelControl10.Size = New System.Drawing.Size(22, 13)
			Me.labelControl10.TabIndex = 19
			Me.labelControl10.Text = "Fax:"
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.DataSource = Me.customersBindingSource
			Me.dataNavigator1.Location = New System.Drawing.Point(13, 142)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(369, 24)
			Me.dataNavigator1.TabIndex = 20
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' alphaBlendTextEdit9
			' 
			Me.alphaBlendTextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "Phone", True))
			Me.alphaBlendTextEdit9.Location = New System.Drawing.Point(98, 116)
			Me.alphaBlendTextEdit9.Name = "alphaBlendTextEdit9"
			Me.alphaBlendTextEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit9.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit9.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit9.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit9.TabIndex = 16
			' 
			' alphaBlendTextEdit8
			' 
			Me.alphaBlendTextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "Country", True))
			Me.alphaBlendTextEdit8.Location = New System.Drawing.Point(282, 90)
			Me.alphaBlendTextEdit8.Name = "alphaBlendTextEdit8"
			Me.alphaBlendTextEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit8.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit8.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit8.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit8.TabIndex = 14
			' 
			' alphaBlendTextEdit7
			' 
			Me.alphaBlendTextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "PostalCode", True))
			Me.alphaBlendTextEdit7.Location = New System.Drawing.Point(98, 90)
			Me.alphaBlendTextEdit7.Name = "alphaBlendTextEdit7"
			Me.alphaBlendTextEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit7.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit7.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit7.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit7.TabIndex = 12
			' 
			' alphaBlendTextEdit6
			' 
			Me.alphaBlendTextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "Region", True))
			Me.alphaBlendTextEdit6.Location = New System.Drawing.Point(282, 64)
			Me.alphaBlendTextEdit6.Name = "alphaBlendTextEdit6"
			Me.alphaBlendTextEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit6.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit6.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit6.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit6.TabIndex = 10
			' 
			' alphaBlendTextEdit5
			' 
			Me.alphaBlendTextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "City", True))
			Me.alphaBlendTextEdit5.Location = New System.Drawing.Point(98, 64)
			Me.alphaBlendTextEdit5.Name = "alphaBlendTextEdit5"
			Me.alphaBlendTextEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit5.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit5.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit5.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit5.TabIndex = 8
			' 
			' alphaBlendTextEdit4
			' 
			Me.alphaBlendTextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "Address", True))
			Me.alphaBlendTextEdit4.Location = New System.Drawing.Point(282, 38)
			Me.alphaBlendTextEdit4.Name = "alphaBlendTextEdit4"
			Me.alphaBlendTextEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit4.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit4.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit4.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit4.TabIndex = 6
			' 
			' alphaBlendTextEdit3
			' 
			Me.alphaBlendTextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "ContactTitle", True))
			Me.alphaBlendTextEdit3.Location = New System.Drawing.Point(98, 38)
			Me.alphaBlendTextEdit3.Name = "alphaBlendTextEdit3"
			Me.alphaBlendTextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit3.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit3.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit3.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit3.TabIndex = 4
			' 
			' alphaBlendTextEdit2
			' 
			Me.alphaBlendTextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "ContactName", True))
			Me.alphaBlendTextEdit2.Location = New System.Drawing.Point(282, 12)
			Me.alphaBlendTextEdit2.Name = "alphaBlendTextEdit2"
			Me.alphaBlendTextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit2.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit2.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit2.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit2.TabIndex = 2
			' 
			' alphaBlendTextEdit1
			' 
			Me.alphaBlendTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customersBindingSource, "CompanyName", True))
			Me.alphaBlendTextEdit1.Location = New System.Drawing.Point(98, 12)
			Me.alphaBlendTextEdit1.Name = "alphaBlendTextEdit1"
			Me.alphaBlendTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.alphaBlendTextEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.alphaBlendTextEdit1.Properties.BackAlpha = 0
			Me.alphaBlendTextEdit1.Size = New System.Drawing.Size(100, 20)
			Me.alphaBlendTextEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(390, 171)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.labelControl10)
			Me.Controls.Add(Me.labelControl9)
			Me.Controls.Add(Me.alphaBlendTextEdit9)
			Me.Controls.Add(Me.labelControl8)
			Me.Controls.Add(Me.alphaBlendTextEdit8)
			Me.Controls.Add(Me.labelControl7)
			Me.Controls.Add(Me.alphaBlendTextEdit7)
			Me.Controls.Add(Me.labelControl6)
			Me.Controls.Add(Me.alphaBlendTextEdit6)
			Me.Controls.Add(Me.labelControl5)
			Me.Controls.Add(Me.alphaBlendTextEdit5)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.alphaBlendTextEdit4)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.alphaBlendTextEdit3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.alphaBlendTextEdit2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.alphaBlendTextEdit1)
			Me.LookAndFeel.SkinName = "Xmas 2008 Blue"
			Me.LookAndFeel.UseDefaultLookAndFeel = False
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.alphaBlendTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As TransparentEditorExample.nwindDataSetTableAdapters.CustomersTableAdapter
		Private alphaBlendTextEdit1 As ZBobb.AlphaBlendTextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit2 As ZBobb.AlphaBlendTextEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit3 As ZBobb.AlphaBlendTextEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit4 As ZBobb.AlphaBlendTextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit5 As ZBobb.AlphaBlendTextEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit6 As ZBobb.AlphaBlendTextEdit
		Private labelControl7 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit7 As ZBobb.AlphaBlendTextEdit
		Private labelControl8 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit8 As ZBobb.AlphaBlendTextEdit
		Private labelControl9 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit9 As ZBobb.AlphaBlendTextEdit
		Private labelControl10 As DevExpress.XtraEditors.LabelControl
		Private alphaBlendTextEdit10 As ZBobb.AlphaBlendTextEdit
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

	End Class
End Namespace

