Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2Instance As New Form2()
        form2Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form4Instance As New Form4()
        form4Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class