Imports System.Data.SqlClient

Public Class AttendanceViewForm
    ' Connection string (Replace YOUR_SERVER with your actual server name)
    Private connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=StudentRecords;Integrated Security=True"

    Private Sub StudentAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendance()
    End Sub

    Private Sub LoadAttendance()
        Try
            ' Ensure the logged-in student ID is used


            ' Query to fetch attendance for the logged-in student
            Dim query As String = "SELECT AttendanceDate, Status, Remarks FROM Attendance WHERE StudentID = @StudentID ORDER BY AttendanceDate DESC"

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)


                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Bind data to DataGridView
                    dgvAttendance.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
