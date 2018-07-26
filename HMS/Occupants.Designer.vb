<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Occupants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Back = New System.Windows.Forms.Button()
        Me.Hos_select = New System.Windows.Forms.ComboBox()
        Me.room_no_select = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(601, 224)
        Me.DataGridView1.TabIndex = 0
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(282, 311)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Hos_select
        '
        Me.Hos_select.FormattingEnabled = True
        Me.Hos_select.Location = New System.Drawing.Point(99, 36)
        Me.Hos_select.Name = "Hos_select"
        Me.Hos_select.Size = New System.Drawing.Size(121, 21)
        Me.Hos_select.TabIndex = 2
        Me.Hos_select.Text = "--Select Hostel--"
        '
        'room_no_select
        '
        Me.room_no_select.FormattingEnabled = True
        Me.room_no_select.Location = New System.Drawing.Point(385, 35)
        Me.room_no_select.Name = "room_no_select"
        Me.room_no_select.Size = New System.Drawing.Size(121, 21)
        Me.room_no_select.TabIndex = 4
        Me.room_no_select.Text = "--Select Rooms--"
        '
        'Occupants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 342)
        Me.Controls.Add(Me.room_no_select)
        Me.Controls.Add(Me.Hos_select)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Occupants"
        Me.Text = "Occupants"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Back As Button
    Friend WithEvents Hos_select As ComboBox
    Friend WithEvents room_no_select As ComboBox
End Class
