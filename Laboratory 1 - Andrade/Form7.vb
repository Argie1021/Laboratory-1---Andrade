Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form31Instance As New Form31()
        form31Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form8Instance As New Form8()
        form8Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class