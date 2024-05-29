Public Class Form23
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form31Instance As New Form31()
        form31Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form24Instance As New Form24()
        form24Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class