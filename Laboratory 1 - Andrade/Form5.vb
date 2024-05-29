Imports System.Data.SqlClient ' Assuming you're using SQL Server
Imports MySql.Data.MySqlClient ' MySQL .NET Connector, make sure you have it installed

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    DataGridView2.DataSource = dataTable
                    DataGridView3.DataSource = dataTable

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4Instance As New Form4()
        form4Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form6Instance As New Form6()
        form6Instance.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub
End Class