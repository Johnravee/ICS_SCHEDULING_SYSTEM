Imports System.CodeDom
Imports System.Data.Common
Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Prepare

Public Class SchedListForm
    Dim lamesa As New DataTable()
    Dim FormattedStartTime As DateTime
    Dim FormattedEndTime As DateTime
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
            cmd.CommandText = "SELECT ScheduleID ,InstructorName, Section, Subject, TIME_FORMAT(StartTime, '%h:%i %p') AS FormattedStart, TIME_FORMAT(EndTime, '%h:%i %p') AS FormattedEnd, Day, RoomNumber FROM schedules"
            cmd.ExecuteNonQuery()
            dataReader.Fill(lamesa)
            dgv.DataSource = lamesa

            dgv.Columns("ScheduleID").Visible = False



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
            cmd.CommandText = "Select CONCAT(Section_Program, '-', Year, '', Section_Code) AS Section from sections"
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
            cmd.CommandText = "Select Room from rooms"
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

    Public Sub ExecuteQuery(query As String)

        Dim command As New MySqlCommand(query, con)
        con.Open()
        command.ExecuteReader()
        con.Close()
    End Sub


    'Delete row
    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
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

    'Update Schedule
    Private Sub upd_Click(sender As Object, e As EventArgs) Handles upd.Click


        ' Check if start time and end time are the same
        If StartTime.Value.ToString("hh:mm") = EndTime.Value.ToString("hh:mm") Then
            MessageBox.Show("Please select different start and end times.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the schedule already exists
        If ScheduleExists(cbo_day.SelectedItem, cb_room.SelectedItem, StartTime.Value.ToString("HH:mm"), EndTime.Value.ToString("HH:mm")) Then
            MessageBox.Show("Schedule is not available. Another schedule already exists for the same day and room.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If con.State = ConnectionState.Closed Then
            DBCon()
        End If

        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE schedules SET InstructorName = @instruc, Section = @sec, Subject = @sub, StartTime = @td, EndTime = @et, Day = @day, RoomNumber = @rn WHERE ScheduleID = @schedID"

            ' Clear parameters before adding new ones
            cmd.Parameters.Clear()

            ' Add parameters with their values
            cmd.Parameters.AddWithValue("@schedID", txtScheduleID.Text)
            cmd.Parameters.AddWithValue("@instruc", cbo_instructor.SelectedItem)
            cmd.Parameters.AddWithValue("@sec", cbo_sec.SelectedItem)
            cmd.Parameters.AddWithValue("@sub", cbo_subject.SelectedItem)
            cmd.Parameters.AddWithValue("@td", StartTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@et", EndTime.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@day", cbo_day.SelectedItem)
            cmd.Parameters.AddWithValue("@rn", cb_room.SelectedItem)

            ' Execute the command
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Schedule updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv.DataSource = Nothing
                lamesa.Rows.Clear()
                lamesa.Columns.Clear()
                GetSchedules()
            Else
                MessageBox.Show("Failed to update schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgv.DataSource = Nothing
                lamesa.Rows.Clear()
                lamesa.Columns.Clear()
                GetSchedules()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the schedule. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub



    'Cell click values

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        Dim index = e.RowIndex
        If index >= 0 AndAlso index < dgv.Rows.Count Then
            Dim selectedRow = dgv.Rows(index)



            If DateTime.TryParse(selectedRow.Cells(4).Value.ToString().Trim(), FormattedStartTime) AndAlso DateTime.TryParse(selectedRow.Cells(5).Value.ToString().Trim(), FormattedEndTime) Then
                StartTime.Value = FormattedStartTime
                EndTime.Value = FormattedEndTime
            End If

            txtScheduleID.Text = selectedRow.Cells(0).Value.ToString()
            cbo_instructor.SelectedItem = selectedRow.Cells(1).Value.ToString()
            cbo_sec.SelectedItem = selectedRow.Cells(2).Value.ToString()
            cbo_subject.SelectedItem = selectedRow.Cells(3).Value.ToString()
            cbo_day.SelectedItem = selectedRow.Cells(6).Value.ToString()
            cb_room.SelectedItem = selectedRow.Cells(7).Value.ToString()


            dgv.Refresh()
        End If
    End Sub

    'Check Conflict in Schedules/ If schedule is already existed
    Private Function ScheduleExists(day As String, room As String, StartTime As String, EndTime As String) As Boolean
        Dim exists As Boolean = False

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE RoomNumber = @RoomNumber AND Day = @Day AND ((StartTime >= @starttime AND StartTime < @endtime) OR (EndTime > @starttime AND EndTime <= @endtime) OR (StartTime <= @starttime AND EndTime >= @endtime))"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomNumber", room)
            cmd.Parameters.AddWithValue("@Day", day)
            cmd.Parameters.AddWithValue("@starttime", StartTime)
            cmd.Parameters.AddWithValue("@endtime", EndTime)

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


    'Delete All Schedules
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset the schedules?", "Reset Schedules", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DBCon()
                cmd.Connection = con
                cmd.CommandText = "TRUNCATE TABLE schedules"
                cmd.ExecuteNonQuery()

                MessageBox.Show("The schedules have been reset successfully.", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv.DataSource = Nothing
                lamesa.Rows.Clear()
                lamesa.Columns.Clear()
                GetSchedules()

                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while resetting the schedules. Please try again later or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class