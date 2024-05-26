Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Google.Protobuf.WellKnownTypes

Public Class sectionSched
    Dim Section As String
    Private Sub sectionSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Establish database connection
            DBCon()

            ' Retrieve the section from the viewSection form
            Section = viewSection.Section

            ' Set label text to display the section
            Label1.Text = $"SECTION: {Section}"


            cmd.Connection = con
            cmd.CommandText = "SELECT InstructorName, Section, Subject, CONCAT(TIME_FORMAT(StartTime, '%h:%i %p'),'-',TIME_FORMAT(EndTime, '%h:%i %p')) AS Time, Day, RoomNumber, Semester, Duration FROM schedules WHERE Section = @section ORDER BY DAYOFWEEK(day) ASC"

            ' Clear parameters and add the section parameter
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@section", Section)

            ' Fill data into a DataTable
            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)

            ' Bind data to the printing DataGridView
            printingdgv.DataSource = data

            ' Clear columns and add columns for each day of the week
            dgvSectionSched.Columns.Clear()
            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}
            For Each day As String In daysOfWeek
                dgvSectionSched.Columns.Add(day, day)
            Next

            ' Populate DataGridView with schedule data
            For Each row As DataRow In data.Rows
                Dim TimeDuration As String = row("Time")
                Dim day As String = row("Day").ToString().Trim()
                Dim instructor As String = row("InstructorName").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()
                Dim semester As String = row("Semester").ToString.Trim()
                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)

                ' Check if the day is valid and if the section is not empty
                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(Section) Then
                    Dim rowIndex As Integer = dgvSectionSched.Rows.Add()
                    Dim CellValue As String = $"Semester: {semester}" & vbCrLf & $"Time: {TimeDuration}" & vbCrLf & $"Instructor: {instructor}" & vbCrLf & $"Subject: {Subject}"
                    dgvSectionSched.Rows(rowIndex).Cells(columnIndex).Value = CellValue
                    dgvSectionSched.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Green
                End If
            Next

            ' Set DataGridView properties
            dgvSectionSched.AllowUserToAddRows = False
            dgvSectionSched.ReadOnly = True
            dgvSectionSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvSectionSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvSectionSched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvSectionSched.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            printingdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            printingdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            printingdgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            printingdgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            printingdgv.Columns("InstructorName").HeaderText = "Instructor"
            printingdgv.Columns("Subject").HeaderText = "Subject"
            printingdgv.Columns("Time").HeaderText = "Time"
            printingdgv.Columns("Day").HeaderText = "Day"
            printingdgv.Columns("RoomNumber").HeaderText = "Room"
            printingdgv.Columns("Semester").HeaderText = "Semester"
            printingdgv.Columns("Duration").HeaderText = "Duration"



        Catch ex As Exception

            MessageBox.Show("An error occurred while loading section schedule data. Please try again or contact support for assistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub


    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        viewSection.Show()
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

            e.Graphics.DrawString($"Section:", New Font("Calibri", 16, FontStyle.Bold), Brushes.Black, New PointF(85, 200), StrFormat)
            e.Graphics.DrawString("___________________________________________________________________", New Font("Calibri", 10, FontStyle.Regular), Brushes.Black, New PointF(350, 210), StrFormat)
            e.Graphics.DrawString(Section, New Font("Calibri", 16, FontStyle.Bold), Brushes.Black, New PointF(165, 203), StrFormat)

            Dim Format As New StringFormat(StringFormatFlags.LineLimit)
            Format.LineAlignment = StringAlignment.Center
            Format.Trimming = StringTrimming.EllipsisCharacter
            Format.Alignment = StringAlignment.Center


            Dim y As Integer = 230
            Dim x As Integer = 0
            Dim h As Integer = 0
            Dim recta As Rectangle
            Dim row As DataGridViewRow

            If isNewPage Then
                row = printingdgv.Rows(rowIndexToPrint)
                x = 53
                'Print Header Row
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then


                        recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.FillRectangle(Brushes.LightYellow, recta)
                        e.Graphics.DrawRectangle(Pens.Black, recta)

                        Dim headerText As String = ""
                        Select Case cell.ColumnIndex
                            Case 0
                                headerText = "Name"
                            Case 1
                                headerText = "Section"
                            Case 2
                                headerText = "Subject"
                            Case 3
                                headerText = "Time"
                            Case 4
                                headerText = "Day"
                            Case 5
                                headerText = "Room"
                            Case 6
                                headerText = "Semester"
                            Case 7
                                headerText = "Duration"
                        End Select

                        Dim centerHeaderFormat As New StringFormat(Format)
                        centerHeaderFormat.Alignment = StringAlignment.Center

                        e.Graphics.DrawString(headerText, New Font("Calibri", 14, FontStyle.Bold), Brushes.Black, recta, centerHeaderFormat)


                        x += recta.Width
                        h = Math.Max(h, recta.Height)

                    End If
                Next
                y += h
            End If

            isNewPage = False
            Dim dNow As Integer

            'Print Rows
            For dNow = rowIndexToPrint To printingdgv.RowCount - 1
                row = printingdgv.Rows(dNow)
                x = 53
                h = 0

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        recta = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, recta)

                        Format.Alignment = StringAlignment.Center
                        recta.Offset(5, 0)





                        e.Graphics.DrawString(cell.FormattedValue.ToString(), New Font("Calibri", 12, FontStyle.Regular), Brushes.Black, recta, Format)


                        x += recta.Width
                        h = Math.Max(h, recta.Height)
                    End If
                Next

                y += h

                rowIndexToPrint = dNow + 1
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




    'PRINT WHEN CLICK

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click

        If dgvSectionSched.Rows.Count <= 0 AndAlso printingdgv.Rows.Count <= 0 Then
            MessageBox.Show("Both the document and printing data are empty.", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        printer.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.WindowState = WindowState.Maximized
        PrintPreviewDialog1.Document = printer
        PrintPreviewDialog1.ShowDialog()
        printingdgv.DataSource = Nothing
        viewSection.Show()
        Me.Close()



    End Sub

    Private Sub ch_changeView_CheckedChanged(sender As Object, e As EventArgs) Handles ch_changeView.CheckedChanged
        If ch_changeView.Checked Then
            printingdgv.Visible = True
            dgvSectionSched.Visible = False
        Else
            printingdgv.Visible = False
            dgvSectionSched.Visible = True
        End If
    End Sub
End Class