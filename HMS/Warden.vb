Imports MySql.Data.MySqlClient
Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Imports HMS.GlobalVariables
Public Class Warden

    Public Sub New()
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")

        InitializeComponent()
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
                sql = "insert into warden(w_id,w_name,mobile) values('" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "') on duplicate key update w_id = values(w_id) , w_name=values(w_name),mobile=values(mobile);'"
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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        UI.Show()
        Me.Close()
    End Sub

    Private Sub Show_warden_Click(sender As Object, e As EventArgs) Handles Show_warden.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Dim Adapter As MySqlDataAdapter
        Dim DS As New DataSet
        Try
            mysqlconn.Open()
            sql = "select * from warden;"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "Warden")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "Warden"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Try
            mysqlconn.Open()
            sql = "delete from warden where w_id = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "';"
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