Imports MySql.Data.MySqlClient
Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Imports HMS.GlobalVariables
Public Class Hostels

    Public Sub New()
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")

        InitializeComponent()
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        UI.Show()
        Me.Close()
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim openFileDialog = New OpenFileDialog()
        openFileDialog.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm"
        openFileDialog.FilterIndex = 2

        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim ef = ExcelFile.Load(openFileDialog.FileName)
            TextBox1.Text = openFileDialog.FileName

            ' Export Excel worksheet to DataGridView control.
            DataGridViewConverter.ExportToDataGridView(ef.Worksheets.ActiveWorksheet, Me.DataGridView1, New ExportToDataGridViewOptions() With {.ColumnHeaders = True})
        End If
    End Sub

    Private Sub Insert_Update_Click(sender As Object, e As EventArgs) Handles Insert_Update.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String

        Try
            mysqlconn.Open()
            For i As Integer = 0 To DataGridView1.Rows.Count
                sql = "insert into hostels(h_name,total_rooms,gender) values('" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "') on duplicate key update h_name=values(h_name),total_rooms=values(total_rooms),gender=values(gender);"
                cmd.Connection = mysqlconn
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Show_Hostel_Click(sender As Object, e As EventArgs) Handles Show_Hostel.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Dim Adapter As MySqlDataAdapter
        Dim DS As New DataSet
        Try
            mysqlconn.Open()
            sql = "select * from hostels;"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "Hostels")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "Hostels"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd1 As New MySqlCommand()
        Dim sql, sql1 As String
        Try
            mysqlconn.Open()
            sql1 = "delete from rooms where h_name = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "';"
            sql = "delete from hostels where h_name = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "';"
            cmd1.Connection = mysqlconn
            cmd1.CommandText = sql1
            cmd.ExecuteNonQuery()
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
    End Sub
End Class