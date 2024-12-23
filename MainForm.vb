Imports System.Security.Cryptography
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim gender As String


    Private Sub btn_signout_Click(sender As Object, e As EventArgs) Handles btn_signout.Click
        LogInForm.Show()
        Hide()
        Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO Account (EiD, Name, Surname, Age, Gender, DOB) VALUES(@EiD, @Name, @Surname, @Age, @Gender, @DOB)"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@EiD", txtbox_eid.Text)
            COMMAND.Parameters.AddWithValue("@Name", txtbox_name.Text)
            COMMAND.Parameters.AddWithValue("@Surname", txtbox_sname.Text)
            COMMAND.Parameters.AddWithValue("@Age", txtbox_age.Text)
            COMMAND.Parameters.AddWithValue("@Gender", gender)
            COMMAND.Parameters.AddWithValue("@DOB", DateTimePicker1.Value.ToString("yyyy-MM-dd"))

            READER = COMMAND.ExecuteReader
            MessageBox.Show("Saved!", "SAVE")
            txtbox_eid.Clear()
            txtbox_name.Clear()
            txtbox_sname.Clear()
            txtbox_age.Clear()
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE Account SET Eid = @Eid, Name = @Name, Surname = @Surname, Age = @Age, Gender = @Gender, DOB = @DOB WHERE Eid = @Eid"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@Eid", txtbox_eid.Text)
            COMMAND.Parameters.AddWithValue("@Name", txtbox_name.Text)
            COMMAND.Parameters.AddWithValue("@Surname", txtbox_sname.Text)
            COMMAND.Parameters.AddWithValue("@Age", txtbox_age.Text)
            COMMAND.Parameters.AddWithValue("@Gender", gender)
            COMMAND.Parameters.AddWithValue("@DOB", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Updated!", "UPDATE")
            txtbox_eid.Clear()
            txtbox_name.Clear()
            txtbox_sname.Clear()
            txtbox_age.Clear()
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM Account WHERE Eid = '" & txtbox_eid.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Deleted!", "DELETE")
            txtbox_eid.Clear()
            txtbox_name.Clear()
            txtbox_sname.Clear()
            txtbox_age.Clear()
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub load_table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            Dim Query As String
            Query = "SELECT Eid as 'Employee ID', Name as 'First Name', Surname as 'Last Name', Age as 'Age', gender as 'Gender', " & "IFNULL(DOB, '1900-01-01') as 'Date of Birth' FROM Account"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            dbDataSet.Clear()
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Account"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("Name")
                cmb_name.Items.Add(sName)
                lbox_name.Items.Add(sName)
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cmb_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_name.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Account WHERE Name = '" & cmb_name.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtbox_eid.Text = READER.GetInt32("Eid")
                txtbox_name.Text = READER.GetString("Name")
                txtbox_sname.Text = READER.GetString("Surname")
                txtbox_age.Text = READER.GetInt32("Age")
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub lbox_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbox_name.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM Account WHERE Name = '" & lbox_name.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtbox_eid.Text = READER.GetInt32("Eid")
                txtbox_name.Text = READER.GetString("Name")
                txtbox_sname.Text = READER.GetString("Surname")
                txtbox_age.Text = READER.GetInt32("Age")
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_loadtable_Click(sender As Object, e As EventArgs) Handles btn_loadtable.Click
        load_table()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)

            txtbox_eid.Text = If(row.Cells("Employee ID").Value IsNot Nothing, row.Cells("Employee ID").Value.ToString, "")
            txtbox_name.Text = If(row.Cells("First Name").Value IsNot Nothing, row.Cells("First Name").Value.ToString, "")
            txtbox_sname.Text = If(row.Cells("Last Name").Value IsNot Nothing, row.Cells("Last Name").Value.ToString, "")
            txtbox_age.Text = If(row.Cells("Age").Value IsNot Nothing, row.Cells("Age").Value.ToString, "")
        End If
    End Sub

    Private Sub txtbox_searchname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_searchname.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("[First Name] LIKE '*{0}*'", txtbox_searchname.Text.Replace("'", "''"))
        DataGridView1.DataSource = DV
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub btn_loadchart_Click(sender As Object, e As EventArgs) Handles btn_loadchart.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT name, age FROM Account"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim READER As MySqlDataReader = COMMAND.ExecuteReader


            While READER.Read
                Chart1.Series("NAME_VS_AGE").Points.AddXY(READER.GetString("name"), READER.GetInt32("age"))
            End While


            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class