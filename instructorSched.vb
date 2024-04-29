Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class instructorSched
    Private Sub instructorSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Dim instructor As String = viewInstructors.Instructor
        Try

            Label1.Text = $"Instructor :{instructor}"
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE InstructorName = @instructor"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@instructor", instructor)


            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)


            dgvInstructorSched.Columns.Clear()

            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}

            For Each day As String In daysOfWeek
                dgvInstructorSched.Columns.Add(day, day)
            Next


            For Each row As DataRow In data.Rows
                Dim day As String = row("Day").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()
                Dim roomNumber As String = row("RoomNumber").ToString().Trim()

                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)


                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(instructor) Then

                    Dim rowIndex As Integer = dgvInstructorSched.Rows.Add()

                    Dim CellValue As String = $"Day: {day}" & vbCrLf & $"Room: {roomNumber}" & vbCrLf & $"Subject: {Subject}"


                    dgvInstructorSched.Rows(rowIndex).Cells(columnIndex).Value = CellValue
                    dgvInstructorSched.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Green
                End If
            Next

            ' Set DataGridView properties
            dgvInstructorSched.AllowUserToAddRows = False
            dgvInstructorSched.ReadOnly = True

            dgvInstructorSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvInstructorSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvInstructorSched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvInstructorSched.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvInstructorSched.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvInstructorSched.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        viewInstructors.Show()
    End Sub


    Private Sub dgvInstructorSched_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstructorSched.CellContentClick

    End Sub
End Class