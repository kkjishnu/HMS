Imports MySql.Data.MySqlClient
Imports HMS.GlobalVariables
Public Class Occupants
    Private Sub Occupants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd1 As New MySqlCommand()
        Dim sql, sql1 As String
        Dim Adapter, adapter1 As MySqlDataAdapter
        Dim DS As New DataSet
        Dim DS1 As New DataTable
        Try
            mysqlconn.Open()
            sql = "select a.eno,  s.name, s.dept_name,s.p_name,s.mobile, a.h_name, a.room_no from allocation as a INNER JOIN students as s on a.eno=s.eno;"
            sql1 = "select h_name from hostels;"
            cmd1.CommandText = sql1
            cmd1.Connection = mysqlconn
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            adapter1 = New MySqlDataAdapter(cmd1)
            adapter1.Fill(DS1)

            Hos_select.Items.Clear()
            For i = 0 To DS1.Rows.Count - 1
                Hos_select.Items.Add(DS1.Rows(i).Item(0).ToString)
            Next


            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "alloc")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "alloc"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        UI.Show()
        Me.Close()
    End Sub

    Private Sub Hos_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hos_select.SelectedIndexChanged
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd1 As New MySqlCommand()
        Dim sql, sql1 As String
        Dim Adapter, adapter1 As MySqlDataAdapter
        Dim DS As New DataSet
        Dim DS1 As New DataTable
        Try
            mysqlconn.Open()

            sql = "select a.eno,  s.name, s.dept_name,s.p_name,s.mobile, a.h_name, a.room_no from allocation as a INNER JOIN students as s on a.eno=s.eno where h_name = '" & Hos_select.SelectedItem & "';"
            sql1 = "select room_no from rooms where h_name = '" & Hos_select.SelectedItem & "';"
            cmd1.CommandText = sql1
            cmd1.Connection = mysqlconn
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            adapter1 = New MySqlDataAdapter(cmd1)
            adapter1.Fill(DS1)

            room_no_select.Items.Clear()
            For i = 0 To DS1.Rows.Count - 1
                room_no_select.Items.Add(DS1.Rows(i).Item(0).ToString)
            Next


            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "alloc")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "alloc"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub room_no_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles room_no_select.SelectedIndexChanged
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Dim Adapter As MySqlDataAdapter
        Dim DS As New DataSet
        Try
            mysqlconn.Open()
            sql = "select a.eno,  s.name, s.dept_name,s.p_name,s.mobile, a.h_name, a.room_no from allocation as a INNER JOIN students as s on a.eno=s.eno where h_name = '" & Hos_select.SelectedItem & "'and room_no = '" & room_no_select.SelectedItem & "' ;"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            Adapter = New MySqlDataAdapter(cmd)
            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "alloc")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "alloc"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub
End Class