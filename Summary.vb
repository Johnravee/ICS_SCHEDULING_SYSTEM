Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Summary
    Dim SummaryTable As New DataTable()

    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchedules()
    End Sub

    Private Sub GetSchedules()
        Try
            ' Establish database connection
            DBCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT InstructorName, Section, Subject, CONCAT(TIME_FORMAT(StartTime, '%h:%i %p'),'-',TIME_FORMAT(EndTime, '%h:%i %p')) AS Time, Day, RoomNumber, Semester, Duration FROM schedules ORDER BY  Section ASC"

            ' Fill data into SummaryTable DataTable
            dataReader.Fill(SummaryTable)


            ' Rename columns for better clarity
            SummaryTable.Columns("InstructorName").ColumnName = "Instructor"
            SummaryTable.Columns("Section").ColumnName = "Section"
            SummaryTable.Columns("Subject").ColumnName = "Subject"
            SummaryTable.Columns("Time").ColumnName = "Time"
            SummaryTable.Columns("Day").ColumnName = "Day"
            SummaryTable.Columns("RoomNumber").ColumnName = "Room"

            ' Bind data to DataGridViews
            dgvschedsum.DataSource = SummaryTable


            ' Set DataGridView properties for Summary Table
            dgvschedsum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvschedsum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvschedsum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvschedsum.DefaultCellStyle.WrapMode = DataGridViewTriState.True



        Catch ex As Exception

            MessageBox.Show("An error occurred while retrieving schedules. Please try again or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub





    Private rowIndexToPrint As Integer = 0 ' Track the index of the next row to print
    Private isNewPage As Boolean = True
    Private Sub printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printer.PrintPage
        Try
            Dim StrFormat As New StringFormat()
            StrFormat.Alignment = StringAlignment.Center

            Dim image1 As Image = My.Resources.cmdtransparent
            e.Graphics.DrawImage(image1, 60, 50, 100, 100)

            Dim Image2 As Image = My.Resources.icstransparent
            e.Graphics.DrawImage(Image2, 930, 35, 120, 120)




            e.Graphics.DrawString("Colegio De Montalban", New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, New PointF(570, 80), StrFormat)
            e.Graphics.DrawString("ICS Schedules", New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, New PointF(570, 100), StrFormat)

            e.Graphics.DrawString($"Summary of Schedules", New Font("Calibri", 16, FontStyle.Bold), Brushes.Black, New PointF(550, 200), StrFormat)


            Dim Format As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            Format.LineAlignment = StringAlignment.Center
            Format.Trimming = StringTrimming.EllipsisCharacter
            Format.Alignment = StringAlignment.Center

            Dim y As Integer = 300
            Dim x As Integer = 10
            Dim h As Integer = 0
            Dim recta As Rectangle
            Dim row As DataGridViewRow


            If isNewPage Then
                row = dgvschedsum.Rows(rowIndexToPrint)
                x = 40
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then

                        recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.FillRectangle(Brushes.LightYellow, recta)
                        e.Graphics.DrawRectangle(Pens.Black, recta)

                        e.Graphics.DrawString(dgvschedsum.Columns(cell.ColumnIndex).HeaderText, New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, recta, Format)

                        x += recta.Width

                        h = Math.Max(h, recta.Height)


                    End If
                Next
                y += h

            End If

            isNewPage = False
            Dim dplay As Integer
            For dplay = rowIndexToPrint To dgvschedsum.RowCount - 1
                row = dgvschedsum.Rows(dplay)
                x = 40
                h = 0

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, recta)

                        Format.Alignment = StringAlignment.Center
                        recta.Offset(5, 0)
                        e.Graphics.DrawString(cell.FormattedValue.ToString(), dgvschedsum.Font, Brushes.Black, recta, Format)

                        x += recta.Width
                        h = Math.Max(h, recta.Height)

                    End If
                Next

                y += h

                rowIndexToPrint = dplay + 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    isNewPage = True
                    Return
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("An error occurred while printing the schedule. Please try again or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub


    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click

        If dgvschedsum.Rows.Count <= 0 Then

            MessageBox.Show("Both the document and printing data are empty.", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        printer.DefaultPageSettings.Landscape = True
        PrintPreviewDialog.WindowState = WindowState.Maximized
        PrintPreviewDialog.Document = printer
        PrintPreviewDialog.ShowDialog()
        Me.Close()

    End Sub

    Private Sub PrintPreviewDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles PrintPreviewDialog.FormClosed
        ' Create a new instance of the form and show it again after the print preview dialog is closed
        Dim summaryForm As New Summary()
        summaryForm.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged


        Dim searchQuery As String = txtsearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim filteredData As New DataTable()
            For Each column As DataColumn In SummaryTable.Columns
                filteredData.Columns.Add(column.ColumnName, column.DataType)
            Next

            For Each row As DataRow In SummaryTable.Rows
                For Each column As DataColumn In SummaryTable.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(searchQuery.ToLower()) Then
                        filteredData.Rows.Add(row.ItemArray)
                        Exit For
                    End If
                Next
            Next

            dgvschedsum.DataSource = filteredData
        Else
            dgvschedsum.DataSource = SummaryTable
        End If

    End Sub


End Class



