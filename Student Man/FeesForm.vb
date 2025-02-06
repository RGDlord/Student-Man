Imports System.Data.SqlClient

Public Class FeeForm
    Dim connectionString As String = "Data Source=ASUSTUF\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

    ' Load Fee Records into DataGridView
    Private Sub LoadFees()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Fees"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvFees.DataSource = dt
        End Using
    End Sub

    ' Load Student Details based on Student ID
    Private Sub LoadStudentDetails()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT FullName, CourseEnrolled FROM StudentRecords WHERE StudentID = @StudentID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtStudentName.Text = reader("FullName").ToString()
                    txtCourseEnrolled.Text = reader("CourseEnrolled").ToString()
                Else
                    txtStudentName.Text = ""
                    txtCourseEnrolled.Text = ""
                End If
            End Using
        End Using
    End Sub

    ' Add Fee Record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate AmountPaid input
        Dim amountPaid As Decimal
        If Not Decimal.TryParse(txtAmountPaid.Text, amountPaid) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim checkQuery As String = "SELECT COUNT(*) FROM StudentRecords WHERE StudentID = @StudentID"
            Using checkCmd As New SqlCommand(checkQuery, con)
        checkCmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        If count = 0 Then
            MessageBox.Show("Error: Student ID does not exist. Please enter a valid Student ID.", "Invalid Student", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using
            Dim query As String = "INSERT INTO Fees (StudentID, StudentName, CourseEnrolled, AmountPaid, PaymentDate, PaymentMode, Remarks) 
                                   VALUES (@StudentID, @StudentName, @CourseEnrolled, @AmountPaid, @PaymentDate, @PaymentMode, @Remarks)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", txtCourseEnrolled.Text)
                cmd.Parameters.AddWithValue("@AmountPaid", amountPaid)
                cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value)
                cmd.Parameters.AddWithValue("@PaymentMode", cmbPaymentMode.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Fee Record Added Successfully!")
                LoadFees()
            End Using
        End Using
    End Sub

    ' Update Fee Record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtFeeID.Text = "" Then
            MessageBox.Show("Please select a fee record to update.")
            Return
        End If

        ' Validate AmountPaid input
        Dim amountPaid As Decimal
        If Not Decimal.TryParse(txtAmountPaid.Text, amountPaid) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "UPDATE Fees SET StudentID=@StudentID, StudentName=@StudentName, CourseEnrolled=@CourseEnrolled, 
                                   AmountPaid=@AmountPaid, PaymentDate=@PaymentDate, PaymentMode=@PaymentMode, Remarks=@Remarks 
                                   WHERE FeeID=@FeeID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FeeID", txtFeeID.Text)
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@CourseEnrolled", txtCourseEnrolled.Text)
                cmd.Parameters.AddWithValue("@AmountPaid", amountPaid)
                cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value)
                cmd.Parameters.AddWithValue("@PaymentMode", cmbPaymentMode.Text)
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Fee Record Updated Successfully!")
                LoadFees()
            End Using
        End Using
    End Sub

    ' Delete Fee Record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtFeeID.Text = "" Then
            MessageBox.Show("Please select a fee record to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this fee record?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "DELETE FROM Fees WHERE FeeID=@FeeID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@FeeID", txtFeeID.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Fee Record Deleted Successfully!")
                    LoadFees()
                End Using
            End Using
        End If
    End Sub

    ' Populate Fields When Selecting a Fee Record from DataGridView
    Private Sub dgvFees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvFees.Rows(e.RowIndex)
            txtFeeID.Text = row.Cells("FeeID").Value.ToString()
            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtStudentName.Text = row.Cells("StudentName").Value.ToString()
            txtCourseEnrolled.Text = row.Cells("CourseEnrolled").Value.ToString()
            txtAmountPaid.Text = row.Cells("AmountPaid").Value.ToString()
            dtpPaymentDate.Value = Convert.ToDateTime(row.Cells("PaymentDate").Value)
            cmbPaymentMode.Text = row.Cells("PaymentMode").Value.ToString()
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
        End If
    End Sub

    ' Form Load - Populate DataGridView
    Private Sub FeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFees()
    End Sub

    ' Load Student Details when Student ID is changed
    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        LoadStudentDetails()
    End Sub
End Class
