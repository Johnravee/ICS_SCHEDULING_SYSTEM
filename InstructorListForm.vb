
Public Class InstructorListForm

    Private Sub InstructorListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM instructor"
        cmd.ExecuteNonQuery()
        dataReader.Fill(table)

        DataGridView1.DataSource = table



        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()

    End Sub

End Class