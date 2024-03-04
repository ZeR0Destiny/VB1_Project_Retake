Public Class FormScreenLogin
    Public index As Integer
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim db As New DBManager()

        If tb_username.Text = "" Or tb_password.Text = "" Then
            MsgBox("Username/password entry empty!")
        Else
            Dim user As UserClass = db.LogIn(tb_username.Text, tb_password.Text)

            If user.Username IsNot Nothing Then
                If user.Level = 1 Then
                    MsgBox("Welcome, " + user.Username + " you've successfully signed in!")
                    FormScreenMain.AddToolStripMenuItem.Visible = True
                    FormScreenMain.btn_edit_user.Visible = True
                    FormScreenMain.btn_edit_user.Enabled = True
                    FormScreenMain.btn_single_user.Visible = False
                    FormScreenMain.btn_single_user.Enabled = False
                    FormVideoList.AddToolStripMenuItem.Visible = True
                    FormScreenMain.Show()
                    Me.Hide()
                ElseIf user.Level = 0 Then
                    MsgBox("Welcome, " + user.Username + " you've successfully signed in!")
                    Me.index = user.Id
                    FormScreenMain.AddToolStripMenuItem.Visible = False
                    FormScreenMain.btn_edit_user.Visible = False
                    FormScreenMain.btn_single_user.Visible = True
                    FormVideoList.AddToolStripMenuItem.Visible = False
                    FormScreenMain.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class