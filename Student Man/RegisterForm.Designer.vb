<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtUserType = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(30, 30)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(100, 23)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(30, 70)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 23)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblFullName
        '
        Me.lblFullName.Location = New System.Drawing.Point(30, 110)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(100, 23)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name:"
        '
        'lblUserType
        '
        Me.lblUserType.Location = New System.Drawing.Point(30, 150)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(100, 23)
        Me.lblUserType.TabIndex = 3
        Me.lblUserType.Text = "User Type:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(136, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(215, 22)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(136, 71)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(215, 22)
        Me.txtPassword.TabIndex = 5
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(136, 107)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(215, 22)
        Me.txtFullName.TabIndex = 6
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(140, 200)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(100, 30)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        '
        'txtUserType
        '
        Me.txtUserType.Location = New System.Drawing.Point(136, 147)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.Size = New System.Drawing.Size(215, 22)
        Me.txtUserType.TabIndex = 9
        '
        'RegisterForm
        '
        Me.ClientSize = New System.Drawing.Size(420, 275)
        Me.Controls.Add(Me.txtUserType)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnRegister)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblUsername As System.Windows.Forms.Label
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents lblFullName As System.Windows.Forms.Label
    Private WithEvents lblUserType As System.Windows.Forms.Label
    Private WithEvents txtUsername As System.Windows.Forms.TextBox
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtFullName As System.Windows.Forms.TextBox
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtUserType As TextBox
End Class
