Imports MySql.Data.MySqlClient

Public Class FacilityListForm
    Private selectedRowIndex As Integer

    Private Sub FacilityListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Try
            Dim roomTable As New DataTable
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM rooms"
            roomTable.Clear()
            dataReader.SelectCommand = cmd
            dataReader.Fill(roomTable)

            DataGridView1.DataSource = roomTable

            ' Hide the RoomID column
            DataGridView1.Columns("RoomID").Visible = False

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' When a cell is clicked, populate the TextBoxes with the values of the selected row
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox2.Text = row.Cells("RoomID").Value.ToString()
            TextBox3.Text = row.Cells("room_number").Value.ToString()
            ' Store the selected row index for future reference
            selectedRowIndex = e.RowIndex
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If selectedRowIndex <> -1 Then
            ' Get the RoomID of the selected row
            Dim roomID As Integer = DataGridView1.Rows(selectedRowIndex).Cells("RoomID").Value

            ' Collect updated values from TextBoxes
            Dim roomNumber As String = TextBox3.Text

            ' Update the record in the database
            Dim connectionString As String = "server=localhost;username=root;password=;database=ics_scheduling_db;SslMode=none"
            Dim query As String = "UPDATE rooms SET room_number=@RoomNumber WHERE RoomID=@RoomID"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    Try
                        connection.Open()
                        ' Set parameter values
                        command.Parameters.AddWithValue("@RoomID", roomID)
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record updated successfully!")
                            ' Update DataGridView with new values
                            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(selectedRowIndex)
                            selectedRow.Cells("room_number").Value = roomNumber
                        Else
                            MessageBox.Show("No record found with the provided RoomID.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error updating record: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If selectedRowIndex <> -1 Then
            ' Get the RoomID of the selected row
            Dim roomID As Integer = DataGridView1.Rows(selectedRowIndex).Cells("RoomID").Value

            ' Delete the record from the database
            Dim connectionString As String = "server=localhost;username=root;password=;database=ics_scheduling_db;SslMode=none"
            Dim query As String = "DELETE FROM rooms WHERE RoomID=@RoomID"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    Try
                        connection.Open()
                        ' Set parameter values
                        command.Parameters.AddWithValue("@RoomID", roomID)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record deleted successfully!")
                            ' Remove the row from the DataGridView
                            DataGridView1.Rows.RemoveAt(selectedRowIndex)
                            selectedRowIndex = -1 ' Reset selectedRowIndex
                        Else
                            MessageBox.Show("No record found with the provided RoomID.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error deleting record: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim searchText As String = SearchTextBox.Text.Trim()
        If searchText <> "" Then
            Dim filteredView As New DataView(CType(DataGridView1.DataSource, DataTable))
            filteredView.RowFilter = $"room_number LIKE '%{searchText}%'"
            DataGridView1.DataSource = filteredView
        End If
    End Sub
End Class