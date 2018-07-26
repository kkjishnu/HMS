Imports MySql.Data.MySqlClient
Imports HMS.GlobalVariables
Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim mysqlconn As New MySqlConnection()
        mysqlconn.ConnectionString = conn_string
        Dim sql As String
        Dim cmd As New MySqlCommand()
        Dim adapter As New MySqlDataAdapter()
        Dim reader As MySqlDataReader
        Try
            mysqlconn.Open()
            sql = "select DES_DECRYPT('PASSWORD','secret') as 'PASSWORD' from hms.users where USERNAME ='" + UsernameTextBox.Text + "';"
            cmd.Connection = mysqlconn
            cmd.CommandText = sql
            adapter.SelectCommand = cmd
            reader = cmd.ExecuteReader

            If reader.HasRows() Then
                UI.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Details")
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            mysqlconn.Close()
        End Try
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = System.DateTime.Now.ToLongDateString + " " + System.DateTime.Now.ToShortTimeString
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
