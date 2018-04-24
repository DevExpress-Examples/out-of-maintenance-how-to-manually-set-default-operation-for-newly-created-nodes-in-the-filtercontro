Imports System
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering.Helpers

Namespace Q253493.FilterControl
    Public Class CustomFilterControl
        Inherits DevExpress.XtraEditors.FilterControl

        Protected Overrides Function CreateModel() As WinFilterTreeNodeModel
            Return New CustomWinFilterTreeNodeModel(Me)
        End Function

        Private Sub RaiseGetDefaultOperation(ByVal args As GetDefaultOperationEventArgs)
            Dim handler As EventHandler(Of GetDefaultOperationEventArgs) = TryCast(Events(fGetDefaultOperation), EventHandler(Of GetDefaultOperationEventArgs))
            If handler IsNot Nothing Then
                handler(Me, args)
            End If
        End Sub

        Friend Function GetDefaultOperationCore(ByVal [property] As IBoundProperty, ByVal operation As ClauseType) As ClauseType
            Dim args As New GetDefaultOperationEventArgs([property], operation)
            RaiseGetDefaultOperation(args)
            Return args.ClauseType
        End Function

        Private Shared ReadOnly fGetDefaultOperation As New Object()
        Public Custom Event GetDefaultOperation As EventHandler(Of GetDefaultOperationEventArgs)
            AddHandler(ByVal value As EventHandler(Of GetDefaultOperationEventArgs))
                Events.AddHandler(fGetDefaultOperation, value)
            End AddHandler
            RemoveHandler(ByVal value As EventHandler(Of GetDefaultOperationEventArgs))
                Events.RemoveHandler(fGetDefaultOperation, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As GetDefaultOperationEventArgs)
            End RaiseEvent
        End Event
    End Class
End Namespace
