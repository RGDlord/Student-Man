<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtExamID = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtMarksObtained = New System.Windows.Forms.TextBox()
        Me.txtTotalMarks = New System.Windows.Forms.TextBox()
        Me.dtpExamDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvExams = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(302, 43)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(100, 22)
        Me.txtStudentName.TabIndex = 0
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(311, 216)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade.TabIndex = 1
        '
        'txtExamID
        '
        Me.txtExamID.Location = New System.Drawing.Point(311, 145)
        Me.txtExamID.Name = "txtExamID"
        Me.txtExamID.Size = New System.Drawing.Size(100, 22)
        Me.txtExamID.TabIndex = 2
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(311, 89)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse.TabIndex = 3
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(112, 89)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(100, 22)
        Me.txtStudentID.TabIndex = 4
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(112, 126)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(100, 22)
        Me.txtSubject.TabIndex = 5
        '
        'txtMarksObtained
        '
        Me.txtMarksObtained.Location = New System.Drawing.Point(112, 169)
        Me.txtMarksObtained.Name = "txtMarksObtained"
        Me.txtMarksObtained.Size = New System.Drawing.Size(100, 22)
        Me.txtMarksObtained.TabIndex = 6
        '
        'txtTotalMarks
        '
        Me.txtTotalMarks.Location = New System.Drawing.Point(112, 216)
        Me.txtTotalMarks.Name = "txtTotalMarks"
        Me.txtTotalMarks.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMarks.TabIndex = 7
        '
        'dtpExamDate
        '
        Me.dtpExamDate.Location = New System.Drawing.Point(177, 244)
        Me.dtpExamDate.Name = "dtpExamDate"
        Me.dtpExamDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpExamDate.TabIndex = 8
        '
        'dgvExams
        '
        Me.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExams.Location = New System.Drawing.Point(51, 272)
        Me.dgvExams.Name = "dgvExams"
        Me.dgvExams.RowHeadersWidth = 51
        Me.dgvExams.RowTemplate.Height = 24
        Me.dgvExams.Size = New System.Drawing.Size(671, 150)
        Me.dgvExams.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(519, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(632, 70)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(519, 125)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "view"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(632, 116)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 26)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "StudentID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "MarksObtained"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TotalMarks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "StudentName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Course"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ExamID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Grade"
        '
        'ExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvExams)
        Me.Controls.Add(Me.dtpExamDate)
        Me.Controls.Add(Me.txtTotalMarks)
        Me.Controls.Add(Me.txtMarksObtained)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtExamID)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtStudentName)
        Me.Name = "ExamForm"
        Me.Text = "ExamForm"
        CType(Me.dgvExams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtExamID As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtMarksObtained As TextBox
    Friend WithEvents txtTotalMarks As TextBox
    Friend WithEvents dtpExamDate As DateTimePicker
    Friend WithEvents dgvExams As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
