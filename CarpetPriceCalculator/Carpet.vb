Public Class Carpet

    Private _color As String
    Private _style As String
    Private _price As Decimal

    Public Sub New()
        _color = String.Empty
        _style = String.Empty
        _price = 0D
    End Sub

    Public Sub New(ByVal color As String, ByVal style As String, ByVal price As Decimal)
        _color = color
        _style = style
        _price = price
    End Sub

    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Public Property Style() As String
        Get
            Return _style
        End Get
        Set(ByVal value As String)
            _style = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value
        End Set
    End Property


End Class
