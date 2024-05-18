Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports MySql.Data.MySqlClient

Public Class FacilityListForm
    Dim roomTable As New DataTable

    Private Sub FacilityListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRoom()
    End Sub

    Private Sub GetRoom()
        DBCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM rooms"
            roomTable.Clear()
            dataReader.SelectCommand = cmd
            dataReader.Fill(roomTable)

            DataGridView1.DataSource = roomTable

            ' Hide the RoomID column
            DataGridView1.Columns("RoomID").Visible = False

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index = e.RowIndex
        If index >= 0 AndAlso index < DataGridView1.Rows.Count Then
            Dim selectedRow = DataGridView1.Rows(index)
            txtid.Text = selectedRow.Cells(0).Value.ToString
            txtroom.Text = selectedRow.Cells(1).Value.ToString
        End If
    End Sub

    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        ' Validate that the room textbox is not empty
        If String.IsNullOrEmpty(txtroom.Text.Trim()) Then
            MessageBox.Show("Please fill in the room field before inserting a new record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con

            ' Check if the room already exists
            cmd.CommandText = "SELECT COUNT(*) FROM rooms WHERE Room = @room"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@room", UCase(txtroom.Text.Trim()))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("A room with the same name already exists.", "Duplicate Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' If the room doesn't exist, proceed with insertion
            cmd.CommandText = "INSERT INTO rooms (Room) VALUES (@room)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@room", UCase(txtroom.Text))

            If cmd.ExecuteNonQuery() > 0 Then
                txtid.Clear()
                txtroom.Clear()
                DataGridView1.DataSource = Nothing
                roomTable.Columns.Clear()
                roomTable.Rows.Clear()
                GetRoom()
                con.Close()
                MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Validate that a row is selected and the room textbox is not empty
        If String.IsNullOrEmpty(txtid.Text.Trim()) Then
            MessageBox.Show("Please select a row to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(txtroom.Text.Trim()) Then
            MessageBox.Show("Please fill in the room field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con

            ' Check if the room already exists
            cmd.CommandText = "SELECT COUNT(*) FROM rooms WHERE Room = @room AND RoomID != @id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@room", UCase(txtroom.Text.Trim()))
            cmd.Parameters.AddWithValue("@id", txtid.Text.Trim())
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("A room with the same name already exists.", "Duplicate Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' If the room doesn't exist, proceed with update
            cmd.CommandText = "UPDATE rooms SET Room = @room WHERE RoomID = @id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", txtid.Text)
            cmd.Parameters.AddWithValue("@room", txtroom.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                txtid.Clear()
                txtroom.Clear()
                DataGridView1.DataSource = Nothing
                roomTable.Columns.Clear()
                roomTable.Rows.Clear()
                GetRoom()
                con.Close()
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the provided Room.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ' Validate that a row is selected
        If String.IsNullOrEmpty(txtid.Text.Trim()) Then
            MessageBox.Show("Please select a row to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM rooms WHERE RoomID=@RoomID"
            ' Set parameter values
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomID", txtid.Text)

            ' Execute the query
            If cmd.ExecuteNonQuery() > 0 Then
                txtid.Clear()
                txtroom.Clear()
                DataGridView1.DataSource = Nothing
                roomTable.Columns.Clear()
                roomTable.Rows.Clear()
                GetRoom()
                con.Close()
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the provided Room.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim searchQuery As String = SearchTextBox.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In roomTable.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In roomTable.Rows
                For Each column As DataColumn In roomTable.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            DataGridView1.DataSource = filteredData
        Else
            DataGridView1.DataSource = roomTable
        End If
    End Sub
End Class
