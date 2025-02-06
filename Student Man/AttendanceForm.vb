Imports System.Data.SqlClient

Public Class AttendanceForm
    Dim connectionString As String = "Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    ' Load Attendance Records into DataGridView
    Private Sub LoadAttendance()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM AttendanceRecords"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvAttendance.DataSource = dt
        End Using
    End Sub

    ' Fill Student Name Based on Selected Student ID
    Private Sub cmbStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentID.SelectedIndexChanged
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT FullName FROM StudentRecords WHERE StudentID=@StudentID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.Text)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtStudentName.Text = reader("FullName").ToString()
                End If
            End Using
        End Using
    End Sub

    ' Add Attendance
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO AttendanceRecords (StudentID, StudentName, AttendanceDate, Status, Remarks) 
                                   VALUES (@StudentID, @StudentName, @AttendanceDate, @Status, @Remarks)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@AttendanceDate", dtpAttendanceDate.Value)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Attendance Marked Successfully!")
                LoadAttendance()
            End Using
        End Using
    End Sub

    ' Update Attendance
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAttendanceID.Text = "" Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE AttendanceRecords SET StudentID=@StudentID, StudentName=@StudentName, AttendanceDate=@AttendanceDate, 
                                   Status=@Status, Remarks=@Remarks WHERE AttendanceID=@AttendanceID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@AttendanceID", txtAttendanceID.Text)
                cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@AttendanceDate", dtpAttendanceDate.Value)
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Attendance Updated Successfully!")
                LoadAttendance()
            End Using
        End Using
    End Sub

    ' Delete Attendance Record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAttendanceID.Text = "" Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "DELETE FROM AttendanceRecords WHERE AttendanceID=@AttendanceID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@AttendanceID", txtAttendanceID.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Attendance Deleted Successfully!")
                    LoadAttendance()
                End Using
            End Using
        End If
    End Sub

    ' Populate Fields When Selecting an Attendance Record from DataGridView
    Private Sub dgvAttendance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAttendance.Rows(e.RowIndex)
            txtAttendanceID.Text = row.Cells("AttendanceID").Value.ToString()
            cmbStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtStudentName.Text = row.Cells("StudentName").Value.ToString()
            dtpAttendanceDate.Value = Convert.ToDateTime(row.Cells("AttendanceDate").Value)
            cmbStatus.Text = row.Cells("Status").Value.ToString()
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub

    ' Load Student IDs into ComboBox
    Private Sub LoadStudentIDs()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT StudentID FROM StudentRecords"
            Using cmd As New SqlCommand(query, con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbStudentID.Items.Add(reader("StudentID").ToString())
                End While
            End Using
        End Using
    End Sub

    ' Form Load - Populate DataGridView and ComboBox
    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendance()
        LoadStudentIDs()
    End Sub

    Private Sub txtAttendanceID_TextChanged(sender As Object, e As EventArgs) Handles txtAttendanceID.TextChanged

    End Sub
End Class
