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

            dgvSubjectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvSubjectTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSubjectTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dashboard.Show()
        Me.Hide()

    End Sub


    Private Sub dgvSubjectTable_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectTable.CellClick
        Dim SelectedRow = dgvSubjectTable.Rows(e.RowIndex)

        txtsubjectname.Text = SelectedRow.Cells("subject_name").Value.ToString
        txtsubjectcode.Text = SelectedRow.Cells("subject_code").Value.ToString
        txtsubjectid.Text = SelectedRow.Cells("SubjectID").Value.ToString
    End Sub



    Private Sub InsertBtn_Click(sender As Object, e As EventArgs) Handles InsertBtn.Click
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO subjects (subject_name, subject_code) VALUES(@name, @code)"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtsubjectname.Text)
            cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text)


            If cmd.ExecuteNonQuery() > 0 Then
                dgvSubjectTable.DataSource = Nothing
                getSubjects()
                MessageBox.Show("Insertion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
            Else
                MessageBox.Show("Insertion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "UPDATE subjects SET subject_name = @name, subject_code = @code WHERE SubjectID = @subjectID"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txtsubjectname.Text)
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
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message())
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
                MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsubjectcode.Clear()
                txtsubjectname.Clear()
                txtsubjectid.Clear()
            Else
                MessageBox.Show("Delete failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub


End Class