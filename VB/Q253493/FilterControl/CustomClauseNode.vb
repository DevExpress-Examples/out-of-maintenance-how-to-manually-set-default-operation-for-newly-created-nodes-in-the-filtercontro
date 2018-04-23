Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Filtering

Namespace Q253493.FilterControl
	Public Class CustomClauseNode
		Inherits ClauseNode
		Public Sub New(ByVal model As FilterTreeNodeModel)
			MyBase.New(model)
		End Sub

		Protected Overrides Sub ClauseNodeFirstOperandChanged(ByVal newProp As OperandProperty, ByVal elementIndex As Integer)
			MyBase.ClauseNodeFirstOperandChanged(newProp, elementIndex)
			Operation = (CType((CType(Model, WinFilterTreeNodeModel)).Control, CustomFilterControl)).GetDefaultOperationCore(FilterProperties.GetProperty(newProp), Operation)
		End Sub
	End Class
End Namespace
