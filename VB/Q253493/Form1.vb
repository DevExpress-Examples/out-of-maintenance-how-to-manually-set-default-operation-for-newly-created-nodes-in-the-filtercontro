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
Imports Q253493.FilterControl

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
            filterControl.FilterColumns.Add(New UnboundFilterColumn("Column 1", Field1, GetType(String), textEditor, FilterColumnClauseClass.String))
            filterControl.FilterColumns.Add(New UnboundFilterColumn("Column 2", Field2, GetType(Integer), spinEditor, FilterColumnClauseClass.Generic))
        End Sub

        Private Sub OnGetDefaultOperation(ByVal sender As Object, ByVal e As GetDefaultOperationEventArgs) Handles filterControl.GetDefaultOperation
            Select Case e.OperandProperty.Name
                Case Field1
                    e.ClauseType = ClauseType.Contains
                Case Field2
                    e.ClauseType = ClauseType.Greater
            End Select
        End Sub
    End Class
End Namespace
