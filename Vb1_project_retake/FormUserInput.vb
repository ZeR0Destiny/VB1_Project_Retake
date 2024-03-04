Public Class FormUserInput
    Public eraser As New Blank
    Public valid As Boolean = False
    'Public index As Integer

    ''' <summary>
    ''' Return to the main screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Close()
        FormScreenMain.Show()
        eraser.EraseProfile()
        eraser.ErrorProfile()

        tb_username.Enabled = True
        tb_password.Enabled = True

        Dim db As New DBManager()
        Dim user As UserClass = db.LogIn(FormScreenLogin.tb_username.Text, FormScreenLogin.tb_password.Text)

        If user.Level = 0 Then
            FormScreenMain.AddToolStripMenuItem.Visible = False
            FormScreenMain.btn_edit_user.Visible = False
            FormScreenMain.btn_edit_user.Enabled = False
            FormScreenMain.btn_single_user.Visible = True
            FormScreenMain.btn_single_user.Enabled = True
        ElseIf user.Level = 1 Then
            FormScreenMain.AddToolStripMenuItem.Visible = False
            FormScreenMain.btn_edit_user.Visible = True
            FormScreenMain.btn_edit_user.Enabled = True
            FormScreenMain.btn_single_user.Visible = False
            FormScreenMain.btn_single_user.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' When all condition are true, data is saved
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim db As New DBManager
        Dim validate As New Validation
        db.CheckUsername(tb_username.Text)
        If db.valid = False Then
            'MsgBox("hello")
            Dim level As Integer
            If rb_user.Checked Then
                level = 0
            ElseIf rb_admin.Checked Then
                level = 1
            End If

            validate.NoNum()

            If valid = True Then
                valid = False
                validate.NoNum2()
            End If

            If valid = True Then
                valid = False
                validate.Address()
            End If

            If valid = True Then
                valid = False
                validate.Phone()
            End If

            If valid = True And Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_password.Text) Then
                'MsgBox("hello")
                Dim u As New UserClass(tb_username.Text, tb_password.Text, tb_firstname.Text, tb_lastname.Text, NumericUpDown1.Value, tb_address.Text, tb_telephone.Text, level)
                db.AddUser(u)
            Else
                MsgBox("Some fields are empty or incorrect!")
            End If

            eraser.EraseProfile()
        End If
    End Sub

    ''' <summary>
    ''' Action to update a user information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim db As New DBManager
        Dim validate As New Validation

        Dim level As Integer
        If rb_user.Checked Then
            level = 0
        ElseIf rb_admin.Checked Then
            level = 1
        End If

        validate.NoNum()

        If valid = True Then
            valid = False
            validate.NoNum2()
        End If

        If valid = True Then
            valid = False
            validate.Address()
        End If

        If valid = True Then
            valid = False
            validate.Phone()
        End If

        If valid = True And Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_password.Text) Then
            'MsgBox(FormScreenLogin.index)
            Dim u As New UserClass(tb_username.Text, tb_password.Text, tb_firstname.Text, tb_lastname.Text, NumericUpDown1.Value, tb_address.Text, tb_telephone.Text, level)
            db.UpdateUser(u, FormScreenLogin.index)
        Else
            MsgBox("Some fields are empty or incorrect!")
        End If
    End Sub

    ''' <summary>
    ''' Confirm and delete the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim db As New DBManager

        Dim confirm = InputBox("Please confirm the password", "Password Confirmation")

        If confirm.Equals(tb_password.Text) Then
            'MsgBox(index)
            db.DeleteUser(FormScreenLogin.index)
            'GoBackToolStripMenuItem.PerformClick()
            Me.Close()
            FormScreenMain.LogOutToolStripMenuItem.PerformClick()
        End If

    End Sub
End Class