Public Class sectionSched
    Private Sub sectionSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Dim Section As String = viewSection.Section
        Try

            Label1.Text = $"ROOM :{Section}"
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE Section = @section"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@section", Section)


            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)


            dgvSectionSched.Columns.Clear()

            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}

            For Each day As String In daysOfWeek
                dgvSectionSched.Columns.Add(day, day)
            Next


            For Each row As DataRow In data.Rows
                Dim day As String = row("Day").ToString().Trim()

                Dim instructor As String = row("InstructorName").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()

                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)


                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(section) Then

                    Dim rowIndex As Integer = dgvSectionSched.Rows.Add()

                    Dim CellValue As String = $"Instructor: {instructor}" & vbCrLf & $"Subject: {Subject}"


                    dgvSectionSched.Rows(rowIndex).Cells(columnIndex).Value = CellValue
                    dgvSectionSched.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Green
                End If
            Next

            ' Set DataGridView properties
            dgvSectionSched.AllowUserToAddRows = False
            dgvSectionSched.ReadOnly = True

            dgvSectionSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvSectionSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvSectionSched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSectionSched.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvSectionSched.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvSectionSched.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        viewSection.Show()
    End Sub
End Class