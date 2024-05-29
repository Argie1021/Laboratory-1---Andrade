
Imports System.Data.SqlClient ' Assuming you're using SQL Server
Imports MySql.Data.MySqlClient ' MySQL .NET Connector, make sure you have it installed
Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string for MySQL database
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=admin;database=inventory"

        ' SQL query to select all data from inventory table
        Dim query As String = "SELECT * FROM sample"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    Dim dataAdapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    dataAdapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable ' Bind the DataTable to the DataGridView

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form8Instance As New Form8()
        form8Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form11Instance As New Form11()
        form11Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub
End Class