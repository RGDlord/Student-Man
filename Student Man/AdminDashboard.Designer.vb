<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.btnManageStudents = New System.Windows.Forms.Button()
        Me.btnManageCourses = New System.Windows.Forms.Button()
        Me.btnManageAttendance = New System.Windows.Forms.Button()
        Me.btnManageExams = New System.Windows.Forms.Button()
        Me.btnManageFees = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnManageStudents
        '
        Me.btnManageStudents.Location = New System.Drawing.Point(12, 162)
        Me.btnManageStudents.Name = "btnManageStudents"
        Me.btnManageStudents.Size = New System.Drawing.Size(135, 23)
        Me.btnManageStudents.TabIndex = 0
        Me.btnManageStudents.Text = "ManageStudents"
        Me.btnManageStudents.UseVisualStyleBackColor = True
        '
        'btnManageCourses
        '
        Me.btnManageCourses.Location = New System.Drawing.Point(172, 162)
        Me.btnManageCourses.Name = "btnManageCourses"
        Me.btnManageCourses.Size = New System.Drawing.Size(108, 23)
        Me.btnManageCourses.TabIndex = 1
        Me.btnManageCourses.Text = "ManageCourses"
        Me.btnManageCourses.UseVisualStyleBackColor = True
        '
        'btnManageAttendance
        '
        Me.btnManageAttendance.Location = New System.Drawing.Point(307, 162)
        Me.btnManageAttendance.Name = "btnManageAttendance"
        Me.btnManageAttendance.Size = New System.Drawing.Size(134, 23)
        Me.btnManageAttendance.TabIndex = 2
        Me.btnManageAttendance.Text = "ManageAttendance"
        Me.btnManageAttendance.UseVisualStyleBackColor = True
        '
        'btnManageExams
        '
        Me.btnManageExams.Location = New System.Drawing.Point(471, 162)
        Me.btnManageExams.Name = "btnManageExams"
        Me.btnManageExams.Size = New System.Drawing.Size(110, 23)
        Me.btnManageExams.TabIndex = 3
        Me.btnManageExams.Text = "ManageExams"
        Me.btnManageExams.UseVisualStyleBackColor = True
        '
        'btnManageFees
        '
        Me.btnManageFees.Location = New System.Drawing.Point(613, 162)
        Me.btnManageFees.Name = "btnManageFees"
        Me.btnManageFees.Size = New System.Drawing.Size(116, 23)
        Me.btnManageFees.TabIndex = 4
        Me.btnManageFees.Text = "ManageFees"
        Me.btnManageFees.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(307, 305)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(97, 49)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WELCOME ADMIN"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnManageFees)
        Me.Controls.Add(Me.btnManageExams)
        Me.Controls.Add(Me.btnManageAttendance)
        Me.Controls.Add(Me.btnManageCourses)
        Me.Controls.Add(Me.btnManageStudents)
        Me.Name = "AdminDashboard"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnManageCourses As Button
    Friend WithEvents btnManageAttendance As Button
    Friend WithEvents btnManageExams As Button
    Friend WithEvents btnManageFees As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
