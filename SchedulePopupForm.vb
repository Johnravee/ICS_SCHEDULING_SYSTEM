Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class SchedulePopupForm
    Private Sub SchedulePopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StartTime1.Format = DateTimePickerFormat.Custom
        StartTime1.CustomFormat = "hh:mm tt"
        StartTime1.ShowUpDown = True

        enTime.Format = DateTimePickerFormat.Custom
        enTime.CustomFormat = "hh:mm tt"
        enTime.ShowUpDown = True






    End Sub


    Public Sub New(Instructor As String, Section As String, Subject As String, Start As String, ind As String, Day As String, Room As String, id As Integer)

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

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If StartTime1.Value.ToString("hh:mm tt") = enTime.Value.ToString("hh:mm tt") Then
            MessageBox.Show("The start time and end time cannot be the same. Please adjust the schedule accordingly.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim isConflict = CheckScheduleConflict(cbo_day.SelectedItem.ToString, cb_room.SelectedItem.ToString, StartTime1.Value.ToString("HH:mm:ss"), StartTime1.Value.ToString("HH:mm:ss"), Convert.ToInt32(TXTid.Text))

        If isConflict Then
            MessageBox.Show("A schedule conflict has been detected. Please choose a different time or room for this schedule.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            ' No conflict, proceed with updating
            If updateSched() Then
                CreateScheduleForm.Close()
                CreateScheduleForm.Opacity = 1
                CreateScheduleForm.Enabled = True
                CreateScheduleForm.Show()
                MessageBox.Show("Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End If
        End If
    End Sub


    Public Function updateSched() As Boolean
        Try
            ' Check if any of the required controls are null
            If cbo_instructor.SelectedItem Is Nothing OrElse cbo_day.SelectedItem Is Nothing OrElse cb_room.SelectedItem Is Nothing OrElse StartTime1 Is Nothing OrElse Me.StartTime1 Is Nothing Then
                MsgBox("Some data is missing. Please ensure all required fields are filled in before proceeding.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Missing Data")

                Return False
            End If

            ' Convert values to string and integer
            Dim instructor As String = cbo_instructor.SelectedItem.ToString()
            Dim day As String = cbo_day.SelectedItem.ToString()
            Dim room As String = cb_room.SelectedItem.ToString()
            Dim startTime As String = StartTime1.Value.ToString("HH:mm:ss")
            Dim endTime As String = enTime.Value.ToString("HH:mm:ss")
            Dim scheduleID As Integer = Convert.ToInt32(TXTid.Text)

            ' Check for schedule conflicts
            Dim isConflict As Boolean = CheckScheduleConflict(day, room, startTime, endTime, scheduleID)

            If isConflict Then
                MsgBox("Schedule conflict detected. Please choose a different time or room.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Schedule Conflict")

                Return False
            Else
                ' Proceed with updating the schedule
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "UPDATE schedules SET InstructorName = @Instructor, Section = @Section, Subject = @Subject, StartTime = @StartTime, EndTime = @EndTime, Day = @Day, RoomNumber = @Room WHERE ScheduleID = @ScheduleID"
                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@Instructor", instructor)
                cmd.Parameters.AddWithValue("@Section", cbo_section.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Subject", cbo_subject.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Room", room)
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






    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Prompt the user for confirmation before deleting
        Dim result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Call a method to delete the schedule
            Dim scheduleDeleted = DeleteSchedule()

            If scheduleDeleted Then
                CreateScheduleForm.Close()
                CreateScheduleForm.Opacity = 1
                CreateScheduleForm.Enabled = True
                CreateScheduleForm.Show()
                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Me.Close()
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
