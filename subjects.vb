Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SubjectForm


    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSubjects()
    End Sub

    Dim subjectTable As New DataTable

    Private Sub getSubjects()
        DBCon()
        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM subjects"
            table.Clear()
            dataReader.SelectCommand = cmd
            dataReader.Fill(subjectTable)


            dgvSubjectTable.DataSource = subjectTable

            dgvSubjectTable.Columns("SubjectID").Visible = False
            dgvSubjectTable.Columns("subject_description").HeaderText = "Description"
            dgvSubjectTable.Columns("subject_code").HeaderText = "Code"

            dgvSubjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvSubjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSubjectTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSubjectTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while retrieving subject information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dashboard.Show()
        Me.Close()

    End Sub


    Private Sub dgvSubjectTable_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectTable.CellClick

        Dim index = e.RowIndex
        If index >= 0 AndAlso index < dgvSubjectTable.Rows.Count Then
            Dim selectedRow = dgvSubjectTable.Rows(index)



            txtsubjectname.Text = selectedRow.Cells("subject_description").Value.ToString
            txtsubjectcode.Text = selectedRow.Cells("subject_code").Value.ToString
            txtsubjectid.Text = selectedRow.Cells("SubjectID").Value.ToString


        End If



    End Sub



    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        If txtsubjectcode.Text = "" Or txtsubjectname.Text = "" Then
            MessageBox.Show("Please fill in both the subject code and subject name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con
            ' Check if the new subject code or description already exists
            cmd.CommandText = "SELECT * FROM subjects WHERE subject_description = @description AND subject_code = @code"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@description", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Subject code or description already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If no duplicate found, proceed with the insertion
            cmd.CommandText = "INSERT INTO subjects (subject_description, subject_code) VALUES(@name, @code)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)

            If cmd.ExecuteNonQuery() > 0 Then

                MessageBox.Show("Subject inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshTable()
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
            Else
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Failed to insert subject. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting the subject. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            DBCon()
            cmd.Connection = con

            ' Check for duplicates excluding the current subject being updated
            cmd.CommandText = "SELECT COUNT(*) FROM subjects WHERE subject_description = @description AND subject_code = @code AND SubjectID <> @subjectID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@description", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)
            cmd.Parameters.AddWithValue("@subjectID", txtsubjectid.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Subject code or description already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Update the subject
            cmd.CommandText = "UPDATE subjects SET subject_description = @description, subject_code = @code WHERE SubjectID = @subjectID"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@description", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)
            cmd.Parameters.AddWithValue("@subjectID", txtsubjectid.Text)

            If cmd.ExecuteNonQuery() > 0 Then

                MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshTable()
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
                txtsubjectid.Clear()
            Else
                MessageBox.Show("No records were updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the subject. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If txtsubjectid.Text = "" Then
            MsgBox("Please select a row to delete.", MsgBoxStyle.Information, "Information")
            Return
        End If

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM subjects WHERE SubjectID = @subjectID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@subjectID", txtsubjectid.Text)

            If cmd.ExecuteNonQuery() > 0 Then

                MessageBox.Show("Subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshTable()
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
                txtsubjectid.Clear()
            Else
                MessageBox.Show("Delete failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the subject. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim searchQuery As String = txtsearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In subjectTable.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In subjectTable.Rows
                For Each column As DataColumn In subjectTable.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            dgvSubjectTable.DataSource = filteredData
        Else
            dgvSubjectTable.DataSource = subjectTable
        End If
    End Sub

    Private Sub refreshTable()
        Try
            subjectTable.Clear() ' Clear the existing data in the DataTable

            ' Fetch fresh data from the database and fill the DataTable
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM subjects"
            dataReader.SelectCommand = cmd
            dataReader.Fill(subjectTable)

            ' Set the DataGridView's DataSource to the updated DataTable
            dgvSubjectTable.DataSource = subjectTable

            ' Optionally, you can also reconfigure column settings here if needed
            dgvSubjectTable.Columns("SubjectID").Visible = False
            dgvSubjectTable.Columns("subject_description").HeaderText = "Description"
            dgvSubjectTable.Columns("subject_code").HeaderText = "Code"
            dgvSubjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvSubjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSubjectTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSubjectTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        Catch ex As Exception
            MessageBox.Show("Sorry, we encountered an error while refreshing the subject information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class