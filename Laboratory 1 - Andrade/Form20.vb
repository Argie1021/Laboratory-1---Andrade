Public Class Form20
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form32Instance As New Form32()
        form32Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form21Instance As New Form21()
        form21Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class