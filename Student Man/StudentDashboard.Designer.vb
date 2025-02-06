<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.btnViewCourses = New System.Windows.Forms.Button()
        Me.btnViewAttendance = New System.Windows.Forms.Button()
        Me.btnViewResults = New System.Windows.Forms.Button()
        Me.btnPayFees = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 35)
        Me.Label1.TabIndex = 0
        '
        'btnViewProfile
        '
        Me.btnViewProfile.Location = New System.Drawing.Point(12, 230)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(87, 23)
        Me.btnViewProfile.TabIndex = 1
        Me.btnViewProfile.Text = "ViewProfile"
        Me.btnViewProfile.UseVisualStyleBackColor = True
        '
        'btnViewCourses
        '
        Me.btnViewCourses.Location = New System.Drawing.Point(152, 230)
        Me.btnViewCourses.Name = "btnViewCourses"
        Me.btnViewCourses.Size = New System.Drawing.Size(93, 23)
        Me.btnViewCourses.TabIndex = 2
        Me.btnViewCourses.Text = "ViewCourses"
        Me.btnViewCourses.UseVisualStyleBackColor = True
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.Location = New System.Drawing.Point(325, 230)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.Size = New System.Drawing.Size(113, 23)
        Me.btnViewAttendance.TabIndex = 3
        Me.btnViewAttendance.Text = "ViewAttendance"
        Me.btnViewAttendance.UseVisualStyleBackColor = True
        '
        'btnViewResults
        '
        Me.btnViewResults.Location = New System.Drawing.Point(494, 230)
        Me.btnViewResults.Name = "btnViewResults"
        Me.btnViewResults.Size = New System.Drawing.Size(95, 23)
        Me.btnViewResults.TabIndex = 4
        Me.btnViewResults.Text = "ViewResults"
        Me.btnViewResults.UseVisualStyleBackColor = True
        '
        'btnPayFees
        '
        Me.btnPayFees.Location = New System.Drawing.Point(670, 230)
        Me.btnPayFees.Name = "btnPayFees"
        Me.btnPayFees.Size = New System.Drawing.Size(75, 23)
        Me.btnPayFees.TabIndex = 5
        Me.btnPayFees.Text = "PayFees"
        Me.btnPayFees.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(338, 369)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 40)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "WELCOME STUDENT"
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnPayFees)
        Me.Controls.Add(Me.btnViewResults)
        Me.Controls.Add(Me.btnViewAttendance)
        Me.Controls.Add(Me.btnViewCourses)
        Me.Controls.Add(Me.btnViewProfile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentDashboard"
        Me.Text = "StudentDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents btnViewCourses As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents btnViewResults As Button
    Friend WithEvents btnPayFees As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
End Class
