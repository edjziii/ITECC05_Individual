Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class LogInForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!", "MYSQL DATABASE CONNECTION TEST")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM Account WHERE username = '" & txtbox_un.Text & "' AND password = '" & txtbox_pass.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Login successful!", "LOG IN")
                MainForm.Show()
                Me.Hide()
                txtbox_pass.Clear()
                txtbox_un.Clear()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class