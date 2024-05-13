Imports System.IO
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

        Try
            getSchedules()
            GetInstructor()
            GetSection()
            GetSubject()
            GetRoom()


            cb_instructor.SelectedIndex = 0
            cb_section.SelectedIndex = 0
            cb_subject.SelectedIndex = 0
            cb_room.SelectedIndex = 0
            cb_day.SelectedIndex = 0
            cbo_semester.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Sorry, something went wrong while loading the form. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
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
        MsgBox("I miss you na. ")
        Try
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
                MessageBox.Show("Please choose different start and end times.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check if the schedule already exists
            If ScheduleExists(cb_day.SelectedItem, cb_room.SelectedItem, StartTime.Value.ToString("HH:mm"), EndTIme.Value.ToString("HH:mm"), cbo_semester.SelectedItem) Then
                MessageBox.Show("The selected schedule conflicts with an existing one. Please choose a different time or room.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
                Return
            End If


            cmd.Connection = con
            cmd.CommandText = "INSERT INTO schedules(`InstructorName`, `Section`, `Subject`, `StartTime`, `EndTime`, `Day`, `RoomNumber`, Semester) VALUES (@InstructorName, @Section, @Subject, @StartTime, @EndTime, @Day, @RoomNumber, @semester)"


            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cb_instructor.SelectedItem)
            cmd.Parameters.AddWithValue("@Section", cb_section.SelectedItem)
            cmd.Parameters.AddWithValue("@Subject", cb_subject.SelectedItem)
            cmd.Parameters.AddWithValue("@StartTime", StartTime.Value)
            cmd.Parameters.AddWithValue("@EndTime", EndTIme.Value)
            cmd.Parameters.AddWithValue("@Day", cb_day.SelectedItem)
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem)
            cmd.Parameters.AddWithValue("@semester", cbo_semester.SelectedItem)


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

        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub getSchedules()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules ORDER BY Section, InstructorName, StartTime, EndTime, RoomNumber ASC"

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

    Private Function ScheduleExists(day As String, room As String, StartTime As String, EndTime As String, semester As String) As Boolean
        Dim exists As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND ((StartTime >= @starttime AND StartTime < @endtime) OR (EndTime > @starttime AND EndTime <= @endtime) OR (StartTime <= @starttime AND EndTime >= @endtime))  AND Semester = @semester"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@starttime", StartTime)
            cmd.Parameters.AddWithValue("@endtime", EndTime)
            cmd.Parameters.AddWithValue("@semester", semester)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                exists = True
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

    Private Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname,' ', Surname) AS FullName FROM instructor"
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
            MessageBox.Show("Sorry, we encountered an error while retrieving section information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetSubject()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(subject_description, ' (', subject_code, ')') AS Subject FROM subjects
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

    Private Sub GetRoom()
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

    End Sub


End Class
