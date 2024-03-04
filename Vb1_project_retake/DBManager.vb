Imports MySql.Data.MySqlClient

Public Class DBManager
    Private connectionString = "server=localhost;user id=root;password=;database=Vb1_project_retake;"
    Private connect As New MySqlConnection()
    Public valid As Boolean = False

    ''' <summary>
    ''' Constructor, opens connection
    ''' </summary>
    Public Sub New()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' List all the user within the database
    ''' </summary>
    Public Sub ListUser()
        'Me.connect.Close()
        Try
            'Me.connect = New MySqlConnection(connectionString)
            'Me.connect.Open()

            Dim query As String = "SELECT * FROM users"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With FormScreenMain.users_lists
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Username"
                .Columns(2).HeaderText = "Password"
                .Columns(3).HeaderText = "Firstname"
                .Columns(4).HeaderText = "Lastname"
                .Columns(5).HeaderText = "Age"
                .Columns(6).HeaderText = "Address"
                .Columns(7).HeaderText = "Telephone"
                .Columns(8).HeaderText = "Level"

                .Columns(0).Width = 40
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).Width = 30
                .Columns(6).Width = 150
                .Columns(7).Width = 100
                .Columns(8).Width = 40
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' Verify the database with the input username and password 
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    Public Function LogIn(ByVal username As String, ByVal password As String)
        Dim query As String = "SELECT * FROM users WHERE Username = '" & username & "' AND Password = '" & password & "'"
        Dim user As New UserClass()
        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                user.Id = reader.GetInt32(0)
                user.Username = reader.GetString(1)
                user.Password = reader.GetString(2)
                'user.Firstname = reader.GetString(3)
                'user.Lastname = reader.GetString(4)
                'user.Age = reader.GetInt32(5)
                'user.Address = reader.GetString(6)
                'user.Telephone = reader.GetString(7)
                user.Level = reader.GetInt32(8)
            Else
                MsgBox("Username/password not exist!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return user
    End Function

    ''' <summary>
    ''' Query to insert a new user to the database
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function AddUser(user As UserClass)
        Dim cmd As New MySqlCommand
        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO users VALUES(DEFAULT, @Username, @Password, @Firstname, @Lastname, @Age, @Address, @Telephone, @level)"
            cmd.Parameters.AddWithValue("@Username", user.Username)
            cmd.Parameters.AddWithValue("@Password", user.Password)
            cmd.Parameters.AddWithValue("@Firstname", user.Firstname)
            cmd.Parameters.AddWithValue("@Lastname", user.Lastname)
            cmd.Parameters.AddWithValue("@Age", user.Age)
            cmd.Parameters.AddWithValue("@Address", user.Address)
            cmd.Parameters.AddWithValue("@Telephone", user.Telephone)
            cmd.Parameters.AddWithValue("@Level", user.Level)

            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " New user created!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return user
    End Function

    ''' <summary>
    ''' If the inputed username exist then valid is true
    ''' </summary>
    ''' <param name="username"></param>
    ''' <returns></returns>
    Public Function CheckUsername(username As String)
        Dim query As String = "SELECT * FROM users WHERE Username = '" & username & "'"
        Dim user As New UserClass()
        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                'user.Id = reader.GetInt32(0)
                user.Username = reader.GetString(1)
                'user.Password = reader.GetString(2)
                'user.Firstname = reader.GetString(3)
                'user.Lastname = reader.GetString(4)
                'user.Age = reader.GetInt32(5)
                'user.Address = reader.GetString(6)
                'user.Telephone = reader.GetString(7)
                'user.Level = reader.GetInt32(8)
                valid = True

                MsgBox("Username already exist!")
            Else
                valid = False
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return user
    End Function

    ''' <summary>
    ''' Query to update the variable of a user in from the database
    ''' </summary>
    ''' <param name="user"></param>
    Public Sub UpdateUser(user As UserClass, id As Integer)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE users SET Username = @username, Password = @password, 
                Firstname = @firstname, Lastname = @lastname, Age = @age, Address = @address,
                Telephone = @telephone, level = @level WHERE ID = " & id
            cmd.Parameters.AddWithValue("@username", user.Username)
            cmd.Parameters.AddWithValue("@password", user.Password)
            cmd.Parameters.AddWithValue("@firstname", user.Firstname)
            cmd.Parameters.AddWithValue("@lastname", user.Lastname)
            cmd.Parameters.AddWithValue("@age", user.Age)
            cmd.Parameters.AddWithValue("@address", user.Address)
            cmd.Parameters.AddWithValue("@telephone", user.Telephone)
            cmd.Parameters.AddWithValue("@level", user.Level)

            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " User information have been updated!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' Query to delete a user from the database
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub DeleteUser(id As String)
        Dim cmd As New MySqlCommand
        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "DELETE FROM users WHERE ID = " & id & ""
            cmd.Parameters.AddWithValue("ID", id)
            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " User Deleted!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Function SingleUser(id As Integer)
        Dim query As String = "SELECT * FROM users WHERE ID = '" & id & "'"
        Dim user As New UserClass()
        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                user.Id = reader.GetInt32(0)
                user.Username = reader.GetString(1)
                user.Password = reader.GetString(2)
                user.Firstname = reader.GetString(3)
                user.Lastname = reader.GetString(4)
                user.Age = reader.GetInt32(5)
                user.Address = reader.GetString(6)
                user.Telephone = reader.GetString(7)
                user.Level = reader.GetInt32(8)
            Else
                MsgBox("Id not exist!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return user
    End Function

    ''' <summary>
    ''' List all the movies
    ''' </summary>
    Public Sub ListMovie()
        Try
            Dim query As String = "SELECT * FROM movies"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With FormVideoList.Video_List
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Title"
                .Columns(2).HeaderText = "Year"
                .Columns(3).HeaderText = "Rating"
                .Columns(4).HeaderText = "Rated"
                .Columns(5).HeaderText = "Duration"
                .Columns(6).HeaderText = "Genre"
                .Columns(7).HeaderText = "Cast 1"
                .Columns(8).HeaderText = "Cast 2"
                .Columns(9).HeaderText = "Cast 3"
                .Columns(10).HeaderText = "Cast 4"
                .Columns(11).HeaderText = "Cast 5"

                .Columns(0).Width = 40
                .Columns(1).Width = 200
                .Columns(2).Width = 40
                .Columns(3).Width = 40
                .Columns(4).Width = 60
                .Columns(5).Width = 60
                .Columns(6).Width = 150
                .Columns(6).Width = 150
                .Columns(6).Width = 150
                .Columns(6).Width = 150
                .Columns(6).Width = 150
                .Columns(6).Width = 150
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' Query to add movie
    ''' </summary>
    ''' <param name="movie"></param>
    ''' <returns></returns>
    Public Function AddMovie(movie As MovieClass)
        Dim cmd As New MySqlCommand
        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO movies VALUES(DEFAULT, @Title, @Year, @Rating, @Rated, @Duration, @Genre, @Cast_1, @Cast_2, @Cast_3, @Cast_4, @Cast_5)"
            cmd.Parameters.AddWithValue("@Title", movie.Title)
            cmd.Parameters.AddWithValue("@Year", movie.Year)
            cmd.Parameters.AddWithValue("@Rating", movie.Rating)
            cmd.Parameters.AddWithValue("@Rated", movie.Rated)
            cmd.Parameters.AddWithValue("@Duration", movie.Duration)
            cmd.Parameters.AddWithValue("@Genre", movie.Genre)
            cmd.Parameters.AddWithValue("@Cast_1", movie.Cast1)
            cmd.Parameters.AddWithValue("@Cast_2", movie.Cast2)
            cmd.Parameters.AddWithValue("@Cast_3", movie.Cast3)
            cmd.Parameters.AddWithValue("@Cast_4", movie.Cast4)
            cmd.Parameters.AddWithValue("@Cast_5", movie.Cast5)

            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " New movie added!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return movie
    End Function

    ''' <summary>
    ''' Query to check movie with the title
    ''' </summary>
    ''' <param name="title"></param>
    ''' <returns></returns>
    Public Function CheckTitle(title As String)
        Dim query As String = "SELECT * FROM movies WHERE Title = '" & title & "'"
        Dim movie As New MovieClass()
        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                movie.Title = reader.GetString(1)

                valid = True

                MsgBox("Movie already exist!")
            Else
                valid = False
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
        Return movie
    End Function

    ''' <summary>
    ''' Query to delete movie of the id
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub DeleteMovie(id As String)
        Dim cmd As New MySqlCommand
        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "DELETE FROM movies WHERE ID = " & id & ""
            cmd.Parameters.AddWithValue("ID", id)
            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " Movie Deleted!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Sub UpdateMovie(movie As MovieClass, id As Integer)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE movies SET Title = @title, Year = @year, 
                Rating = @rating, Rated = @rated, Duration = @duration, Genre = @genre,
                Cast_1 = @cast_1, Cast_2 = @cast_2, Cast_3 = @cast_3, Cast_4 = @cast_4, Cast_5 = @cast_5 WHERE ID = " & id
            cmd.Parameters.AddWithValue("@title", movie.Title)
            cmd.Parameters.AddWithValue("@year", movie.Year)
            cmd.Parameters.AddWithValue("@rating", movie.Rating)
            cmd.Parameters.AddWithValue("@rated", movie.Rated)
            cmd.Parameters.AddWithValue("@duration", movie.Duration)
            cmd.Parameters.AddWithValue("@genre", movie.Genre)
            cmd.Parameters.AddWithValue("@cast_1", movie.Cast1)
            cmd.Parameters.AddWithValue("@cast_2", movie.Cast2)
            cmd.Parameters.AddWithValue("@cast_3", movie.Cast3)
            cmd.Parameters.AddWithValue("@cast_4", movie.Cast4)
            cmd.Parameters.AddWithValue("@cast_5", movie.Cast5)

            'Display a confirmation message
            Dim confirmation = cmd.ExecuteNonQuery()
            MsgBox(confirmation & " Movie information have been updated!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
End Class
