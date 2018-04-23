Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering

Namespace Q253493
	Partial Public Class Form1
		Inherits Form
		Private Const Field1 As String = "Field1"
		Private Const Field2 As String = "Field2"

		Public Sub New()
			InitializeComponent()
			InitializeUnboundColumns()
		End Sub

		Private Sub InitializeUnboundColumns()
			Dim columns As New MyFilterColumnCollection()
			columns.Add(New UnboundFilterColumn("Column 1", Field1, GetType(String), textEditor, FilterColumnClauseClass.String))
			columns.Add(New UnboundFilterColumn("Column 2", Field2, GetType(Integer), spinEditor, FilterColumnClauseClass.Generic))
			AddHandler columns.OnGetDefaultOperation, AddressOf OnFilterColumnCollectionGetDefaultOperation
			filterControl.SetFilterColumnsCollection(columns)
		End Sub

		Private Sub OnFilterColumnCollectionGetDefaultOperation(ByVal sender As Object, ByVal e As GetDefaultOperationEventArgs)
			Select Case e.OperandProperty.PropertyName
				Case Field1
					e.ClauseType = ClauseType.Contains
				Case Field2
					e.ClauseType = ClauseType.Greater
			End Select
		End Sub
	End Class

	Public Class MyFilterColumnCollection
		Inherits FilterColumnCollection
		Public Sub New()
			MyBase.New()
		End Sub

		Private Event fGetDefaultOperation As GetDefaultOperationEventHandler
		Public Custom Event OnGetDefaultOperation As GetDefaultOperationEventHandler
			AddHandler(ByVal value As GetDefaultOperationEventHandler)
				AddHandler fGetDefaultOperation, value
			End AddHandler
			RemoveHandler(ByVal value As GetDefaultOperationEventHandler)
				RemoveHandler fGetDefaultOperation, value
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As GetDefaultOperationEventArgs)
			End RaiseEvent
		End Event
		Private Function RaiseOnGetDefaultOperation(ByVal operandProperty As OperandProperty, ByVal clauseType As ClauseType) As ClauseType
			Dim args As New GetDefaultOperationEventArgs(operandProperty, clauseType)
			RaiseEvent fGetDefaultOperation(Me, args)
			Return args.ClauseType
		End Function

		Public Overrides Function GetDefaultOperation(ByVal operandProperty As OperandProperty) As ClauseType
			Return RaiseOnGetDefaultOperation(operandProperty, MyBase.GetDefaultOperation(operandProperty))
		End Function
	End Class

	Public Delegate Sub GetDefaultOperationEventHandler(ByVal sender As Object, ByVal e As GetDefaultOperationEventArgs)
	Public Class GetDefaultOperationEventArgs
		Inherits EventArgs
		Public Sub New(ByVal [property] As OperandProperty, ByVal operation As ClauseType)
			fOperandProperty = [property]
			fClauseType = operation
		End Sub

		Private fClauseType As ClauseType
		Public Property ClauseType() As ClauseType
			Get
				Return fClauseType
			End Get
			Set(ByVal value As ClauseType)
				fClauseType = value
			End Set
		End Property

		Private fOperandProperty As OperandProperty
		Public ReadOnly Property OperandProperty() As OperandProperty
			Get
				Return fOperandProperty
			End Get
		End Property
	End Class
End Namespace
