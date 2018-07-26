<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI))
        Me.Hostel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Wardens = New System.Windows.Forms.Button()
        Me.Student_Details = New System.Windows.Forms.Button()
        Me.Allocation = New System.Windows.Forms.Button()
        Me.Hostel_occupants = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hostel
        '
        Me.Hostel.Location = New System.Drawing.Point(186, 2)
        Me.Hostel.Name = "Hostel"
        Me.Hostel.Size = New System.Drawing.Size(219, 48)
        Me.Hostel.TabIndex = 0
        Me.Hostel.Text = "Hostels"
        Me.Hostel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 200)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(349, 235)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(75, 23)
        Me.Logout.TabIndex = 2
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Wardens
        '
        Me.Wardens.Location = New System.Drawing.Point(186, 107)
        Me.Wardens.Name = "Wardens"
        Me.Wardens.Size = New System.Drawing.Size(219, 45)
        Me.Wardens.TabIndex = 3
        Me.Wardens.Text = "Wardens"
        Me.Wardens.UseVisualStyleBackColor = True
        '
        'Student_Details
        '
        Me.Student_Details.Location = New System.Drawing.Point(186, 56)
        Me.Student_Details.Name = "Student_Details"
        Me.Student_Details.Size = New System.Drawing.Size(219, 45)
        Me.Student_Details.TabIndex = 4
        Me.Student_Details.Text = "Student Details"
        Me.Student_Details.UseVisualStyleBackColor = True
        '
        'Allocation
        '
        Me.Allocation.Location = New System.Drawing.Point(186, 158)
        Me.Allocation.Name = "Allocation"
        Me.Allocation.Size = New System.Drawing.Size(219, 40)
        Me.Allocation.TabIndex = 5
        Me.Allocation.Text = "Allocate"
        Me.Allocation.UseVisualStyleBackColor = True
        '
        'Hostel_occupants
        '
        Me.Hostel_occupants.Location = New System.Drawing.Point(186, 204)
        Me.Hostel_occupants.Name = "Hostel_occupants"
        Me.Hostel_occupants.Size = New System.Drawing.Size(135, 40)
        Me.Hostel_occupants.TabIndex = 6
        Me.Hostel_occupants.Text = "Hostel Occupants"
        Me.Hostel_occupants.UseVisualStyleBackColor = True
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 259)
        Me.Controls.Add(Me.Hostel_occupants)
        Me.Controls.Add(Me.Allocation)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Student_Details)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Hostel)
        Me.Controls.Add(Me.Wardens)
        Me.Name = "UI"
        Me.Text = "Hostel Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Hostel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Logout As Button
    Friend WithEvents Wardens As Button
    Friend WithEvents Student_Details As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Allocation As Button
    Friend WithEvents Hostel_occupants As Button
End Class
