Imports System.Data.SqlClient

Public Class StudentProfileForm
    Dim connectionString As String = "Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    Private Sub StudentProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtStudentID.ReadOnly = True
    End Sub
    ' Function to Load Student Profile
    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        ' Set StudentID
        txtStudentID.ReadOnly = True
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT * FROM Students WHERE StudentID = @StudentID"
            Using cmd As New SqlCommand(query, con)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtFullName.Text = reader("FullName").ToString()
                        dtpDateOfBirth.Value = Convert.ToDateTime(reader("DateOfBirth"))
                        cmbGender.Text = reader("Gender").ToString()
                        txtAddress.Text = reader("Address").ToString()
                        txtPhoneNumber.Text = reader("PhoneNumber").ToString()
                        txtEmail.Text = reader("Email").ToString()
                        txtCourse.Text = reader("CourseEnrolled").ToString()
                    Else
                        MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Function to Update Student Profile
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, CourseEnrolled = @Course WHERE StudentID = @StudentID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Course", txtCourse.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
    End Sub
End Class
