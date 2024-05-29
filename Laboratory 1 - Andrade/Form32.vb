Public Class Form32
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim form2Instance As New Form2()
        form2Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form12Instance As New Form12()
        form12Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form20Instance As New Form20()
        form20Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form28Instance As New Form28()
        form28Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class