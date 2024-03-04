Public Class MovieClass
    Private _id As Integer
    Private _title As String
    Private _year As Integer
    Private _rating As Decimal
    Private _rated As String
    Private _duration As String
    Private _genre As String
    Private _cast1 As String
    Private _cast2 As String
    Private _cast3 As String
    Private _cast4 As String
    Private _cast5 As String

    'Constructor
    Public Sub New()

    End Sub

    Public Sub New(title As String, year As Integer, rating As Decimal, rated As String, duration As String, genre As String, cast1 As String, cast2 As String, cast3 As String, cast4 As String, cast5 As String)
        _title = title
        _year = year
        _rating = rating
        _rated = rated
        _duration = duration
        _genre = genre
        _cast1 = cast1
        _cast2 = cast2
        _cast3 = cast3
        _cast4 = cast4
        _cast5 = cast5
    End Sub

    'Getter and Setter
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public Property Rating As Decimal
        Get
            Return _rating
        End Get
        Set(value As Decimal)
            _rating = value
        End Set
    End Property

    Public Property Rated As String
        Get
            Return _rated
        End Get
        Set(value As String)
            _rated = value
        End Set
    End Property

    Public Property Duration As String
        Get
            Return _duration
        End Get
        Set(value As String)
            _duration = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
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
End Class
