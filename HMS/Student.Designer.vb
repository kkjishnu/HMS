<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Insert_Update = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Allocation = New System.Windows.Forms.Button()
        Me.Show_Students = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select File to Upload"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(408, 23)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 3
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Insert_Update
        '
        Me.Insert_Update.Location = New System.Drawing.Point(37, 271)
        Me.Insert_Update.Name = "Insert_Update"
        Me.Insert_Update.Size = New System.Drawing.Size(229, 23)
        Me.Insert_Update.TabIndex = 4
        Me.Insert_Update.Text = "Insert/Update"
        Me.Insert_Update.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(396, 270)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 5
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Allocation
        '
        Me.Allocation.Location = New System.Drawing.Point(285, 269)
        Me.Allocation.Name = "Allocation"
        Me.Allocation.Size = New System.Drawing.Size(75, 23)
        Me.Allocation.TabIndex = 6
        Me.Allocation.Text = "Allocate"
        Me.Allocation.UseVisualStyleBackColor = True
        '
        'Show_Students
        '
        Me.Show_Students.Location = New System.Drawing.Point(58, 68)
        Me.Show_Students.Name = "Show_Students"
        Me.Show_Students.Size = New System.Drawing.Size(135, 23)
        Me.Show_Students.TabIndex = 7
        Me.Show_Students.Text = "View Student Details"
        Me.Show_Students.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(310, 68)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(139, 23)
        Me.Delete.TabIndex = 8
        Me.Delete.Text = "Remove Students"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 317)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Show_Students)
        Me.Controls.Add(Me.Allocation)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Insert_Update)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Student"
        Me.Text = "Student Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents Insert_Update As Button
    Friend WithEvents Back As Button
    Friend WithEvents Allocation As Button
    Friend WithEvents Show_Students As Button
    Friend WithEvents Delete As Button
End Class
