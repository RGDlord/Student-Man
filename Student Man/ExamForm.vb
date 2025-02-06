Imports System.Data.SqlClient

Public Class ExamForm
    Dim connectionString As String = "Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultisubnetFailover=False"

    ' Function to Auto-Calculate Grade
    Private Function CalculateGrade(marksObtained As Integer, totalMarks As Integer) As String
        Dim percentage As Double = (marksObtained / totalMarks) * 100
        Select Case percentage
            Case >= 90
                Return "A"
            Case >= 80
                Return "B"
            Case >= 70
                Return "C"
            Case >= 60
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function

    ' Function to Add Exam Record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStudentID.Text = "" Or txtSubject.Text = "" Or txtMarksObtained.Text = "" Or txtTotalMarks.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Check if StudentID exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM StudentRecords WHERE StudentID = @StudentID"
            Using checkCmd As New SqlCommand(checkQuery, con)
                checkCmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count = 0 Then
                    MessageBox.Show("Error: Student ID does not exist.", "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' Insert Exam Record
            Dim query As String = "INSERT INTO Exams (StudentID, StudentName, CourseEnrolled, Subject, ExamDate, MarksObtained, TotalMarks, Grade) 
                                   VALUES (@StudentID, @StudentName, @CourseEnrolled, @Subject, @ExamDate, @MarksObtained, @TotalMarks, @Grade)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", txtCourse.Text)
                cmd.Parameters.AddWithValue("@Subject", txtSubject.Text)
                cmd.Parameters.AddWithValue("@ExamDate", dtpExamDate.Value)
                cmd.Parameters.AddWithValue("@MarksObtained", Convert.ToInt32(txtMarksObtained.Text))
                cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text))
                cmd.Parameters.AddWithValue("@Grade", CalculateGrade(Convert.ToInt32(txtMarksObtained.Text), Convert.ToInt32(txtTotalMarks.Text)))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Exam Record Added Successfully!")
                LoadExamRecords()
            End Using
        End Using
    End Sub

    ' Function to View Exam Records
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        LoadExamRecords()
    End Sub

    Private Sub LoadExamRecords()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT * FROM Exams"
            Using da As New SqlDataAdapter(query, con)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvExams.DataSource = dt
            End Using
        End Using
    End Sub

    ' Function to Update Exam Record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtExamID.Text = "" Then
            MessageBox.Show("Please select a record to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE Exams SET StudentID = @StudentID, StudentName = @StudentName, CourseEnrolled = @CourseEnrolled, Subject = @Subject, ExamDate = @ExamDate, MarksObtained = @MarksObtained, TotalMarks = @TotalMarks, Grade = @Grade WHERE ExamID = @ExamID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ExamID", txtExamID.Text)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", txtCourse.Text)
                cmd.Parameters.AddWithValue("@Subject", txtSubject.Text)
                cmd.Parameters.AddWithValue("@ExamDate", dtpExamDate.Value)
                cmd.Parameters.AddWithValue("@MarksObtained", Convert.ToInt32(txtMarksObtained.Text))
                cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text))
                cmd.Parameters.AddWithValue("@Grade", CalculateGrade(Convert.ToInt32(txtMarksObtained.Text), Convert.ToInt32(txtTotalMarks.Text)))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Exam Record Updated Successfully!")
                LoadExamRecords()
            End Using
        End Using
    End Sub

    ' Function to Delete Exam Record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtExamID.Text = "" Then
            MessageBox.Show("Please select a record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "DELETE FROM Exams WHERE ExamID = @ExamID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ExamID", txtExamID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Exam Record Deleted Successfully!")
                LoadExamRecords()
            End Using
        End Using
    End Sub

    ' Function to Load Data from DataGridView to TextBoxes
    Private Sub dgvExams_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExams.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvExams.Rows(e.RowIndex)
            txtExamID.Text = row.Cells("ExamID").Value.ToString()
            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtStudentName.Text = row.Cells("StudentName").Value.ToString()
            txtCourse.Text = row.Cells("CourseEnrolled").Value.ToString()
            txtSubject.Text = row.Cells("Subject").Value.ToString()
            dtpExamDate.Value = Convert.ToDateTime(row.Cells("ExamDate").Value)
            txtMarksObtained.Text = row.Cells("MarksObtained").Value.ToString()
            txtTotalMarks.Text = row.Cells("TotalMarks").Value.ToString()
            txtGrade.Text = row.Cells("Grade").Value.ToString()
        End If
    End Sub
End Class
