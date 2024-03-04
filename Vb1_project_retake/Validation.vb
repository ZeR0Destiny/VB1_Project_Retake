Public Class Validation
    Public Sub NoNum()
        'Validete the firstname
        For Each character As Char In FormUserInput.tb_firstname.Text
            If Not Char.IsLetter(character) Or String.IsNullOrEmpty(FormUserInput.tb_firstname.Text) Then
                FormUserInput.ErrorProvider1.SetError(FormUserInput.tb_firstname, "Contain none letter!")
                FormUserInput.valid = False
                Exit For
                Exit Sub
            Else
                FormUserInput.ErrorProvider1.SetError(FormUserInput.tb_firstname, String.Empty)
                FormUserInput.valid = True
            End If
        Next
    End Sub

    Public Sub NoNum2()
        'Validate the lastname
        For Each character As Char In FormUserInput.tb_lastname.Text
            If Not Char.IsLetter(character) Then
                FormUserInput.ErrorProvider2.SetError(FormUserInput.tb_lastname, "Contain none letter!")
                FormUserInput.valid = False
                Exit For
            Else
                FormUserInput.ErrorProvider2.SetError(FormUserInput.tb_lastname, String.Empty)
                FormUserInput.valid = True
            End If
        Next
    End Sub

    Public Sub Address()
        If Not String.IsNullOrEmpty(FormUserInput.tb_address.Text) Then
            If FormUserInput.tb_address.Text Like "###[ ]*" Then
                FormUserInput.ErrorProvider3.SetError(FormUserInput.tb_address, String.Empty)
                FormUserInput.valid = True
            ElseIf FormUserInput.tb_address.Text Like "####[ ]*" Then
                FormUserInput.ErrorProvider3.SetError(FormUserInput.tb_address, String.Empty)
                FormUserInput.valid = True
            Else
                FormUserInput.ErrorProvider3.SetError(FormUserInput.tb_address, "Incorret address format!")
                FormUserInput.valid = False
            End If
        End If
    End Sub

    'Valdiate the phone number
    Public Sub Phone()
        If Not String.IsNullOrEmpty(FormUserInput.tb_telephone.Text) Then
            If FormUserInput.tb_telephone.Text Like "###[-]###[-]####" Then
                FormUserInput.ErrorProvider4.SetError(FormUserInput.tb_telephone, String.Empty)
                FormUserInput.valid = True
            Else
                FormUserInput.ErrorProvider4.SetError(FormUserInput.tb_telephone, "###-###-####")
                FormUserInput.valid = False
            End If
        End If
    End Sub

    Public Sub Duration()
        If Not String.IsNullOrEmpty(FormVideoInput.Tb_duration.Text) Then
            If FormVideoInput.Tb_duration.Text Like "#[h]##[m]" Then
                FormVideoInput.ErrorProvider1.SetError(FormVideoInput.Tb_duration, String.Empty)
                FormVideoInput.valid = True

            ElseIf FormVideoInput.Tb_duration.Text Like "#[h]#[m]" Then
                FormVideoInput.ErrorProvider1.SetError(FormVideoInput.Tb_duration, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider1.SetError(FormVideoInput.Tb_duration, "Ex: 2h3m/2h15m")
                FormVideoInput.valid = False
            End If
        End If
    End Sub

    Public Sub OnlyLetter()
        'Cast 1
        For Each character As Char In FormVideoInput.Tb_Cast1.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider2.SetError(FormVideoInput.Tb_Cast1, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider2.SetError(FormVideoInput.Tb_Cast1, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter2()
        For Each character As Char In FormVideoInput.Tb_as_cast1.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider2.SetError(FormVideoInput.Tb_as_cast1, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider2.SetError(FormVideoInput.Tb_as_cast1, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter3()
        'Cast 2
        For Each character As Char In FormVideoInput.Tb_Cast2.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast2, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast2, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter4()
        For Each character As Char In FormVideoInput.Tb_as_cast2.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast2, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast2, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter5()
        'Cast 3
        For Each character As Char In FormVideoInput.Tb_Cast3.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast3, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast3, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter6()
        For Each character As Char In FormVideoInput.Tb_as_cast3.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast3, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast3, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter7()
        'Cast 4
        For Each character As Char In FormVideoInput.Tb_Cast4.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast4, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast4, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter8()
        For Each character As Char In FormVideoInput.Tb_as_cast4.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast4, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast4, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter9()
        'Cast 5
        For Each character As Char In FormVideoInput.Tb_Cast5.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast5, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_Cast5, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

    Public Sub OnlyLetter10()
        For Each character As Char In FormVideoInput.Tb_as_cast5.Text
            If Char.IsLetter(character) Or character = " " Then
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast5, String.Empty)
                FormVideoInput.valid = True
            Else
                FormVideoInput.ErrorProvider3.SetError(FormVideoInput.Tb_as_cast5, "Contain none letter!")
                FormVideoInput.valid = False
                Exit For
            End If
        Next
    End Sub

End Class
