Public Class SubjectForm
    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSubjects()
    End Sub


    Private Sub getSubjects()
        DBCon()
        Try
            Dim subjectTable As New DataTable
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
        Me.Hide()

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
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO subjects (subject_description, subject_code) VALUES(@name, @code)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)


            If cmd.ExecuteNonQuery() > 0 Then
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Subject inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cmd.CommandText = "UPDATE subjects SET subject_description = @description, subject_code = @code WHERE SubjectID = @subjectID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@description", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)
            cmd.Parameters.AddWithValue("@subjectID", txtsubjectid.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
                txtsubjectid.Clear()
            Else
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsubjectcode.Clear()
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
                txtsubjectid.Clear()
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred while updating the subject. Please try again later..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM subjects WHERE SubjectID = @subjectID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@subjectID", txtsubjectid.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class