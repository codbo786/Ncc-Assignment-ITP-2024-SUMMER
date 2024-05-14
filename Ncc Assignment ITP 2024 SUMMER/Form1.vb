Public Class Form1
    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        FrmSort.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        FrmSearch.Show()
        Me.Hide()
    End Sub
End Class
