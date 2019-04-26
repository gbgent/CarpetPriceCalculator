Public Class Rectangle

    Private _Width As Single
    Private _length As Single
    Private _area As Single

    Public Sub New()
        _Width = 0
        _length = 0
    End Sub

    Public Sub New(ByVal width As Single, ByVal length As Single)
        _Width = width
        _length = length
    End Sub

    Public Property Width() As Single
        Get
            Return _Width
        End Get
        Set(ByVal value As Single)
            _Width = value
        End Set
    End Property

    Public Property Length() As Single
        Get
            Return _length
        End Get
        Set(ByVal value As Single)
            _length = value
        End Set
    End Property

    Public ReadOnly Property Area() As Single
        Get
            Return _area
        End Get
    End Property

    Public Sub CalcArea()
        _area = _Width * _length
    End Sub


End Class
