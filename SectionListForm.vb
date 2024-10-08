﻿Imports MySql.Data.MySqlClient

Public Class SectionListForm
    Dim SectionTable As New DataTable

    Private Sub SectionListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSection()
    End Sub

    Private Sub GetSection()
        DBCon()
        Try
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
        Dim index = e.RowIndex
        If index >= 0 AndAlso index < DataGridView1.Rows.Count Then
            Dim selectedRow = DataGridView1.Rows(index)
            txtsectionid.Text = selectedRow.Cells(0).Value.ToString()
            txtcode.Text = selectedRow.Cells(1).Value.ToString()
            txtyear.Text = selectedRow.Cells(2).Value.ToString()
            txtprogram.Text = selectedRow.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if a row is selected
        If String.IsNullOrEmpty(txtsectionid.Text.Trim()) Then
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the SectionID of the selected row
        Dim sectionID As Integer = Val(txtsectionid.Text)

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM sections WHERE SectionID=@SectionID"

            ' Set parameter values
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SectionID", sectionID)

            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                SectionTable.Clear()
                GetSection()
                txtprogram.Clear()
                txtcode.Clear()

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Else
                MessageBox.Show("No record found with the provided Section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if a row is selected
        If String.IsNullOrEmpty(txtsectionid.Text.Trim()) Then
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate that all textboxes are filled
        If String.IsNullOrEmpty(txtcode.Text.Trim()) OrElse String.IsNullOrEmpty(txtyear.Text.Trim()) OrElse String.IsNullOrEmpty(txtprogram.Text.Trim()) Then
            MessageBox.Show("Please fill in all fields before updating a new section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con

            ' Check if the section already exists
            cmd.CommandText = "SELECT COUNT(*) FROM sections WHERE Section_Program = @sp AND Year = @yr AND Section_Code = @code AND SectionID != @SectionID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@sp", UCase(txtprogram.Text.Trim()))
            cmd.Parameters.AddWithValue("@yr", UCase(txtyear.Text.Trim()))
            cmd.Parameters.AddWithValue("@code", UCase(txtcode.Text.Trim()))
            cmd.Parameters.AddWithValue("@SectionID", txtsectionid.Text.Trim())
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("A section with the same program, year, and code already exists.", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' If the section doesn't exist, proceed with update
            cmd.CommandText = "UPDATE sections SET Section_Code=@SectionCode, Year=@Year, Section_Program=@SectionProgram WHERE SectionID=@SectionID"
            ' Set parameter values
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SectionID", txtsectionid.Text)
            cmd.Parameters.AddWithValue("@SectionCode", txtcode.Text)
            cmd.Parameters.AddWithValue("@Year", txtyear.Text)
            cmd.Parameters.AddWithValue("@SectionProgram", txtprogram.Text)


            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                SectionTable.Clear()
                GetSection()
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the provided Section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        ' Validate that all textboxes are filled
        If String.IsNullOrEmpty(txtcode.Text.Trim()) OrElse String.IsNullOrEmpty(txtyear.Text.Trim()) OrElse String.IsNullOrEmpty(txtprogram.Text.Trim()) Then
            MessageBox.Show("Please fill in all fields before inserting a new section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con

            ' Check if the section already exists
            cmd.CommandText = "SELECT COUNT(*) FROM sections WHERE Section_Program = @sp AND Year = @yr AND Section_Code = @code"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@sp", UCase(txtprogram.Text.Trim()))
            cmd.Parameters.AddWithValue("@yr", UCase(txtyear.Text.Trim()))
            cmd.Parameters.AddWithValue("@code", UCase(txtcode.Text.Trim()))
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("A section with the same program, year, and code already exists.", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' If the section doesn't exist, proceed with insertion
            cmd.CommandText = "INSERT INTO sections (Section_Program, Year, Section_Code) VALUES(@sp, @yr, @code)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@code", UCase(txtcode.Text))
            cmd.Parameters.AddWithValue("@yr", UCase(txtyear.Text))
            cmd.Parameters.AddWithValue("@sp", UCase(txtprogram.Text))

            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                SectionTable.Clear()
                GetSection()
                MessageBox.Show("Section saved successfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
            Else
                MessageBox.Show("Section save failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        Finally
            con.Close()
        End Try
    End Sub


    'Search
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim searchQuery As String = SearchTextBox.Text.Trim()

        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()

            ' Clone the structure of SectionTable
            For Each column As DataColumn In SectionTable.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            ' Specify which columns to search: Year, Section_Code, Section_Program
            Dim columnsToSearch As New List(Of String) From {"Year", "Section_Code", "Section_Program"}

            ' Iterate through each row in SectionTable
            For Each row As DataRow In SectionTable.Rows
                ' Iterate through each specified column for the current row
                For Each columnName As String In columnsToSearch
                    ' Check if the column value is not null and contains the search query (case-insensitive)
                    If row(columnName) IsNot DBNull.Value AndAlso row(columnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray) ' Add the entire row to filteredData
                        Exit For ' Move to the next row after a match is found
                    End If
                Next
            Next

            ' Bind the filtered data to the DataGridView
            DataGridView1.DataSource = filteredData
        Else
            ' If the search query is empty, display all data
            DataGridView1.DataSource = SectionTable
        End If
    End Sub




End Class
