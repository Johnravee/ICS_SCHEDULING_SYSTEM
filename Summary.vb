Public Class Summary
    Dim SummaryTable As New DataTable()
    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchedules()
    End Sub

    Private Sub GetSchedules()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT InstructorName, Section, Subject,CONCAT(TIME_FORMAT(StartTime, '%h:%i %p'),'-',TIME_FORMAT(EndTime, '%h:%i %p')) AS Time, Day, RoomNumber FROM schedules ORDER BY InstructorName, DAYOFWEEK(day)"

            dataReader.Fill(SummaryTable)

            SummaryTable.Columns("InstructorName").ColumnName = "Instructor"
            SummaryTable.Columns("Section").ColumnName = "Section"
            SummaryTable.Columns("Subject").ColumnName = "Subject"
            SummaryTable.Columns("Time").ColumnName = "Time"
            SummaryTable.Columns("Day").ColumnName = "Day"
            SummaryTable.Columns("RoomNumber").ColumnName = "Room"

            dgvschedsum.DataSource = SummaryTable
            printingdgv.DataSource = SummaryTable
            dgvschedsum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvschedsum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvschedsum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvschedsum.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            printingdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            printingdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            printingdgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            printingdgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub




    Private rowIndexToPrint As Integer = 0 ' Track the index of the next row to print
    Private isNewPage As Boolean = True
    Private Sub printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printer.PrintPage
        Dim StrFormat As New StringFormat()
        StrFormat.Alignment = StringAlignment.Center

        Dim image1 As Image = Image.FromFile("C:\Users\ravem\OneDrive\Desktop\ICS_SCHEDULING_SYSTEM\Resources\cmdtransparent.png")
        e.Graphics.DrawImage(image1, 60, 50, 100, 100)

        Dim Image2 As Image = Image.FromFile("C:\Users\ravem\OneDrive\Desktop\ICS_SCHEDULING_SYSTEM\Resources\icstransparent.png")
        e.Graphics.DrawImage(Image2, 930, 35, 120, 120)




        e.Graphics.DrawString("Colegio De Montalban", New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, New PointF(570, 80), StrFormat)
        e.Graphics.DrawString("ICS Schedules", New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, New PointF(570, 100), StrFormat)

        e.Graphics.DrawString($"Summary of Schedules", New Font("Calibri", 16, FontStyle.Bold), Brushes.Black, New PointF(550, 200), StrFormat)


        Dim Format As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        Format.LineAlignment = StringAlignment.Center
        Format.Trimming = StringTrimming.EllipsisCharacter
        Format.Alignment = StringAlignment.Center

        Dim y As Integer = 300
        Dim x As Integer = 150
        Dim h As Integer = 0
        Dim recta As Rectangle
        Dim row As DataGridViewRow


        If isNewPage Then
            row = printingdgv.Rows(rowIndexToPrint)
            x = 150
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then

                    recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightYellow, recta)
                    e.Graphics.DrawRectangle(Pens.Black, recta)

                    e.Graphics.DrawString(printingdgv.Columns(cell.ColumnIndex).HeaderText, New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, recta, Format)

                    x += recta.Width

                    h = Math.Max(h, recta.Height)


                End If
            Next
            y += h

        End If

        isNewPage = False
        Dim dplay As Integer
        For dplay = rowIndexToPrint To printingdgv.RowCount - 1
            row = printingdgv.Rows(dplay)
            x = 150
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, recta)

                    Format.Alignment = StringAlignment.Center
                    recta.Offset(5, 0)
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), printingdgv.Font, Brushes.Black, recta, Format)

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





    End Sub


    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click

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
End Class



