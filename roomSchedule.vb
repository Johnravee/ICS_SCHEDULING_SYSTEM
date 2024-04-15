Public Class roomSchedule
    Private Sub roomSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Dim room As String = viewRooms.ClickRoomNumber
        Try

            Label1.Text = $"ROOM :{room}"
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE RoomNumber = @roomnumber"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@roomnumber", room)


            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)


            dgvRoomSched.Columns.Clear()

            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}

            For Each day As String In daysOfWeek
                dgvRoomSched.Columns.Add(day, day)
            Next


            For Each row As DataRow In data.Rows
                Dim day As String = row("Day").ToString().Trim()
                Dim section As String = row("Section").ToString().Trim()
                Dim instructor As String = row("InstructorName").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()

                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)


                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(section) Then

                    Dim rowIndex As Integer = dgvRoomSched.Rows.Add()

                    Dim CellValue As String = $"Section: {section}" & vbCrLf & $"Instructor: {instructor}" & vbCrLf & $"Subject: {Subject}"


                    dgvRoomSched.Rows(rowIndex).Cells(columnIndex).Value = CellValue
                    dgvRoomSched.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Green
                End If
            Next

            ' Set DataGridView properties
            dgvRoomSched.AllowUserToAddRows = False
            dgvRoomSched.ReadOnly = True

            dgvRoomSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvRoomSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvRoomSched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvRoomSched.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvRoomSched.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRoomSched.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click

        Me.Close()
        viewRooms.Show()
    End Sub
End Class