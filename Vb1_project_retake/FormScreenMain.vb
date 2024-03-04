Public Class FormScreenMain
    Public index As Integer
    Public selectedRow As DataGridViewRow

    ''' <summary>
    ''' Handles the display of the user list from the database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Users_Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager()
        db.ListUser()
    End Sub

    ''' <summary>
    ''' Logs the user out
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LogOutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        FormScreenLogin.Show()
        FormScreenLogin.tb_username.ResetText()
        FormScreenLogin.tb_password.ResetText()
    End Sub

    ''' <summary>
    ''' Exit the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Navigate to the create a new user menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Me.Close()
        FormUserInput.Show()

        FormUserInput.Label9.Visible = True
        FormUserInput.btn_save.Visible = True
        FormUserInput.btn_save.Enabled = True

        FormUserInput.Label10.Visible = False
        FormUserInput.btn_update.Visible = False
        FormUserInput.btn_update.Enabled = False

        FormUserInput.DeleteToolStripMenuItem.Enabled = False
    End Sub

    ''' <summary>
    ''' Return the index of the selected row
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub users_lists_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles users_lists.CellClick
        index = e.RowIndex
        'MsgBox(index + 1)
        'MsgBox(index)
    End Sub

    ''' <summary>
    ''' Navigate to the edit user menu when a row is selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_edit_user_Click(sender As Object, e As EventArgs) Handles btn_edit_user.Click
        FormUserInput.Show()

        selectedRow = users_lists.Rows(index)
        FormUserInput.tb_username.Text = selectedRow.Cells(1).Value.ToString
        FormUserInput.tb_password.Text = selectedRow.Cells(2).Value.ToString
        FormUserInput.tb_firstname.Text = selectedRow.Cells(3).Value.ToString
        FormUserInput.tb_lastname.Text = selectedRow.Cells(4).Value.ToString
        FormUserInput.NumericUpDown1.Value = selectedRow.Cells(5).Value
        FormUserInput.tb_address.Text = selectedRow.Cells(6).Value.ToString
        FormUserInput.tb_telephone.Text = selectedRow.Cells(7).Value.ToString
        If selectedRow.Cells(8).Value = 0 Then
            FormUserInput.rb_user.Checked = True
        ElseIf selectedRow.Cells(8).Value = 1 Then
            FormUserInput.rb_admin.Checked = True
        End If

        FormUserInput.Label9.Visible = False
        FormUserInput.btn_save.Visible = False
        FormUserInput.btn_save.Enabled = False

        FormUserInput.Label10.Visible = True
        FormUserInput.btn_update.Visible = True
        FormUserInput.btn_update.Enabled = True

        FormUserInput.DeleteToolStripMenuItem.Enabled = True

        FormUserInput.tb_username.Enabled = False
        FormUserInput.tb_password.Enabled = False

        'index += 1
        FormScreenLogin.index = selectedRow.Cells(0).Value

        Me.Close()
    End Sub

    Private Sub btn_single_user_Click(sender As Object, e As EventArgs) Handles btn_single_user.Click
        FormUserInput.Show()

        Dim db As New DBManager()
        Dim user As UserClass = db.SingleUser(FormScreenLogin.index)

        FormUserInput.tb_username.Text = user.Username
        FormUserInput.tb_password.Text = user.Password
        FormUserInput.tb_firstname.Text = user.Firstname
        FormUserInput.tb_lastname.Text = user.Lastname
        FormUserInput.NumericUpDown1.Value = user.Age
        FormUserInput.tb_address.Text = user.Address
        FormUserInput.tb_telephone.Text = user.Telephone
        If user.Level = 0 Then
            FormUserInput.rb_user.Checked = True
        ElseIf user.Level = 1 Then
            FormUserInput.rb_admin.Checked = True
        End If

        FormUserInput.tb_username.Enabled = False
        FormUserInput.tb_password.Enabled = False

        Me.Close()
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        Me.Hide()
        FormVideoList.Show()
    End Sub
End Class
