Imports MySql.Data.MySqlClient

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
            txtcode.Text = selectedRow.Cells(3).Value.ToString()
            txtyear.Text = selectedRow.Cells(2).Value.ToString()
            txtprogram.Text = selectedRow.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
                SectionTable.Columns.Clear()
                SectionTable.Rows.Clear()
                GetSection()
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                MessageBox.Show("Record deleted successfully!")
                con.Close()
            Else
                MessageBox.Show("No record found with the provided Section.")
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "UPDATE sections SET Section_Code=@SectionCode, Year=@Year, Section_Program=@SectionProgram WHERE SectionID=@SectionID"
            ' Set parameter values
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SectionID", txtsectionid.Text)
            cmd.Parameters.AddWithValue("@SectionCode", txtcode.Text)
            cmd.Parameters.AddWithValue("@Year", txtyear.Text)
            cmd.Parameters.AddWithValue("@SectionProgram", txtprogram.Text)



            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                SectionTable.Columns.Clear()
                SectionTable.Rows.Clear()
                GetSection()
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the provided Section.")
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message)
        End Try

    End Sub

    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO sections (Section_Program, Year, Section_Code) VALUES(@sp, @yr, @code)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@code", UCase(txtcode.Text))
            cmd.Parameters.AddWithValue("@yr", UCase(txtyear.Text))
            cmd.Parameters.AddWithValue("@sp", UCase(txtprogram.Text))

            If cmd.ExecuteNonQuery() > 0 Then
                DataGridView1.DataSource = Nothing
                SectionTable.Columns.Clear()
                SectionTable.Rows.Clear()
                GetSection()
                MessageBox.Show("Section saved successfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()

            Else
                MessageBox.Show("Section saved failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprogram.Clear()
                txtcode.Clear()
                txtyear.Clear()
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    'Search
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim searchQuery As String = SearchTextBox.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In SectionTable.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In SectionTable.Rows
                For Each column As DataColumn In SectionTable.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            DataGridView1.DataSource = filteredData
        Else
            DataGridView1.DataSource = SectionTable
        End If
    End Sub
End Class
