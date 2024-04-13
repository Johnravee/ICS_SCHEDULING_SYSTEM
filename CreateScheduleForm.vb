Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CreateScheduleForm
    Dim timeDuration As String
    Dim dset As New DataSet

    Private Sub CreateScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartTime.Format = DateTimePickerFormat.Time
        StartTime.CustomFormat = "hh:mm tt"

        EndTIme.Format = DateTimePickerFormat.Time
        EndTIme.CustomFormat = "hh:mm tt"

        getSchedules()
        GetInstructor()
        GetSection()
        GetSubject()
        GetRoom()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Check if any ComboBox is empty
            If String.IsNullOrEmpty(cb_building.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_section.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_subject.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_day.SelectedItem) OrElse
                String.IsNullOrEmpty(cb_room.SelectedItem) Then
                MessageBox.Show("Please fill up all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Check if start time and end time are the same
            If StartTime.Value.ToString("hh:mm tt") = EndTIme.Value.ToString("hh:mm tt") Then
                MessageBox.Show("Same Start and End time is not applicable", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if the schedule exists in the time range
            If ScheduleExistsInTimeRange(cb_day.SelectedItem, StartTime.Value, EndTIme.Value, cb_room.SelectedItem) Then
                Dim conflictingRoom As String = GetConflictingRoom(cb_day.SelectedItem, StartTime.Value, EndTIme.Value, cb_room.SelectedItem)
                Dim conflictingSchedule As String = GetConflictingScheduleDetails(cb_day.SelectedItem, StartTime.Value, EndTIme.Value, cb_room.SelectedItem)
                MessageBox.Show("There is an existing schedule for the same time, day, and room." & vbCrLf &
                                "Room: " & conflictingRoom & vbCrLf &
                                "Schedule: " & conflictingSchedule,
                                "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Construct the time duration string
            timeDuration = StartTime.Value.ToString("hh:mm tt") & "-" & EndTIme.Value.ToString("hh:mm tt")

            ' Check if the schedule already exists
            If ScheduleExists(cb_day.SelectedItem, timeDuration, cb_room.SelectedItem) Then
                MessageBox.Show("Schedule is not available. Another schedule already exists for the same time, day, building, and room.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert the schedule into the database
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO schedules(`InstructorName`, `Section`, `Subject`, `Day`, `TimeDuration`, `RoomNumber`, `Building`) VALUES (@InstructorName, @Section, @Subject, @Day, @timeDuration, @RoomNumber, @Building)"

            ' Clear the parameters collection before adding new parameters
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cb_instructor.SelectedItem)
            cmd.Parameters.AddWithValue("@Section", cb_section.SelectedItem)
            cmd.Parameters.AddWithValue("@Subject", cb_subject.SelectedItem)
            cmd.Parameters.AddWithValue("@Day", cb_day.SelectedItem)
            cmd.Parameters.AddWithValue("@timeDuration", timeDuration)
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem)
            cmd.Parameters.AddWithValue("@Building", cb_building.SelectedItem)

            ' Open connection and execute the command
            DBCon()
            cmd.ExecuteNonQuery()
            getSchedules()

            ' Close the connection
            con.Close()

            ' Clear input fields after successful insertion
            cb_instructor.Text = ""
            cb_section.Text = ""
            cb_subject.Text = ""
            cb_day.Text = ""
            cb_building.Text = ""
            cb_room.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            ' Ensure connection is always closed, even if an exception occurs
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub getSchedules()
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM schedules ORDER BY ScheduleID DESC"
        cmd.ExecuteNonQuery()
        dataReader.SelectCommand = cmd
        dataReader.Fill(table)
        dgvSchedule.DataSource = table

        dgvSchedule.Columns("ScheduleID").Visible = False

        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()
    End Sub

    Private Function ScheduleExists(day As String, timeDuration As String, room As String) As Boolean
        Dim exists As Boolean = False
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT COUNT(*) FROM schedules WHERE RoomNumber = @RoomNumber AND TimeDuration = @TimeDuration AND Day = @Day"

        ' Clear existing parameters before adding new ones
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@TimeDuration", timeDuration)
        cmd.Parameters.AddWithValue("@RoomNumber", room)
        cmd.Parameters.AddWithValue("@Day", day)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            exists = True
        End If
        con.Close()
        Return exists
    End Function

    Private Function ScheduleExistsInTimeRange(day As String, startTime As DateTime, endTime As DateTime, room As String) As Boolean
        Dim exists As Boolean = False

        ' Convert start and end times to TimeSpan
        Dim startTimeSpan As TimeSpan = startTime.TimeOfDay
        Dim endTimeSpan As TimeSpan = endTime.TimeOfDay

        ' Query to check if any schedule overlaps with the given time range
        Dim query As String = "SELECT COUNT(*) FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND (" &
                              "((SUBSTRING_INDEX(TimeDuration, ' ', -1) >= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) <= @EndTime) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @EndTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @StartTime)) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @EndTime))"

        ' Open connection
        DBCon()
        cmd.Connection = con
        cmd.CommandText = query

        ' Clear existing parameters before adding new ones
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@RoomNumber", room)
        cmd.Parameters.AddWithValue("@Day", day)
        cmd.Parameters.AddWithValue("@StartTime", startTimeSpan.ToString())
        cmd.Parameters.AddWithValue("@EndTime", endTimeSpan.ToString())

        ' Execute query to count overlapping schedules
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' If count is greater than 0, it means there is an overlapping schedule
        If count > 0 Then
            exists = True
        End If

        ' Close connection
        con.Close()

        Return exists
    End Function

    Private Function GetConflictingRoom(day As String, startTime As DateTime, endTime As DateTime, room As String) As String
        Dim conflictingRoom As String = ""

        ' Convert start and end times to TimeSpan
        Dim startTimeSpan As TimeSpan = startTime.TimeOfDay
        Dim endTimeSpan As TimeSpan = endTime.TimeOfDay

        ' Query to retrieve conflicting room number
        Dim query As String = "SELECT RoomNumber FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND (" &
                              "((SUBSTRING_INDEX(TimeDuration, ' ', -1) >= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) <= @EndTime) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @EndTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @StartTime)) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @EndTime))"

        ' Open connection
        DBCon()
        cmd.Connection = con
        cmd.CommandText = query

        ' Clear existing parameters before adding new ones
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@RoomNumber", room)
        cmd.Parameters.AddWithValue("@Day", day)
        cmd.Parameters.AddWithValue("@StartTime", startTimeSpan.ToString())
        cmd.Parameters.AddWithValue("@EndTime", endTimeSpan.ToString())

        ' Execute query to get conflicting room number
        Dim conflictingRoomObject As Object = cmd.ExecuteScalar()

        ' If conflictingRoomObject is not Nothing, it means there is a conflicting schedule
        If conflictingRoomObject IsNot Nothing Then
            conflictingRoom = conflictingRoomObject.ToString()
        End If

        ' Close connection
        con.Close()

        Return conflictingRoom
    End Function

    Private Function GetConflictingScheduleDetails(day As String, startTime As DateTime, endTime As DateTime, room As String) As String
        Dim conflictingScheduleDetails As String = ""

        ' Convert start and end times to TimeSpan
        Dim startTimeSpan As TimeSpan = startTime.TimeOfDay
        Dim endTimeSpan As TimeSpan = endTime.TimeOfDay

        ' Query to retrieve conflicting schedule details
        Dim query As String = "SELECT TimeDuration, Day FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND (" &
                              "((SUBSTRING_INDEX(TimeDuration, ' ', -1) >= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) <= @EndTime) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @EndTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @StartTime)) OR " &
                              "(SUBSTRING_INDEX(TimeDuration, ' ', -1) <= @StartTime AND SUBSTRING_INDEX(TimeDuration, ' ', 1) >= @EndTime))"

        ' Open connection
        DBCon()
        cmd.Connection = con
        cmd.CommandText = query

        ' Clear existing parameters before adding new ones
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@RoomNumber", room)
        cmd.Parameters.AddWithValue("@Day", day)
        cmd.Parameters.AddWithValue("@StartTime", startTimeSpan.ToString())
        cmd.Parameters.AddWithValue("@EndTime", endTimeSpan.ToString())

        ' Execute query to get conflicting schedule details
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            Dim timeDuration As String = reader("TimeDuration").ToString()
            Dim conflictingDay As String = reader("Day").ToString()
            conflictingScheduleDetails &= "Day: " & conflictingDay & ", Time: " & timeDuration & vbCrLf
        End While

        ' Close reader and connection
        reader.Close()
        con.Close()

        Return conflictingScheduleDetails
    End Function

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ' Get the search query from the text box
        Dim searchQuery As String = txt_search.Text.Trim()

        ' Filter the data in the table based on the search query
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In table.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In table.Rows
                For Each column As DataColumn In table.Columns
                    ' Check if the cell value contains the search query
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For ' No need to check other columns once a match is found
                    End If
                Next
            Next

            ' Update the DataGridView with the filtered data
            dgvSchedule.DataSource = filteredData
        Else
            ' If the search query is empty, display all data
            dgvSchedule.DataSource = table
        End If
    End Sub

    Private Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname, ' ', MiddleName, ' ', Surname) AS FullName FROM instructor"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_instructor.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_instructor.Items.Add(row("FullName").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub GetSection()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "Select CONCAT(Section_Program, '-', Year, '', Section_Code) AS Section from sections"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_section.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_section.Items.Add(row("Section").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub GetSubject()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "Select CONCAT(subject_name, ' ', subject_code) AS Subject from subjects"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_subject.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_subject.Items.Add(row("Subject").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub GetRoom()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "Select CONCAT(room_number, ' ', building) AS Room from rooms"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)

            ' Clear existing items in the ComboBox
            cb_room.Items.Clear()

            ' Add each FullName value to the ComboBox
            For Each row As DataRow In newtable.Rows
                cb_room.Items.Add(row("Room").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub minimizeBtn_Click(sender As Object, e As EventArgs) Handles minimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class
