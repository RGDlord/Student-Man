Imports System.Data.SqlClient

Public Class AdminDashboard
    Public Username As String ' Stores logged-in user

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Dim studentForm As New StudentDashboard()
        studentForm.Show()
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        Dim courseForm As New CourseForm()
        courseForm.Show()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim attendanceForm As New AttendanceForm()
        attendanceForm.Show()
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim resultForm As New ResultForm()
        resultForm.Show()
    End Sub

    Private Sub btnFees_Click(sender As Object, e As EventArgs) Handles btnFees.Click
        Dim feesForm As New FeesForm()
        feesForm.Show()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class