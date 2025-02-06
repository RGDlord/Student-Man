Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection("Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"

        Try
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim userType As String = reader("UserType").ToString()

                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Redirect based on User Type
                If userType = "Admin" Then
                    Dim adminDashboard As New AdminDashboard()
                    adminDashboard.Show()
                ElseIf userType = "Student" Then
                    Dim studentDashboard As New StudentDashboard()
                    studentDashboard.Show()
                Else
                    MessageBox.Show("Invalid User Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Me.Hide() ' Hide the login form
            Else
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registerForm As New RegisterForm()
        registerForm.Show()
        Me.Hide()
    End Sub
End Class
