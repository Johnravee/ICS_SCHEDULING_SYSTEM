Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class SchedulePopupForm
    Private scheduleID As Integer
    Private dgvSchedule As Object

    Public Sub New(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String, ByVal startTime As DateTime, ByVal endTime As DateTime, ByVal data4 As String, ByVal data5 As String, ByVal comboBoxData As String, ByVal days As List(Of String), ID As Integer)
        InitializeComponent()
        cbo_instructor.Items.Add(data1)
        cbo_section.Items.Add(data2)
        cbo_subject.Items.Add(data3)
        cb_room.Items.Add(data5)
        TXTid.Text = ID
        cbo_instructor.SelectedItem = data1
        cbo_section.SelectedItem = data2
        cbo_subject.SelectedItem = data3
        cbo_day.Items.AddRange(days.ToArray())
        cbo_day.SelectedItem = data4
        cb_room.SelectedItem = data5
        StartTime1.Value = startTime
        EndTime1.Value = endTime
    End Sub

    Private Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname, ' ', MiddleName, ' ', Surname) AS FullName FROM instructor"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)
            cbo_instructor.Items.Clear()
            For Each row As DataRow In newtable.Rows
                cbo_instructor.Items.Add(row("FullName").ToString())
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
            cbo_section.Items.Clear()
            For Each row As DataRow In newtable.Rows
                cbo_section.Items.Add(row("Section").ToString())
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
            cbo_subject.Items.Clear()
            For Each row As DataRow In newtable.Rows
                cbo_subject.Items.Add(row("Subject").ToString())
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
            cmd.CommandText = "Select room_number from rooms"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)
            cb_room.Items.Clear()
            For Each row As DataRow In newtable.Rows
                cb_room.Items.Add(row("room_number").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub getSchedules()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules ORDER BY ScheduleID DESC"


            table.Clear()


            dataReader.SelectCommand = cmd
            dataReader.Fill(table)

            ' Add new columns only if they don't already exist
            If Not table.Columns.Contains("Start Time") Then
                table.Columns.Add("Start Time", GetType(String))
            End If

            If Not table.Columns.Contains("End Time") Then
                table.Columns.Add("End Time", GetType(String))
            End If


            For Each row As DataRow In table.Rows
                Dim startTime As TimeSpan = DirectCast(row("StartTime"), TimeSpan)
                Dim endTime As TimeSpan = DirectCast(row("EndTime"), TimeSpan)

                Dim startDateTime As DateTime = DateTime.Today.Add(startTime)
                Dim endDateTime As DateTime = DateTime.Today.Add(endTime)


                row("Start Time") = startDateTime.ToString("hh:mm tt")
                row("End Time") = endDateTime.ToString("hh:mm tt")
            Next

            dgvSchedule.DataSource = table

            ' Optionally, hide the ScheduleID column
            dgvSchedule.Columns("ScheduleID").Visible = False
            dgvSchedule.Columns("StartTime").Visible = False
            dgvSchedule.Columns("EndTime").Visible = False

            ' Set auto-sizing and wrap mode for better display
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub













    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateScheduleForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim isConflict As Boolean = CheckScheduleConflict(cbo_day.SelectedItem.ToString(), cb_room.SelectedItem.ToString(), StartTime1.Value.ToString("HH:mm:ss"), EndTime1.Value.ToString("HH:mm:ss"), Convert.ToInt32(TXTid.Text))

        If isConflict Then
            MessageBox.Show("Schedule conflict detected. Please choose a different time or room.")
        Else
            ' No conflict, proceed with updating
            If updateSched() Then
                ' Close the form after successful update
                Me.Close()
            End If
        End If
    End Sub


    Public Function updateSched() As Boolean
        Try
            ' Check if any of the required controls are null
            If cbo_instructor.SelectedItem Is Nothing OrElse cbo_day.SelectedItem Is Nothing OrElse cb_room.SelectedItem Is Nothing OrElse StartTime1 Is Nothing OrElse EndTime1 Is Nothing Then
                MsgBox("Some data is missing. Please fill in all required fields.")
                Return False
            End If

            ' Convert values to string and integer
            Dim instructor As String = cbo_day.SelectedItem.ToString()
            Dim day As String = cbo_day.SelectedItem.ToString()
            Dim room As String = cb_room.SelectedItem.ToString()
            Dim startTime As String = StartTime1.Value.ToString("HH:mm:ss")
            Dim endTime As String = EndTime1.Value.ToString("HH:mm:ss")
            Dim scheduleID As Integer = Convert.ToInt32(TXTid.Text)

            ' Check for schedule conflicts
            Dim isConflict As Boolean = CheckScheduleConflict(day, room, startTime, endTime, scheduleID)

            If isConflict Then
                MsgBox("Schedule conflict detected. Please choose a different time or room.")
                Return False
            Else
                ' Proceed with updating the schedule
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "UPDATE schedules SET InstructorName = @Instructor, Section = @Section, Subject = @Subject, StartTime = @StartTime, EndTime = @EndTime, Day = @Day, RoomNumber = @Room WHERE ScheduleID = @ScheduleID"
                cmd.Parameters.Clear()
                Dim InstructorValue As Object = If(cbo_instructor.SelectedItem IsNot Nothing, cbo_instructor.SelectedItem, cbo_instructor.Text)
                Dim sectionValue As Object = If(cbo_section.SelectedItem IsNot Nothing, cbo_section.SelectedItem, cbo_section.Text)
                Dim subjectValue As Object = If(cbo_subject.SelectedItem IsNot Nothing, cbo_subject.SelectedItem, cbo_subject.Text)
                Dim roomValue As Object = If(cb_room.SelectedItem IsNot Nothing, cb_room.SelectedItem, cb_room.Text)

                cmd.Parameters.AddWithValue("@Instructor", InstructorValue)
                cmd.Parameters.AddWithValue("@Section", sectionValue)
                cmd.Parameters.AddWithValue("@Subject", subjectValue)
                cmd.Parameters.AddWithValue("@Room", roomValue)
                cmd.Parameters.AddWithValue("@StartTime", startTime)
                cmd.Parameters.AddWithValue("@EndTime", endTime)
                cmd.Parameters.AddWithValue("@Day", day)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

                cmd.ExecuteNonQuery()
                con.Close()

                Return True
            End If
        Catch ex As Exception
            MsgBox("Error updating schedule: " & ex.Message)
            Return False
        End Try
    End Function



    Private Sub SchedulePopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetInstructor()
        GetSection()
        GetSubject()
        GetRoom()

        If Not String.IsNullOrEmpty(cbo_instructor.Text) Then
            cbo_instructor.SelectedItem = cbo_instructor.Text
        End If

        If Not String.IsNullOrEmpty(cbo_day.Text) Then
            cbo_day.SelectedItem = cbo_day.Text
        End If

        If Not String.IsNullOrEmpty(cb_room.Text) Then
            cb_room.SelectedItem = cb_room.Text
        End If

    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Prompt the user for confirmation before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Call a method to delete the schedule
            Dim scheduleDeleted As Boolean = DeleteSchedule()

            If scheduleDeleted Then
                Me.Close()
                ' Optionally, you can refresh the schedule grid or perform any other necessary actions after deletion
            Else
                MessageBox.Show("Failed to delete schedule.")
            End If
        End If
    End Sub

    Private Function DeleteSchedule() As Boolean
        Try
            ' Get the schedule ID to be deleted
            Dim scheduleID As Integer = Convert.ToInt32(TXTid.Text)

            ' Connect to the database
            DBCon()

            ' Prepare and execute the SQL command to delete the schedule
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM schedules WHERE ScheduleID = @ScheduleID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
            cmd.ExecuteNonQuery()

            ' Close the database connection
            con.Close()

            ' Return true to indicate successful deletion
            Return True
        Catch ex As Exception
            ' Handle any errors that occur during deletion
            MsgBox("Error deleting schedule: " & ex.Message)
            Return False
        End Try
    End Function


    Private Function CheckScheduleConflict(day As String, room As String, StartTime As String, EndTime As String, scheduleID As Integer) As Boolean
        Dim conflictExists As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND ((StartTime >= @starttime AND StartTime < @endtime) OR (EndTime > @starttime AND EndTime <= @endtime) OR (StartTime <= @starttime AND EndTime >= @endtime)) AND ScheduleID <> @ScheduleID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@starttime", StartTime)
            cmd.Parameters.AddWithValue("@endtime", EndTime)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                conflictExists = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return conflictExists
    End Function
End Class
