Public Class CastClass
    Private _cast As Integer
    Private _cast1 As String
    Private _cast2 As String
    Private _cast3 As String
    Private _cast4 As String
    Private _cast5 As String
    Private _movie_id As Integer

    Public Sub New()
    End Sub

    Public Sub New(cast As Integer, cast1 As String, cast2 As String, cast3 As String, cast4 As String, cast5 As String, movie_id As Integer)
        _cast = cast
        _cast1 = cast1
        _cast2 = cast2
        _cast3 = cast3
        _cast4 = cast4
        _cast5 = cast5
        _movie_id = movie_id
    End Sub

    'Getter and SEtter
    Public Property Cast As Integer
        Get
            Return _cast
        End Get
        Set(value As Integer)
            _cast = value
        End Set
    End Property

    Public Property Cast1 As String
        Get
            Return _cast1
        End Get
        Set(value As String)
            _cast1 = value
        End Set
    End Property

    Public Property Cast2 As String
        Get
            Return _cast2
        End Get
        Set(value As String)
            _cast2 = value
        End Set
    End Property

    Public Property Cast3 As String
        Get
            Return _cast3
        End Get
        Set(value As String)
            _cast3 = value
        End Set
    End Property

    Public Property Cast4 As String
        Get
            Return _cast4
        End Get
        Set(value As String)
            _cast4 = value
        End Set
    End Property

    Public Property Cast5 As String
        Get
            Return _cast5
        End Get
        Set(value As String)
            _cast5 = value
        End Set
    End Property

    Public Property Movie_id As Integer
        Get
            Return _movie_id
        End Get
        Set(value As Integer)
            _movie_id = value
        End Set
    End Property
End Class
