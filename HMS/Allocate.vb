Imports HMS.GlobalVariables
Imports MySql.Data.MySqlClient
Public Class Allocate
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        UI.Show()
        Me.Close()
    End Sub

    Private Sub To_allocate_Click(sender As Object, e As EventArgs) Handles To_allocate.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd1 As New MySqlCommand()
        Dim sql1, sql As String
        Dim Adapter, Adapter1 As MySqlDataAdapter
        Dim DS1, DS2 As New DataSet
        Try
            mysqlconn.Open()
            If Boys_all.Checked = True Then
                sql1 = "select eno, name from students where gender = 'M' and eno not in (select eno from allocation);"
                sql = "select h_name , room_no from rooms where stat <> 0 and h_name in (Select h_name from hostels where gender = 'M');"
            ElseIf Girls_all.Checked = True Then
                sql1 = "select eno, name from students where gender = 'F' and eno not in (select eno from allocation);"
                sql = "select h_name , room_no from rooms where stat <> 0 and h_name in (Select h_name from hostels where gender = 'F');"
            End If

            cmd1.Connection = mysqlconn
            cmd1.CommandText = sql
            cmd.Connection = mysqlconn
            cmd.CommandText = sql1

            Adapter1 = New MySqlDataAdapter(cmd1)
            Adapter1.Fill(DS2, "M")
            DataGridView2.DataSource = DS2
            DataGridView2.DataMember = "M"

            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS1, "toall")
            DataGridView1.DataSource = DS1
            DataGridView1.DataMember = "toall"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Room_allocation_Click(sender As Object, e As EventArgs) Handles Room_allocation.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd1 As New MySqlCommand()
        Dim sql, sql1 As String

        Try
            mysqlconn.Open()


            sql = "insert into allocation(eno ,h_name, room_no) values('" & DataGridView1.SelectedRows(0).Cells(0).Value & "','" & DataGridView2.SelectedRows(0).Cells(0).Value & "','" & DataGridView2.SelectedRows(0).Cells(1).Value & "');"
                sql1 = "update rooms set stat = stat-1 where h_name = '" & DataGridView2.SelectedRows(0).Cells(0).Value & "' and room_no = '" & DataGridView2.SelectedRows(0).Cells(1).Value & "';"
                cmd.Connection = mysqlconn
                cmd.CommandText = sql
                cmd1.Connection = mysqlconn
                cmd1.CommandText = sql1
                cmd1.ExecuteNonQuery()
                cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        Me.Refresh()
        Me.To_allocate.PerformClick()

    End Sub

    Private Sub Allocate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Dim Adapter As MySqlDataAdapter
        Dim DS As New DataSet
        Try
            mysqlconn.Open()
            sql = "select h_name , room_no from rooms where stat <> 0 ;"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "rooms")
            DataGridView2.DataSource = DS
            DataGridView2.DataMember = "rooms"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try

    End Sub
End Class