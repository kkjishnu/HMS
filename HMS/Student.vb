Imports MySql.Data.MySqlClient
Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Imports HMS.GlobalVariables
Public Class Student

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
                sql = "insert into students(eno,name,father_s_name,dob,mobile,email,address,father_s_no,gender,dept_name,p_name,sem,aadhar) values('" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "','" & DataGridView1.Rows(i).Cells(7).Value & "','" & DataGridView1.Rows(i).Cells(8).Value & "','" & DataGridView1.Rows(i).Cells(9).Value & "','" & DataGridView1.Rows(i).Cells(10).Value & "','" & DataGridView1.Rows(i).Cells(11).Value & "','" & DataGridView1.Rows(i).Cells(12).Value & "') on duplicate key update eno = values(eno) , name=values(name),father_s_name=values(father_s_name),dob=values(dob),mobile=values(mobile),email=values(email),address=values(address),father_s_no=values(father_s_no),gender=values(gender),dept_name=values(dept_name),p_name=values(p_name),sem=values(sem),aadhar=values(aadhar);'"
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

    Private Sub Allocation_Click(sender As Object, e As EventArgs) Handles Allocation.Click
        Allocate.Show()
        Me.Hide()
    End Sub

    Private Sub Show_Students_Click(sender As Object, e As EventArgs) Handles Show_Students.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd As New MySqlCommand()
        Dim sql As String
        Dim Adapter As MySqlDataAdapter
        Dim DS As New DataSet
        Try
            mysqlconn.Open()
            sql = "select * from students;"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            Adapter = New MySqlDataAdapter(cmd)
            Adapter.Fill(DS, "Students")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "Students"

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim cmd, cmd2 As New MySqlCommand()
        Dim sql, sql2 As String
        Try
            mysqlconn.Open()
            sql2 = "update rooms set stat = stat+1 where (h_name,room_no) = (select h_name,room_no from allocation where eno = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "');"
            sql = "delete from students where eno = '" & DataGridView1.SelectedRows(0).Cells(0).Value & "';"
            cmd2.CommandText = sql2
            cmd2.Connection = mysqlconn
            cmd2.ExecuteNonQuery()

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