Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class SchedulePopupForm
    Dim tempName, tempSub, tempDay, tempRoom, tempSection, tempSemester, tempStartTime, tempEndTime, tempDuration As String
    Private Sub SchedulePopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StartTime1.Format = DateTimePickerFormat.Custom
        StartTime1.CustomFormat = "hh:mm tt"
        StartTime1.ShowUpDown = True

        enTime.Format = DateTimePickerFormat.Custom
        enTime.CustomFormat = "hh:mm tt"
        enTime.ShowUpDown = True






    End Sub


    Public Sub New(Instructor As String, Section As String, Subject As String, Start As String, ind As String, Day As String, Room As String, id As Integer, Semester As String)

        InitializeComponent()
        GetInstructor()
        GetSection()
        GetSubject()
        GetRoom()

        cbo_instructor.SelectedItem = Instructor
        cbo_section.SelectedItem = Section
        cbo_subject.SelectedItem = Subject
        StartTime1.Value = DateTime.ParseExact(Start, "h:mm:ss tt", CultureInfo.InvariantCulture)
        enTime.Value = DateTime.ParseExact(ind, "h:mm:ss tt", CultureInfo.InvariantCulture)
        cbo_day.SelectedItem = Day
        cb_room.SelectedItem = Room
        TXTid.Text = id.ToString()
        cbo_semester.SelectedItem = Semester

        'MsgBox(cbo_instructor.SelectedItem & " " & cbo_section.SelectedItem & " " & cbo_subject.SelectedItem & " " & cbo_day.SelectedItem & " " & cb_room.SelectedItem & " " & TXTid.Text & " " & cbo_semester.SelectedItem)


    End Sub

    Private Sub GetInstructor()
        Try
            Dim newtable As New DataTable()
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname,' ', Surname) AS FullName FROM instructor"
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
            cmd.CommandText = "SELECT CONCAT(subject_description, ' (', subject_code, ')') AS Subject FROM subjects
"
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
            cmd.CommandText = "Select Room from rooms"
            dataReader.SelectCommand = cmd
            dataReader.Fill(newtable)
            cb_room.Items.Clear()
            For Each row As DataRow In newtable.Rows
                cb_room.Items.Add(row("Room").ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateScheduleForm.Enabled = True
        CreateScheduleForm.Show()
        CreateScheduleForm.Opacity = 1
        Me.Hide()
    End Sub











    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Prompt the user for confirmation before deleting
        Dim result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then


            If DeleteSchedule() Then
                Me.Hide()
                CreateScheduleForm.ResetForm()
                CreateScheduleForm.Opacity = 1
                CreateScheduleForm.Enabled = True
                CreateScheduleForm.Show()
                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("Deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

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


    Private Function CheckScheduleConflict(day As String, room As String, StartTime As String, EndTime As String, scheduleID As Integer, semester As String) As Boolean
        Dim conflictExists As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND Semester = @semester AND ((StartTime >= @starttime AND StartTime < @endtime) OR (EndTime > @starttime AND EndTime <= @endtime) OR (StartTime <= @starttime AND EndTime >= @endtime)) AND ScheduleID <> @ScheduleID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@starttime", StartTime)
            cmd.Parameters.AddWithValue("@endtime", EndTime)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
            cmd.Parameters.AddWithValue("@semester", semester)

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

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If String.IsNullOrWhiteSpace(TXTid.Text) OrElse
        cbo_instructor.SelectedItem Is Nothing OrElse
        cbo_section.SelectedItem Is Nothing OrElse
        cbo_subject.SelectedItem Is Nothing OrElse
        cbo_day.SelectedItem Is Nothing OrElse
        cb_room.SelectedItem Is Nothing OrElse
        cbo_semester.SelectedItem Is Nothing OrElse
        StartTime1.Value = enTime.Value Then
            MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected schedule ID
        Dim scheduleID As Integer = Convert.ToInt32(TXTid.Text)

        ' Check if start time and end time are the same
        If StartTime1.Value = enTime.Value Then
            MessageBox.Show("The start time and end time cannot be the same. Please adjust the schedule accordingly.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate duration
        Dim duration As TimeSpan = enTime.Value.Subtract(StartTime1.Value)

        ' Format duration
        Dim FormatedDuration As String = duration.Hours.ToString() & "." & duration.Minutes.ToString()
        Try
            DBCon()
            cmd.Connection = con

            ' SQL query to check for schedule conflicts
            Dim conflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE Day = @Day AND RoomNumber = @RoomNumber AND StartTime < @EndTime AND EndTime > @StartTime AND ScheduleID <> @ScheduleID"
            cmd.CommandText = conflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime1.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", enTime.Value.TimeOfDay)
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
            cmd.Parameters.AddWithValue("@Section", cbo_section.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Subject", cbo_subject.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim subjectConflictCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If subjectConflictCount > 0 Then
                MessageBox.Show("The same subject cannot be scheduled twice in one day for the same section. Please choose a different subject or day.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If duration.Hours > 8 Then
                MessageBox.Show("Class time duration exceeds 8 hours. Please consider adjusting the schedule.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            ' SQL query to check for instructor conflicts
            Dim instructorConflictQuery As String = "SELECT COUNT(*) FROM schedules WHERE InstructorName = @InstructorName AND Day = @Day AND StartTime < @EndTime AND EndTime > @StartTime AND ScheduleID <> @ScheduleID"
            cmd.CommandText = instructorConflictQuery
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@InstructorName", cbo_instructor.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime1.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", enTime.Value.TimeOfDay)
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
            cmd.Parameters.AddWithValue("@Section", cbo_section.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Subject", cbo_subject.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@StartTime", StartTime1.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", enTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@Day", cbo_day.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@RoomNumber", cb_room.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Semester", cbo_semester.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Duration", FormatedDuration)
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Schedule Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                CreateScheduleForm.ResetForm()
                CreateScheduleForm.Enabled = True
                CreateScheduleForm.Opacity = 1
                CreateScheduleForm.Show()



            Else
                MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try



    End Sub
End Class
