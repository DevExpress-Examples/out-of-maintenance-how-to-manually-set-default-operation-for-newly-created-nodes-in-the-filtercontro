Imports System
Imports System.Linq
Imports DevExpress.Data
Imports System.Collections.Generic
Imports DevExpress.Data.Filtering.Helpers

Namespace Q253493.FilterControl
    Public Class GetDefaultOperationEventArgs
        Inherits EventArgs

        Public Sub New(ByVal [property] As IBoundProperty, ByVal operation As ClauseType)
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

        Private fOperandProperty As IBoundProperty
        Public ReadOnly Property OperandProperty() As IBoundProperty
            Get
                Return fOperandProperty
            End Get
        End Property
    End Class
End Namespace
