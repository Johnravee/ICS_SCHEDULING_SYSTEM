
Imports MySql.Data.MySqlClient

Public Class CreateScheduleForm
    Dim timeDuration As String
    Dim ScheduleTB As New DataTable



    Private Sub CreateScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartTime.Format = DateTimePickerFormat.Custom
        StartTime.CustomFormat = "hh:mm tt"
        StartTime.ShowUpDown = True

        EndTIme.Format = DateTimePickerFormat.Custom
        EndTIme.CustomFormat = "hh:mm tt"
        EndTIme.ShowUpDown = True







    End Sub

    Public Sub ResetForm()
        ' Reset all fields to their initial state
        cb_instructor.SelectedIndex = -1
        cb_section.SelectedIndex = -1
        cb_subject.SelectedIndex = -1
        cb_day.SelectedIndex = -1
        cb_room.SelectedIndex = -1
        cbo_semester.SelectedIndex = -1

        dgvSchedule.DataSource = Nothing
        getSchedules()
    End Sub

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Try
            Dim Start As DateTime = StartTime.Value
            Dim ind As DateTime = EndTIme.Value
            Dim duration As TimeSpan = ind - Start

            'Format duration
            Dim FormatedDuration As String = duration.Hours.ToString() & "." & duration.Minutes.ToString()

            If String.IsNullOrEmpty(cb_section.SelectedItem) OrElse
                    String.IsNullOrEmpty(cb_section.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_subject.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_day.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_room.SelectedItem) OrElse
                String.IsNullOrEmpty(cbo_semester.SelectedItem) Then
                MessageBox.Show("Please fill up all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Check if start time and end time are the same
            If StartTime.Value.ToString("hh:mm") = EndTIme.Value.ToString("hh:mm") Then
                MessageBox.Show("The start time and end time cannot be the same. Please adjust the schedule accordingly.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            If issubjectExist(cb_subject.SelectedItem.ToString(), cb_section.SelectedItem.ToString(), cb_day.SelectedItem.ToString(), cbo_semester.SelectedItem.ToString()) Then
                MessageBox.Show($"The subject {cb_subject.SelectedItem} is already assigned to the section {cb_section.SelectedItem} ${cbo_semester.SelectedItem} at {cb_day.SelectedItem}. Please consider adjusting the subject.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'Adjust nalang if needed
            If duration.Hours <= 0 Or duration.Hours > 8 Then
                MessageBox.Show("Class time duration exceeds 8 hours. Please consider adjusting the schedule.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            ' Check if the schedule already exists or conflicts with consecutive hours
            If ScheduleExists(cb_day.SelectedItem, cb_room.SelectedItem, StartTime.Value.ToString("HH:mm"), EndTIme.Value.ToString("HH:mm"), cbo_semester.SelectedItem, cb_subject.SelectedItem) Then
                MessageBox.Show("The selected schedule conflicts with an existing one or has consecutive hours. Please choose a different time or room.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If






            cmd.Connection = con
            cmd.CommandText = "INSERT INTO schedules(`InstructorName`, `Section`, `Subject`, `StartTime`, `EndTime`,`Day`, `RoomNumber`, Semester, `Duration`) VALUES (@InstructorName, @Section, @Subject, @StartTime, @EndTime, @Day, @RoomNumber, @semester, @duration)"


            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cb_instructor.SelectedItem)
            cmd.Parameters.AddWithValue("@Section", cb_section.SelectedItem)
            cmd.Parameters.AddWithValue("@Subject", cb_subject.SelectedItem)
            cmd.Parameters.AddWithValue("@StartTime", Start)
            cmd.Parameters.AddWithValue("@EndTime", ind)
            cmd.Parameters.AddWithValue("@Day", cb_day.SelectedItem)
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem)
            cmd.Parameters.AddWithValue("@semester", cbo_semester.SelectedItem)
            cmd.Parameters.AddWithValue("@duration", FormatedDuration)

            DBCon()
            cmd.ExecuteNonQuery()
            getSchedules()
            con.Close()

            cbo_semester.SelectedIndex = -1
            cb_day.SelectedIndex = -1
            cb_instructor.SelectedIndex = -1
            cb_room.SelectedIndex = -1
            cb_section.SelectedIndex = -1
            cb_subject.SelectedIndex = -1


        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Public Sub getSchedules()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules ORDER BY Section DESC"

            ScheduleTB.Clear()

            dataReader.SelectCommand = cmd
            dataReader.Fill(ScheduleTB)

            ' Add new columns only if they don't already exist
            If Not ScheduleTB.Columns.Contains("Start Time") Then
                ScheduleTB.Columns.Add("Start Time", GetType(String))
            End If

            If Not ScheduleTB.Columns.Contains("End Time") Then
                ScheduleTB.Columns.Add("End Time", GetType(String))
            End If



            For Each row As DataRow In ScheduleTB.Rows
                Dim startTime As TimeSpan = DirectCast(row("StartTime"), TimeSpan)
                Dim endTime As TimeSpan = DirectCast(row("EndTime"), TimeSpan)

                Dim startDateTime As DateTime = DateTime.Today.Add(startTime)
                Dim endDateTime As DateTime = DateTime.Today.Add(endTime)

                row("Start Time") = startDateTime.ToString("hh:mm tt")
                row("End Time") = endDateTime.ToString("hh:mm tt")

            Next

            dgvSchedule.DataSource = ScheduleTB

            ' Optionally, hide the ScheduleID column
            dgvSchedule.Columns("ScheduleID").Visible = False
            dgvSchedule.Columns("StartTime").Visible = False
            dgvSchedule.Columns("EndTime").Visible = False

            dgvSchedule.Columns("InstructorName").HeaderText = "Name"
            dgvSchedule.Columns("RoomNumber").HeaderText = "Room"


            ' Set auto-sizing and wrap mode for better display
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching schedules. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub

    Private Function ScheduleExists(day As String, room As String, StartTime As String, EndTime As String, semester As String, subject As String) As Boolean
        Dim exists As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND Semester = @semester AND Subject = @subject AND ((StartTime >= @starttime AND StartTime < @endtime) OR (EndTime > @starttime AND EndTime <= @endtime) OR (StartTime <= @starttime AND EndTime >= @endtime))"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@starttime", StartTime)
            cmd.Parameters.AddWithValue("@endtime", EndTime)
            cmd.Parameters.AddWithValue("@semester", semester)
            cmd.Parameters.AddWithValue("@subject", subject)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                exists = True
            End If

            ' Check for consecutive hour conflict
            If Not exists Then
                If IsConsecutiveHour(day, room, StartTime, EndTime, semester, subject) Then
                    exists = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return exists
    End Function

    Private Function IsConsecutiveHour(day As String, room As String, StartTime As String, EndTime As String, semester As String, subject As String) As Boolean
        Dim isConsecutive As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND Semester = @semester AND Subject = @subject"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@semester", semester)
            cmd.Parameters.AddWithValue("@subject", subject)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim existingStartTime As DateTime = DateTime.Parse(reader("StartTime").ToString())
                Dim existingEndTime As DateTime = DateTime.Parse(reader("EndTime").ToString())

                Dim newStartTime As DateTime = DateTime.Parse(StartTime)
                Dim newEndTime As DateTime = DateTime.Parse(EndTime)

                ' Check for consecutive hour conflict
                If existingEndTime = newStartTime OrElse existingStartTime = newEndTime Then
                    isConsecutive = True
                    Exit While
                End If
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return isConsecutive
    End Function



    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

        Dim searchQuery As String = txt_search.Text.Trim()

        ' Filter the data in the table based on the search query
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In ScheduleTB.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)

            Next

            For Each row As DataRow In ScheduleTB.Rows
                For Each column As DataColumn In ScheduleTB.Columns
                    ' Check if the cell value contains the search query
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For ' No need to check other columns once a match is found
                    End If
                Next
            Next

            dgvSchedule.Columns("ScheduleID").Visible = False
            dgvSchedule.Columns("StartTime").Visible = False
            dgvSchedule.Columns("EndTime").Visible = False
            dgvSchedule.DataSource = filteredData
        Else

            dgvSchedule.DataSource = ScheduleTB
        End If
    End Sub

    Public Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname, ' ', Surname) AS FullName FROM instructor ORDER BY FullName ASC"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_instructor.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_instructor.Items.Add(row("FullName").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving instructor information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub





    Public Sub GetSection()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "Select CONCAT(Section_Program, '-', Year, '', Section_Code) AS Section from sections ORDER BY Section ASC"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_section.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_section.Items.Add(row("Section").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving section information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetSubject()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(subject_description, ' (', subject_code, ')') AS Subject FROM subjects ORDER BY Subject ASC
"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_subject.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_subject.Items.Add(row("Subject").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving subject information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetRoom()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "Select Room from rooms"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_room.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_room.Items.Add(row("Room").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving room information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvSchedule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick
        If e.RowIndex >= 0 Then
            ' Retrieve data from the selected row
            Dim selectedRow As DataGridViewRow = dgvSchedule.Rows(e.RowIndex)
            Dim instructor As String = selectedRow.Cells("InstructorName").Value.ToString()
            Dim Section As String = selectedRow.Cells("Section").Value.ToString()
            Dim Subject As String = selectedRow.Cells("Subject").Value.ToString()

            Dim Day As String = selectedRow.Cells("Day").Value.ToString()
            Dim Room As String = selectedRow.Cells("RoomNumber").Value.ToString()
            Dim id = selectedRow.Cells("ScheduleID").Value.ToString()
            Dim startTime As DateTime = DateTime.Parse(selectedRow.Cells("StartTime").Value.ToString())
            Dim endTime As DateTime = DateTime.Parse(selectedRow.Cells("EndTime").Value.ToString())
            Dim Semester = selectedRow.Cells("Semester").Value.ToString()

            ' Convert time portion to strings
            Dim startTimeString As String = startTime.ToString("h:mm:ss tt")
            Dim endTimeString As String = endTime.ToString("h:mm:ss tt")

            Dim PopupForm As New SchedulePopupForm(instructor, Section, Subject, startTimeString, endTimeString, Day, Room, Val(id), Semester)


            PopupForm.BringToFront()
            PopupForm.Show()
            Me.Opacity = 0.9
            Me.Enabled = False


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Hide()
        ResetForm()
    End Sub


    Private Function issubjectExist(subject As String, section As String, Day As String, semester As String)

        DBCon()

        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE Section = @section AND Subject = @subject AND DAY = @day AND Semester = @semester"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@section", section)
            cmd.Parameters.AddWithValue("@subject", subject)
            cmd.Parameters.AddWithValue("@day", Day)
            cmd.Parameters.AddWithValue("@semester", semester)


            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving room information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



End Class
