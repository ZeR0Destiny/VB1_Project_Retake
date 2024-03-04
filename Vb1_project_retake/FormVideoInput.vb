Public Class FormVideoInput
    Public valid As Boolean = False
    Public index As Integer
    Public genres As String = ""
    Public s1 As String = ""
    Public s2 As String = ""
    Public s3 As String = ""
    Public s4 As String = ""
    Public s5 As String = ""

    'eraser might not be necessary because the window is closed, so everything should resetS
    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Close()
        FormVideoList.Show()
    End Sub

    Private Sub Add_Movie_Click(sender As Object, e As EventArgs) Handles Add_Movie.Click
        Dim db As New DBManager
        Dim validate As New Validation

        db.CheckTitle(Tb_Title.Text)
        If db.valid = False Then
            validate.Duration()

            If valid = True Then
                For g As Integer = 0 To Genre_Checklist.CheckedItems.Count - 1
                    genres += Genre_Checklist.CheckedItems(g) + ", "
                Next
                'valid = False

                validate.OnlyLetter()
                If valid = True Then
                    s1 = Tb_Cast1.Text + " as " + Tb_as_cast1.Text
                    s2 = Tb_Cast2.Text + " as " + Tb_as_cast2.Text
                    s3 = Tb_Cast3.Text + " as " + Tb_as_cast3.Text
                    s4 = Tb_Cast4.Text + " as " + Tb_as_cast4.Text
                    s5 = Tb_Cast5.Text + " as " + Tb_as_cast5.Text
                End If

                If valid = True Then
                    Dim m As New MovieClass(Tb_Title.Text, Num_Year.Value, Num_Rating.Value, Cb_Rated.Text, Tb_duration.Text, genres, s1, s2, s3, s4, s5)
                    db.AddMovie(m)
                End If
            End If
        End If

        GoBackToolStripMenuItem.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim db As New DBManager

        Dim a = MsgBox("Do you really want to delete this movie?", MsgBoxStyle.YesNo)

        If a = vbYes Then
            db.DeleteMovie(index)
        End If

        Me.Close()
        Me.GoBackToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Btn_update_movie_Click(sender As Object, e As EventArgs) Handles Btn_update_movie.Click
        Dim db As New DBManager

        Dim validate As New Validation

        ' db.CheckTitle(Tb_Title.Text)
        'If db.valid = False Then
        validate.Duration()

        If valid = True Then
            For g As Integer = 0 To Genre_Checklist.CheckedItems.Count - 1
                genres += Genre_Checklist.CheckedItems(g) + ", "
            Next

            validate.OnlyLetter()

            If valid = True Then
                validate.OnlyLetter2()
            End If

            If valid = True Then
                validate.OnlyLetter3()
            End If

            If valid = True Then
                validate.OnlyLetter4()
            End If

            If valid = True Then
                validate.OnlyLetter5()
            End If

            If valid = True Then
                validate.OnlyLetter6()
            End If

            If valid = True Then
                validate.OnlyLetter7()
            End If

            If valid = True Then
                validate.OnlyLetter8()
            End If

            If valid = True Then
                validate.OnlyLetter9()
            End If

            If valid = True Then
                validate.OnlyLetter10()
            End If

            If valid = True Then
                s1 = Tb_Cast1.Text + " as " + Tb_as_cast1.Text
                s2 = Tb_Cast2.Text + " as " + Tb_as_cast2.Text
                s3 = Tb_Cast3.Text + " as " + Tb_as_cast3.Text
                s4 = Tb_Cast4.Text + " as " + Tb_as_cast4.Text
                s5 = Tb_Cast5.Text + " as " + Tb_as_cast5.Text
            End If

            If valid = True Then
                Dim m As New MovieClass(Tb_Title.Text, Num_Year.Value, Num_Rating.Value, Cb_Rated.Text, Tb_duration.Text, genres, s1, s2, s3, s4, s5)
                db.UpdateMovie(m, index)
                GoBackToolStripMenuItem.PerformClick()
            End If
        End If


    End Sub
End Class