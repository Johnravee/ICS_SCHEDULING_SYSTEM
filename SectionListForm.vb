Imports MySql.Data.MySqlClient

Public Class SectionListForm
    ' Define a variable to store the currently selected DataGridView row index
    Private selectedRowIndex As Integer

    Private Sub SectionListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Try
            Dim SectionTable As New DataTable
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM sections"
            table.Clear()
            dataReader.SelectCommand = cmd
            dataReader.Fill(SectionTable)

            DataGridView1.DataSource = SectionTable

            ' Hide the SectionID column
            DataGridView1.Columns("SectionID").Visible = False

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
            TextBox2.Text = row.Cells("SectionID").Value.ToString()
            TextBox3.Text = row.Cells("Section_Code").Value.ToString()
            TextBox4.Text = row.Cells("Year").Value.ToString()
            TextBox5.Text = row.Cells("Section_Program").Value.ToString()
            ' Store the selected row index for future reference
            selectedRowIndex = e.RowIndex
        End If
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRowIndex = selectedRow.Index

            ' Populate TextBoxes with the values of the selected row
            TextBox2.Text = selectedRow.Cells("SectionID").Value.ToString()
            TextBox3.Text = selectedRow.Cells("Section_Code").Value.ToString()
            TextBox4.Text = selectedRow.Cells("Year").Value.ToString()
            TextBox5.Text = selectedRow.Cells("Section_Program").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedRowIndex <> -1 Then
            ' Get the SectionID of the selected row
            Dim sectionID As Integer = DataGridView1.Rows(selectedRowIndex).Cells("SectionID").Value

            ' Delete the record from the database
            Dim connectionString As String = "server=localhost;username=root;password=;database=ics_scheduling_db;SslMode=none"
            Dim query As String = "DELETE FROM sections WHERE SectionID=@SectionID"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    Try
                        connection.Open()
                        ' Set parameter values
                        command.Parameters.AddWithValue("@SectionID", sectionID)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record deleted successfully!")
                            ' Remove the row from the DataGridView
                            DataGridView1.Rows.RemoveAt(selectedRowIndex)
                            selectedRowIndex = -1 ' Reset selectedRowIndex
                        Else
                            MessageBox.Show("No record found with the provided SectionID.")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If selectedRowIndex <> -1 Then
            ' Get the SectionID of the selected row
            Dim sectionID As Integer = DataGridView1.Rows(selectedRowIndex).Cells("SectionID").Value

            ' Collect updated values from TextBoxes
            Dim sectionCode As String = TextBox3.Text
            Dim year As Integer
            If Integer.TryParse(TextBox4.Text, year) = False Then
                MessageBox.Show("Please enter a valid year.")
                Return
            End If
            Dim sectionProgram As String = TextBox5.Text

            ' Update the record in the database
            Dim connectionString As String = "server=localhost;username=root;password=;database=ics_scheduling_db;SslMode=none"
            Dim query As String = "UPDATE sections SET Section_Code=@SectionCode, Year=@Year, Section_Program=@SectionProgram WHERE SectionID=@SectionID"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    Try
                        connection.Open()
                        ' Set parameter values
                        command.Parameters.AddWithValue("@SectionID", sectionID)
                        command.Parameters.AddWithValue("@SectionCode", sectionCode)
                        command.Parameters.AddWithValue("@Year", year)
                        command.Parameters.AddWithValue("@SectionProgram", sectionProgram)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record updated successfully!")
                            ' Update DataGridView with new values
                            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(selectedRowIndex)
                            selectedRow.Cells("Section_Code").Value = sectionCode
                            selectedRow.Cells("Year").Value = year
                            selectedRow.Cells("Section_Program").Value = sectionProgram
                        Else
                            MessageBox.Show("No record found with the provided SectionID.")
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
End Class
