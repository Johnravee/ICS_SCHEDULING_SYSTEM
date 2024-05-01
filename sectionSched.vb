Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Class sectionSched
    Dim Section As String
    Private Sub sectionSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Section = viewSection.Section

        Try

            Label1.Text = $"ROOM :{Section}"
            cmd.Connection = con
            cmd.CommandText = "SELECT InstructorName, Section, Subject,CONCAT(TIME_FORMAT(StartTime, '%h:%i %p'),'-',TIME_FORMAT(EndTime, '%h:%i %p')) AS Time, Day, RoomNumber  FROM schedules WHERE Section = @section ORDER BY DAYOFWEEK(day) ASC"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@section", Section)


            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)



            printingdgv.DataSource = data


            dgvSectionSched.Columns.Clear()

            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}

            For Each day As String In daysOfWeek
                dgvSectionSched.Columns.Add(day, day)
            Next


            For Each row As DataRow In data.Rows
                Dim TimeDuration As String = row("Time")
                Dim day As String = row("Day").ToString().Trim()
                Dim instructor As String = row("InstructorName").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()

                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)


                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(Section) Then

                    Dim rowIndex As Integer = dgvSectionSched.Rows.Add()

                    Dim CellValue As String = $"Time: {TimeDuration}" & vbCrLf & $"Instructor: {instructor}" & vbCrLf & $"Subject: {Subject}"


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


    Private rowIndexToPrint As Integer = 0 ' Track the index of the next row to print
    Private isNewPage As Boolean = True

    Private Sub printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printer.PrintPage
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
    End Sub






    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        printer.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.WindowState = WindowState.Maximized
        PrintPreviewDialog1.Document = printer
        PrintPreviewDialog1.ShowDialog()
        printingdgv.DataSource = Nothing
        viewSection.Show()
        Me.Close()



    End Sub


End Class