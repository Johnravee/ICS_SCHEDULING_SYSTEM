Imports System.CodeDom
Imports System.Data.Common
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor
Imports Mysqlx.Prepare

Public Class SchedListForm
    Dim i As Integer
    Private Sub SchedListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()
    End Sub

    Private Sub Load_data()
        Dim lamesa As New DataTable()
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM schedules"
        cmd.ExecuteNonQuery()
        dataReader.Fill(lamesa)
        dgv.DataSource = lamesa

        dgv.Columns("instructorID").Visible = False

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim searchQuery As String = TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In table.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In table.Rows
                For Each column As DataColumn In table.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            dgv.DataSource = filteredData
        Else
            dgv.DataSource = table
        End If
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New MySqlCommand(query, con)
        con.Open()
        command.ExecuteReader()
        con.Close()
    End Sub



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
                    Load_data()
                    MessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
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
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim updateCommand As New MySqlCommand("UPDATE schedules SET InstructorName=@instruc, Section=@sec, Subject=@sub, TimeDuration=@td, Day=@day, RoomNumber=@rn, Building=@build WHERE ScheduleID=@sched", con)
        updateCommand.Parameters.AddWithValue("@sched", TextBox2.Text)
        updateCommand.Parameters.AddWithValue("@instruc", TextBox3.Text)
        updateCommand.Parameters.AddWithValue("@sec", TextBox4.Text)
        updateCommand.Parameters.AddWithValue("@sub", TextBox5.Text)
        updateCommand.Parameters.AddWithValue("@td", TextBox6.Text)
        updateCommand.Parameters.AddWithValue("@day", TextBox7.Text)
        updateCommand.Parameters.AddWithValue("@rn", TextBox8.Text)
        updateCommand.Parameters.AddWithValue("@build", TextBox9.Text)

        Dim selectedRowIndex As Integer = dgv.CurrentCell.RowIndex
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgv.Rows.Count Then
            dgv.Rows(selectedRowIndex).Cells("ScheduleID").Value = TextBox2.Text
            dgv.Rows(selectedRowIndex).Cells("InstructorName").Value = TextBox3.Text
            dgv.Rows(selectedRowIndex).Cells("Section").Value = TextBox4.Text
            dgv.Rows(selectedRowIndex).Cells("Subject").Value = TextBox5.Text
            dgv.Rows(selectedRowIndex).Cells("TimeDuration").Value = TextBox6.Text
            dgv.Rows(selectedRowIndex).Cells("Day").Value = TextBox7.Text
            dgv.Rows(selectedRowIndex).Cells("RoomNumber").Value = TextBox8.Text
            dgv.Rows(selectedRowIndex).Cells("Building").Value = TextBox9.Text

            dgv.Refresh()

        End If
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgv.Rows.Count Then
            Try
                updateCommand.ExecuteNonQuery()
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Error updating record: " & ex.Message)
            End Try

            dgv.Refresh()
        Else
            MessageBox.Show("Please select a valid row.")
        End If

        con.Close()
    End Sub


    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgv.Rows(index)
        TextBox2.Text = selectedRow.Cells(0).Value.ToString()
        TextBox3.Text = selectedRow.Cells(1).Value.ToString()
        TextBox4.Text = selectedRow.Cells(2).Value.ToString()
        TextBox5.Text = selectedRow.Cells(3).Value.ToString()
        TextBox6.Text = selectedRow.Cells(4).Value.ToString()
        TextBox7.Text = selectedRow.Cells(5).Value.ToString()
        TextBox8.Text = selectedRow.Cells(6).Value.ToString()
        TextBox9.Text = selectedRow.Cells(7).Value.ToString()

        dgv.Refresh()
    End Sub

End Class
