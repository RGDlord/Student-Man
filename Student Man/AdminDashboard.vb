Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
        Dim studentForm As New StudentForm()
        studentForm.Show()
    End Sub

    Private Sub btnManageCourses_Click(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Dim courseForm As New CourseForm()
        courseForm.Show()
    End Sub

    Private Sub btnManageAttendance_Click(sender As Object, e As EventArgs) Handles btnManageAttendance.Click
        Dim attendanceForm As New AttendanceForm()
        attendanceForm.Show()
    End Sub

    Private Sub btnManageExams_Click(sender As Object, e As EventArgs) Handles btnManageExams.Click
        Dim examForm As New ExamForm()
        examForm.Show()
    End Sub

    Private Sub btnManageFees_Click(sender As Object, e As EventArgs) Handles btnManageFees.Click
        Dim feeForm As New FeeForm()
        feeForm.Show()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class
