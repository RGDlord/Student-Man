Imports System.Data.SqlClient

Public Class StudentForm
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    ' Load Students into DataGridView
    Private Sub LoadStudents()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM StudentRecords"  ' Updated table name
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvStudents.DataSource = dt
        End Using
    End Sub

    ' Add Student
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO StudentRecords (FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, CourseEnrolled) 
                                   VALUES (@FullName, @DateOfBirth, @Gender, @Address, @PhoneNumber, @Email, @CourseEnrolled)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", cmbCourseEnrolled.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Student Added Successfully!")
                LoadStudents()
            End Using
        End Using
    End Sub

    ' Update Student
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please select a student to update.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE StudentRecords SET FullName=@FullName, DateOfBirth=@DateOfBirth, Gender=@Gender, 
                                   Address=@Address, PhoneNumber=@PhoneNumber, Email=@Email, CourseEnrolled=@CourseEnrolled 
                                   WHERE StudentID=@StudentID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", cmbCourseEnrolled.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Student Updated Successfully!")
                LoadStudents()
            End Using
        End Using
    End Sub

    ' Delete Student
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please select a student to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "DELETE FROM StudentRecords WHERE StudentID=@StudentID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student Deleted Successfully!")
                    LoadStudents()
                End Using
            End Using
        End If
    End Sub

    ' View All Students
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        LoadStudents()
    End Sub

    ' Populate fields when selecting a student from DataGridView
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtFullName.Text = row.Cells("FullName").Value.ToString()
            dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells("DateOfBirth").Value)
            cmbGender.Text = row.Cells("Gender").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtPhoneNumber.Text = row.Cells("PhoneNumber").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            cmbCourseEnrolled.Text = row.Cells("CourseEnrolled").Value.ToString()
        End If
    End Sub

    ' Form Load - Populate DataGridView   
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub
End Class
