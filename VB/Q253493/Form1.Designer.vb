Imports Microsoft.VisualBasic
Imports System
Namespace Q253493
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
			Me.filterControl = New Q253493.FilterControl.CustomFilterControl()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.textEditor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.spinEditor = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			CType(Me.textEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' filterControl
			' 
			Me.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.filterControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.filterControl.Location = New System.Drawing.Point(0, 0)
			Me.filterControl.Name = "filterControl"
			Me.filterControl.Size = New System.Drawing.Size(292, 268)
			Me.filterControl.TabIndex = 0
			Me.filterControl.Text = "filterControl1"
'			Me.filterControl.GetDefaultOperation += New System.EventHandler(Of Q253493.FilterControl.GetDefaultOperationEventArgs)(OnGetDefaultOperation);
			' 
			' persistentRepository1
			' 
			Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.textEditor, Me.spinEditor})
			' 
			' textEditor
			' 
			Me.textEditor.Name = "textEditor"
			' 
			' spinEditor
			' 
			Me.spinEditor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEditor.Name = "spinEditor"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 268)
			Me.Controls.Add(Me.filterControl)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents filterControl As Q253493.FilterControl.CustomFilterControl
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private textEditor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private spinEditor As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
	End Class
End Namespace

