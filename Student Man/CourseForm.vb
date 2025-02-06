Imports System.Data.SqlClient

Public Class CourseForm
    Dim connectionString As String = "Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    'Load Course Records into DataGridView
    Private Sub LoadCourses()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Courses"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvCourses.DataSource = dt
        End Using
    End Sub

    ' Add Course
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim courseFee As Decimal
        If Not Decimal.TryParse(txtFee.Text, courseFee) Then
            MessageBox.Show("Please enter a valid number for the course fee.")
            Return
        End If
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO Courses (CourseName, CourseDuration, CourseFee, Description) 
                                   VALUES (@CourseName, @CourseDuration, @CourseFee, @Description)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text)
                cmd.Parameters.AddWithValue("@CourseDuration", txtDuration.Text)
                cmd.Parameters.AddWithValue("@CourseFee", txtFee.Text)
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course Added Successfully!")
                LoadCourses()
            End Using
        End Using
    End Sub

    ' Update Course
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCourseID.Text = "" Then
            MessageBox.Show("Please select a course to update.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE Courses SET CourseName=@CourseName, CourseDuration=@CourseDuration, 
                                   CourseFee=@CourseFee, Description=@Description WHERE CourseID=@CourseID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
                cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text)
                cmd.Parameters.AddWithValue("@CourseDuration", txtDuration.Text)
                cmd.Parameters.AddWithValue("@CourseFee", txtFee.Text)
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Course Updated Successfully!")
                LoadCourses()
            End Using
        End Using
    End Sub

    ' Delete Course
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtCourseID.Text = "" Then
            MessageBox.Show("Please select a course to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "DELETE FROM Courses WHERE CourseID=@CourseID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Course Deleted Successfully!")
                    LoadCourses()
                End Using
            End Using
        End If
    End Sub

    ' Populate Fields When Selecting a Course from DataGridView
    Private Sub dgvCourses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourses.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCourses.Rows(e.RowIndex)
            txtCourseID.Text = row.Cells("CourseID").Value.ToString()
            txtCourseName.Text = row.Cells("CourseName").Value.ToString()
            txtDuration.Text = row.Cells("CourseDuration").Value.ToString()
            txtFee.Text = row.Cells("CourseFee").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    ' Form Load - Populate DataGridView
    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
    End Sub
End Class
