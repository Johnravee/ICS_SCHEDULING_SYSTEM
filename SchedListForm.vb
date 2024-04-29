Public Class SchedListForm
    Private Sub SchedListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM instructor"
        cmd.ExecuteNonQuery()
        dataReader.Fill(table)
        dgv.DataSource = table

        dgv.Columns("instructorID").Visible = False

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader

        dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()
    End Sub


End Class