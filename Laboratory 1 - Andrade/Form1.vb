Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2Instance As New Form2()
        form2Instance.Show()
        Me.Hide() ' Hide Form1 instead of closing it
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the form is being closed by the user
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True ' Cancel the default closing behavior
            Me.Hide() ' Hide Form1 instead of closing it
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class