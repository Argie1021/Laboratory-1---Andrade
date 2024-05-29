Public Class Form31
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim form2Instance As New Form2()
        form2Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form7Instance As New Form7()
        form7Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form15Instance As New Form15()
        form15Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form23Instance As New Form23()
        form23Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class