<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allocate
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
        Me.Back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Room_allocation = New System.Windows.Forms.Button()
        Me.Boys_all = New System.Windows.Forms.RadioButton()
        Me.Girls_all = New System.Windows.Forms.RadioButton()
        Me.To_allocate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(449, 289)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 0
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(295, 89)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 2
        '
        'Room_allocation
        '
        Me.Room_allocation.Location = New System.Drawing.Point(149, 289)
        Me.Room_allocation.Name = "Room_allocation"
        Me.Room_allocation.Size = New System.Drawing.Size(75, 23)
        Me.Room_allocation.TabIndex = 3
        Me.Room_allocation.Text = "Allocate"
        Me.Room_allocation.UseVisualStyleBackColor = True
        '
        'Boys_all
        '
        Me.Boys_all.AutoSize = True
        Me.Boys_all.Location = New System.Drawing.Point(47, 34)
        Me.Boys_all.Name = "Boys_all"
        Me.Boys_all.Size = New System.Drawing.Size(48, 17)
        Me.Boys_all.TabIndex = 4
        Me.Boys_all.TabStop = True
        Me.Boys_all.Text = "Boys"
        Me.Boys_all.UseVisualStyleBackColor = True
        '
        'Girls_all
        '
        Me.Girls_all.AutoSize = True
        Me.Girls_all.Location = New System.Drawing.Point(172, 34)
        Me.Girls_all.Name = "Girls_all"
        Me.Girls_all.Size = New System.Drawing.Size(45, 17)
        Me.Girls_all.TabIndex = 5
        Me.Girls_all.TabStop = True
        Me.Girls_all.Text = "Girls"
        Me.Girls_all.UseVisualStyleBackColor = True
        '
        'To_allocate
        '
        Me.To_allocate.Location = New System.Drawing.Point(265, 34)
        Me.To_allocate.Name = "To_allocate"
        Me.To_allocate.Size = New System.Drawing.Size(166, 23)
        Me.To_allocate.TabIndex = 6
        Me.To_allocate.Text = "Show Students to be allocated"
        Me.To_allocate.UseVisualStyleBackColor = True
        '
        'Allocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 324)
        Me.Controls.Add(Me.To_allocate)
        Me.Controls.Add(Me.Girls_all)
        Me.Controls.Add(Me.Boys_all)
        Me.Controls.Add(Me.Room_allocation)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Back)
        Me.Name = "Allocate"
        Me.Text = "Allocate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Room_allocation As Button
    Friend WithEvents Boys_all As RadioButton
    Friend WithEvents Girls_all As RadioButton
    Friend WithEvents To_allocate As Button
End Class
