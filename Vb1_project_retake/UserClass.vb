Public Class UserClass
    '1.Primary information
    Private _id As Integer
    Private _username As String
    Private _password As String
    Private _firstname As String
    Private _lastname As String
    Private _age As Integer
    Private _address As String
    Private _telephone As String
    Private _level As Integer

    'Constructor
    Public Sub New()

    End Sub

    Public Sub New(username As String, password As String)
        _username = username
        _password = password
    End Sub


    Public Sub New(username As String, password As String, firstname As String, lastname As String, age As Integer, address As String, telephone As String, level As Integer)
        _username = username
        _password = password
        _firstname = firstname
        _firstname = firstname
        _lastname = lastname
        _age = age
        _address = address
        _telephone = telephone
        _level = level
    End Sub

    Public Sub New(id As Integer, username As String, password As String, firstname As String, lastname As String, age As Integer, address As String, telephone As String, level As Integer)
        _id = id
        _username = username
        _password = password
        _firstname = firstname
        _firstname = firstname
        _lastname = lastname
        _age = age
        _address = address
        _telephone = telephone
        _level = level
    End Sub

    'Getter/Setter
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Telephone As String
        Get
            Return _telephone
        End Get
        Set(value As String)
            _telephone = value
        End Set
    End Property

    Public Property Level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property
End Class
