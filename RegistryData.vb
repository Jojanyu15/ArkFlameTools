Imports Microsoft.VisualBasic

Public Class RegistryData
    Public Sub New(ByVal name As String, ByVal fecha As String)
        _name = name
        _date = fecha
    End Sub

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _date As String
    Public Property Fecha() As String
        Get
            Return _date
        End Get
        Set(ByVal value As String)
            _date = value
        End Set
    End Property
End Class
