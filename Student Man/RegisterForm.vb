Imports System.Data.SqlClient

Public Class RegisterForm
    Dim connection As New SqlConnection("Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim query As String = "INSERT INTO Users (Username, Password, FullName, UserType) VALUES (@Username, @Password, @FullName, @UserType)"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Use hashing for security
        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
        cmd.Parameters.AddWithValue("@UserType", txtUserType.Text)

        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Registration Successful!")
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class
