Public Class FormVideoList
    Public index As Integer
    Public selectedRow As DataGridViewRow

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Close()
        FormScreenMain.Show()
    End Sub

    Private Sub Video_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager()
        db.ListMovie()
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        FormVideoInput.Show()

        FormVideoInput.DeleteToolStripMenuItem.Enabled = False

        Me.Close()
    End Sub

    'Private Sub Video_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Video_List.CellContentClick
    '    index = e.RowIndex
    'End Sub

    Private Sub Video_List_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Video_List.CellDoubleClick
        FormVideoInput.Show()

        index = e.RowIndex
        selectedRow = Video_List.Rows(index)

        FormVideoInput.Tb_Title.Text = selectedRow.Cells(1).Value.ToString
        FormVideoInput.Num_Year.Value = selectedRow.Cells(2).Value.ToString
        FormVideoInput.Num_Rating.Value = selectedRow.Cells(3).Value.ToString
        FormVideoInput.Cb_Rated.Text = selectedRow.Cells(4).Value.ToString
        FormVideoInput.Tb_duration.Text = selectedRow.Cells(5).Value.ToString

        For g As Integer = 0 To FormVideoInput.Genre_Checklist.Items.Count - 1
            Dim s = FormVideoInput.Genre_Checklist.Items(g).ToString
            Dim a = selectedRow.Cells(6).Value.ToString
            If a.Contains(s) Then
                FormVideoInput.Genre_Checklist.SetItemChecked(g, True)
            End If
        Next

        Dim n1 = selectedRow.Cells(7).Value.ToString
        Dim n2 = selectedRow.Cells(8).Value.ToString
        Dim n3 = selectedRow.Cells(9).Value.ToString
        Dim n4 = selectedRow.Cells(10).Value.ToString
        Dim n5 = selectedRow.Cells(11).Value.ToString

        FormVideoInput.Tb_Cast1.Text = n1.Substring(0, n1.IndexOf(" as"))
        FormVideoInput.Tb_as_cast1.Text = n1.Substring(n1.IndexOf(" as ") + 4)
        FormVideoInput.Tb_Cast2.Text = n2.Substring(0, n2.IndexOf(" as"))
        FormVideoInput.Tb_as_cast2.Text = n2.Substring(n2.IndexOf(" as ") + 4)
        FormVideoInput.Tb_Cast3.Text = n3.Substring(0, n3.IndexOf(" as"))
        FormVideoInput.Tb_as_cast3.Text = n3.Substring(n3.IndexOf(" as ") + 4)
        FormVideoInput.Tb_Cast4.Text = n4.Substring(0, n4.IndexOf(" as"))
        FormVideoInput.Tb_as_cast4.Text = n4.Substring(n4.IndexOf(" as ") + 4)
        FormVideoInput.Tb_Cast5.Text = n5.Substring(0, n5.IndexOf(" as"))
        FormVideoInput.Tb_as_cast5.Text = n5.Substring(n5.IndexOf(" as ") + 4)

        FormVideoInput.index = selectedRow.Cells(0).Value


        Me.Close()
    End Sub
End Class