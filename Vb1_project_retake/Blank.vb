Public Class Blank
    Public Sub EraseProfile()
        FormUserInput.tb_username.ResetText()
        FormUserInput.tb_password.ResetText()
        FormUserInput.tb_firstname.ResetText()
        FormUserInput.tb_lastname.ResetText()
        FormUserInput.tb_address.ResetText()
        FormUserInput.tb_telephone.ResetText()
        FormUserInput.NumericUpDown1.Value = 18
        FormUserInput.rb_user.Checked = True
    End Sub

    Public Sub ErrorProfile()
        FormUserInput.ErrorProvider1.SetError(FormUserInput.tb_firstname, String.Empty)
        FormUserInput.ErrorProvider2.SetError(FormUserInput.tb_lastname, String.Empty)
        FormUserInput.ErrorProvider3.SetError(FormUserInput.tb_address, String.Empty)
        FormUserInput.ErrorProvider4.SetError(FormUserInput.tb_telephone, String.Empty)
    End Sub

    Public Sub MovieProfile()
        FormVideoInput.Tb_Title.ResetText()
        FormVideoInput.Num_Year.Value = 1990
        FormVideoInput.Num_Rating.Value = 1.0
        FormVideoInput.Cb_Rated.ResetText()
        FormVideoInput.Tb_duration.ResetText()
    End Sub

End Class
