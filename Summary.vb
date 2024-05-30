Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Summary
    Private WithEvents PrintDocument1 As New Printing.PrintDocument
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


            ' Define format for data
            Dim Format As New StringFormat(StringFormatFlags.LineLimit)
            Format.LineAlignment = StringAlignment.Center
            Format.Trimming = StringTrimming.EllipsisCharacter
            Format.Alignment = StringAlignment.Center

            Dim y As Integer = 230
            Dim x As Integer = 40 ' Start X position
            Dim h As Integer = 0
            Dim recta As Rectangle
            Dim row As DataGridViewRow

            ' Draw header row
            x = 40 ' Reset X position for header row
            For Each column As DataGridViewColumn In dgvschedsum.Columns
                If column.Visible Then
                    recta = New Rectangle(x, y, column.Width, dgvschedsum.ColumnHeadersHeight)
                    e.Graphics.FillRectangle(Brushes.LightGray, recta)
                    e.Graphics.DrawRectangle(Pens.Black, recta)

                    ' Use column header text
                    e.Graphics.DrawString(column.HeaderText, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, recta, Format)

                    x += recta.Width
                    h = Math.Max(h, recta.Height)
                End If
            Next

            y += h

            ' Print printingdgv data rows
            Dim rowsPerPage As Integer = CInt(e.MarginBounds.Height / dgvschedsum.Rows(0).Height)

            ' Print rows until the end of the page or there are no more rows
            While rowIndexToPrint < dgvschedsum.Rows.Count AndAlso y + h <= e.MarginBounds.Bottom
                Dim currentRow As DataGridViewRow = dgvschedsum.Rows(rowIndexToPrint)
                x = 40 ' Reset X position for each row
                h = 0

                For Each cell As DataGridViewCell In currentRow.Cells
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
                rowIndexToPrint += 1
            End While

            ' If there are more rows to print, set HasMorePages to true
            If rowIndexToPrint < dgvschedsum.Rows.Count Then
                e.HasMorePages = True
            Else
                ' Otherwise, no more rows to print, reset rowIndexToPrint
                rowIndexToPrint = 0
                e.HasMorePages = False
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while printing the schedule. Please try again or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ' Reset rowIndexToPrint when beginning to print
        rowIndexToPrint = 0
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
    End Sub

    'Private Sub PrintPreviewDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles PrintPreviewDialog.FormClosed
    '    ' Create a new instance of the form and show it again after the print preview dialog is closed
    '    Dim summaryForm As New Summary()
    '    summaryForm.Show()
    'End Sub

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



