Imports System.Data.SqlClient

Public Class LoginForm
    Dim connection As New SqlConnection("Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query As String = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Use hashing for security

        connection.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login Successful!")
            ' Navigate to Dashboard
        Else
            MessageBox.Show("Invalid Username or Password.")
        End If

        connection.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterForm.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class