Imports MySql.Data.MySqlClient

Public Class SchedListForm
    Dim lamesa As New DataTable()
    Dim FormattedStartTime As DateTime
    Dim FormattedEndTime As DateTime

    Dim tempName, tempSub, tempDay, tempRoom, tempSection, tempSemester, tempStartTime, tempEndTime, tempDuration As String

    Private Sub SchedListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSection()
        GetSchedules()
        GetSubject()
        GetRoom()
        GetInstructor()

        StartTime.Format = DateTimePickerFormat.Custom
        StartTime.CustomFormat = "hh:mm tt"
        StartTime.ShowUpDown = True

        EndTime.Format = DateTimePickerFormat.Custom
        EndTime.CustomFormat = "hh:mm tt"
        EndTime.ShowUpDown = True
    End Sub

    'GetSchedules
    Private Sub GetSchedules()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT ScheduleID, InstructorName, Section, Subject, TIME_FORMAT(StartTime, '%h:%i %p') AS FormattedStart, TIME_FORMAT(EndTime, '%h:%i %p') AS FormattedEnd, Day, RoomNumber, Semester, Duration FROM schedules"
            cmd.ExecuteNonQuery()
            dataReader.Fill(lamesa)
            dgv.DataSource = lamesa

            dgv.Columns("ScheduleID").Visible = False
            dgv.Columns("InstructorName").HeaderText = "Name"
            dgv.Columns("RoomNumber").HeaderText = "Room"
            dgv.Columns("FormattedStart").HeaderText = "Start Time"
            dgv.Columns("FormattedEnd").HeaderText = "End Time"

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching schedules. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname,' ', Surname) AS FullName FROM instructor"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cbo_instructor.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cbo_instructor.Items.Add(row("FullName").ToString())
            Next
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving instructor information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Get Section
    Private Sub GetSection()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Section_Program, '-', Year, '', Section_Code) AS Section FROM sections"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cbo_sec.Items.Clear()

            For Each row As DataRow In newtable.Rows
                ' Add each section to the ComboBox
                cbo_sec.Items.Add(row("Section").ToString())
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving section information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetSubject()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(subject_description, ' (', subject_code, ')') AS Subject FROM subjects"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cbo_subject.Items.Clear()

            For Each row As DataRow In newtable.Rows
                cbo_subject.Items.Add(row("Subject").ToString())
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving subject information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetRoom()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT Room FROM rooms"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_room.Items.Clear()

            For Each row As DataRow In newtable.Rows
                cb_room.Items.Add(row("Room").ToString())
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving room information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchQuery As String = TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In lamesa.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In lamesa.Rows
                For Each column As DataColumn In lamesa.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            dgv.DataSource = filteredData
        Else
            dgv.DataSource = lamesa
        End If
    End Sub

    'Delete row
    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If String.IsNullOrEmpty(txtScheduleID.Text) Then
            MsgBox("Please select a row to delete.", MsgBoxStyle.Information, "Select Row")
            Return
        End If

        If dgv.Rows.Count = 0 Then
            MessageBox.Show("There is no data to delete.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MsgBox("Are You Sure You Want to Delete This Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                con.Open()
                Dim selectedRowIndex As Integer = dgv.CurrentCell.RowIndex
                Dim scheduleID As Integer = Convert.ToInt32(dgv.Rows(selectedRowIndex).Cells("ScheduleID").Value)
                Dim delCommand As New MySqlCommand("DELETE FROM `schedules` WHERE `ScheduleID` = @sched", con)
                delCommand.Parameters.AddWithValue("@sched", scheduleID)
                Dim rowsAffected As Integer = delCommand.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    dgv.DataSource = Nothing
                    lamesa.Rows.Clear()
                    lamesa.Columns.Clear()
                    GetSchedules()
                    CreateScheduleForm.ResetForm()
                    MessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    dgv.DataSource = Nothing
                    lamesa.Rows.Clear()
                    lamesa.Columns.Clear()
                    GetSchedules()
                    MessageBox.Show("Deletion Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                con.Close()
            End Try

            dgv.Refresh()
        End If
    End Sub

    Private Sub upd_Click(sender As Object, e As EventArgs) Handles upd.Click
        If String.IsNullOrWhiteSpace(txtScheduleID.Text) OrElse
        cbo_instructor.SelectedItem Is Nothing OrElse
        cbo_sec.SelectedItem Is Nothing OrElse
        cbo_subject.SelectedItem Is Nothing OrElse
        cbo_day.SelectedItem Is Nothing OrElse
        cb_room.SelectedItem Is Nothing OrElse
        cb_semester.SelectedItem Is Nothing OrElse
        StartTime.Value = EndTime.Value Then
            MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected schedule ID
        Dim scheduleID As Integer = Convert.ToInt32(txtScheduleID.Text)

        ' Check if start time and end time are the same
        If StartTime.Value = EndTime.Value Then
            MessageBox.Show("The start time and end time cannot be the same. Please adjust the schedule accordingly.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate duration
        Dim duration As TimeSpan = EndTime.Value.Subtract(StartTime.Value)
        Dim durationStr As String = duration.ToString("hh\:mm\:ss")

        Try
            DBCon()
            cmd.Connection = con

            ' SQL query to check for schedule conflicts
            Dim conflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE Day = @Day AND RoomNumber = @RoomNumber AND StartTime < @EndTime AND EndTime > @StartTime AND ScheduleID <> @ScheduleID"
            cmd.CommandText = conflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", EndTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim conflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If conflictCount > 0 Then
                MessageBox.Show("There is a conflict with the existing schedule. Please choose a different time or room.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL query to check if the same subject is scheduled on the same day for the same section
            Dim subjectConflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE Section = @Section AND Subject = @Subject AND Day = @Day AND ScheduleID <> @ScheduleID"
            cmd.CommandText = subjectConflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Section", cbo_sec.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Subject", cbo_subject.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim subjectConflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If subjectConflictCount > 0 Then
                MessageBox.Show("The same subject cannot be scheduled twice in one day for the same section. Please choose a different subject or day.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If duration.Hours <= 0 Or duration.Hours > 8 Then
                MessageBox.Show("Class time duration exceeds 8 hours. Please consider adjusting the schedule.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            ' SQL query to check for instructor conflicts
            Dim instructorConflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE InstructorName = @InstructorName AND Day = @Day AND StartTime < @EndTime AND EndTime > @StartTime AND ScheduleID <> @ScheduleID"
            cmd.CommandText = instructorConflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cbo_instructor.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", EndTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim instructorConflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If instructorConflictCount > 0 Then
                MessageBox.Show("The instructor cannot teach two sections at the same time on the same day. Please choose a different time or instructor.", "Instructor Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL query to update the schedule
            cmd.CommandText = "UPDATE schedules SET InstructorName = @InstructorName, Section = @Section, Subject = @Subject, StartTime = @StartTime, EndTime = @EndTime, Day = @Day, RoomNumber = @RoomNumber, Semester = @Semester, Duration = @Duration WHERE ScheduleID = @ScheduleID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cbo_instructor.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Section", cbo_sec.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Subject", cbo_subject.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", EndTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Semester", cb_semester.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Duration", durationStr)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                dgv.DataSource = Nothing
                lamesa.Rows.Clear()
                lamesa.Columns.Clear()
                GetSchedules()
                MessageBox.Show("Schedule Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm() ' Call ResetForm after successful update
            Else
                MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try

        dgv.Refresh()
    End Sub





    Private selectedRow As DataGridViewRow

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            selectedRow = dgv.Rows(e.RowIndex)

            If selectedRow IsNot Nothing Then
                If selectedRow.Cells("ScheduleID").Value IsNot Nothing Then
                    txtScheduleID.Text = selectedRow.Cells("ScheduleID").Value.ToString()
                End If

                If selectedRow.Cells("InstructorName").Value IsNot Nothing Then
                    cbo_instructor.SelectedItem = selectedRow.Cells("InstructorName").Value.ToString()
                End If

                If selectedRow.Cells("Section").Value IsNot Nothing Then
                    cbo_sec.SelectedItem = selectedRow.Cells("Section").Value.ToString()
                End If

                If selectedRow.Cells("Subject").Value IsNot Nothing Then
                    cbo_subject.SelectedItem = selectedRow.Cells("Subject").Value.ToString()
                End If

                If selectedRow.Cells("Day").Value IsNot Nothing Then
                    cbo_day.SelectedItem = selectedRow.Cells("Day").Value.ToString()
                End If

                If selectedRow.Cells("RoomNumber").Value IsNot Nothing Then
                    cb_room.SelectedItem = selectedRow.Cells("RoomNumber").Value.ToString()
                End If

                If selectedRow.Cells("Semester").Value IsNot Nothing Then
                    cb_semester.SelectedItem = selectedRow.Cells("Semester").Value.ToString()
                End If

                If selectedRow.Cells("FormattedStart").Value IsNot Nothing Then
                    StartTime.Value = DateTime.Parse(selectedRow.Cells("FormattedStart").Value.ToString())
                End If

                If selectedRow.Cells("FormattedEnd").Value IsNot Nothing Then
                    EndTime.Value = DateTime.Parse(selectedRow.Cells("FormattedEnd").Value.ToString())
                End If

                ' Store selected row data in temporary variables, ensuring they are not null before assignment
                tempName = If(cbo_instructor.SelectedItem?.ToString(), String.Empty)
                tempSub = If(cbo_subject.SelectedItem?.ToString(), String.Empty)
                tempDay = If(cbo_day.SelectedItem?.ToString(), String.Empty)
                tempRoom = If(cb_room.SelectedItem?.ToString(), String.Empty)
                tempSection = If(cbo_sec.SelectedItem?.ToString(), String.Empty)
                tempSemester = If(cb_semester.SelectedItem?.ToString(), String.Empty)
                tempStartTime = If(StartTime.Value.TimeOfDay.ToString(), String.Empty)
                tempEndTime = If(EndTime.Value.TimeOfDay.ToString(), String.Empty)
                tempDuration = If(selectedRow.Cells("Duration")?.Value.ToString(), String.Empty)
            End If
        End If
    End Sub



    Private Sub InsertScheduleOld()
        Try
            DBCon()
            cmd.Connection = con

            ' SQL query to check for instructor conflicts
            Dim instructorConflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE InstructorName = @InstructorName AND Day = @Day AND StartTime < @EndTime AND EndTime > @StartTime"
            cmd.CommandText = instructorConflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", tempName)
            cmd.Parameters.AddWithValue("@Day", tempDay)
            cmd.Parameters.AddWithValue("@StartTime", TimeSpan.Parse(tempStartTime))
            cmd.Parameters.AddWithValue("@EndTime", TimeSpan.Parse(tempEndTime))

            Dim instructorConflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If instructorConflictCount > 0 Then
                MessageBox.Show("The instructor cannot teach two or more sections at the same time on the same day. Please choose a different time or instructor.", "Instructor Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            cmd.CommandText = "INSERT INTO schedules (InstructorName, Section, Subject, StartTime, EndTime, Day, RoomNumber, Semester, Duration) VALUES (@InstructorName, @Section, @Subject, @StartTime, @EndTime, @Day, @RoomNumber, @Semester, @Duration)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", tempName)
            cmd.Parameters.AddWithValue("@Section", tempSection)
            cmd.Parameters.AddWithValue("@Subject", tempSub)
            cmd.Parameters.AddWithValue("@StartTime", TimeSpan.Parse(tempStartTime))
            cmd.Parameters.AddWithValue("@EndTime", TimeSpan.Parse(tempEndTime))
            cmd.Parameters.AddWithValue("@Day", tempDay)
            cmd.Parameters.AddWithValue("@RoomNumber", tempRoom)
            cmd.Parameters.AddWithValue("@Semester", tempSemester)
            cmd.Parameters.AddWithValue("@Duration", tempDuration)

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while re-inserting the original schedule. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub


    Private Sub ResetForm()
        txtScheduleID.Clear()
        cbo_instructor.SelectedIndex = -1
        cbo_sec.SelectedIndex = -1
        cbo_subject.SelectedIndex = -1
        cbo_day.SelectedIndex = -1
        cb_room.SelectedIndex = -1
        cb_semester.SelectedIndex = -1
        StartTime.Value = DateTime.Now
        EndTime.Value = DateTime.Now
    End Sub

End Class
