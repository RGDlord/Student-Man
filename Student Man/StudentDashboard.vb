Public Class StudentDashboard
    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        Dim profileForm As New StudentProfileForm()
        profileForm.Show()
    End Sub

    Private Sub btnViewCourses_Click(sender As Object, e As EventArgs) Handles btnViewCourses.Click
        Dim courseForm As New CourseViewForm()
        courseForm.Show()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Dim attendanceViewForm As New AttendanceviewForm()
        attendanceViewForm.Show()
    End Sub

    Private Sub btnViewResults_Click(sender As Object, e As EventArgs) Handles btnViewResults.Click
        Dim resultForm As New ResultViewForm()
        resultForm.Show()
    End Sub

    Private Sub btnPayFees_Click(sender As Object, e As EventArgs) Handles btnPayFees.Click
        Dim paymentForm As New PaymentForm()
        paymentForm.Show()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class
