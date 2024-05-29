Public Class Form2
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim form1Instance As New Form1()
        form1Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim form3Instance As New Form3()
        form3Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form31Instance As New Form31()
        form31Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form32Instance As New Form32()
        form32Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
