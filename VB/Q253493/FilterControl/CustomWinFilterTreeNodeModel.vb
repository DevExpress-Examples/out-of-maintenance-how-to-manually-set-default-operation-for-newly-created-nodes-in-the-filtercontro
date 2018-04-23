Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Filtering

Namespace Q253493.FilterControl
	Public Class CustomWinFilterTreeNodeModel
		Inherits WinFilterTreeNodeModel
		Public Sub New(ByVal control As DevExpress.XtraEditors.FilterControl)
			MyBase.New(control)
		End Sub

		Protected Overrides Function CreateDefaultClauseNode(ByVal [property] As IBoundProperty) As ClauseNode
			Dim result As ClauseNode = MyBase.CreateDefaultClauseNode([property])
			result.Operation = (CType(Control, CustomFilterControl)).GetDefaultOperationCore(result.Property, result.Operation)
			Return result
		End Function

		Public Overrides Function CreateClauseNode() As ClauseNode
			Return New CustomClauseNode(Me)
		End Function
	End Class
End Namespace
