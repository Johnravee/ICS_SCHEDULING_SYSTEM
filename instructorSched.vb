Public Class instructorSched
    Dim instructor As String

    Private Sub instructorSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        instructor = viewInstructors.Instructor
        Try

            Label1.Text = $"Instructor :{instructor}"
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM schedules WHERE InstructorName = @instructor ORDER BY StartTime"

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@instructor", instructor)


            Dim data As New DataTable()
            dataReader.SelectCommand = cmd
            dataReader.Fill(data)

            printingdgv.DataSource = data
            printingdgv.Columns("ScheduleID").Visible = False

            dgvInstructorSched.Columns.Clear()




            Dim daysOfWeek As String() = {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"}

            For Each day As String In daysOfWeek
                dgvInstructorSched.Columns.Add(day, day)
            Next


            For Each row As DataRow In data.Rows

                Dim startTime As DateTime = DateTime.Parse(row("StartTime").ToString())
                Dim endTime As DateTime = DateTime.Parse(row("EndTime").ToString())

                Dim formattedStartTime As String = startTime.ToString("hh:mm tt")
                Dim formattedEndTime As String = endTime.ToString("hh:mm tt")

                Dim TimeDuration As String = formattedStartTime & " - " & formattedEndTime
                Dim day As String = row("Day").ToString().Trim()
                Dim Subject As String = row("Subject").ToString().Trim()
                Dim roomNumber As String = row("RoomNumber").ToString().Trim()


                Dim columnIndex As Integer = Array.IndexOf(daysOfWeek, day)


                If columnIndex <> -1 AndAlso Not String.IsNullOrEmpty(instructor) Then

                    Dim rowIndex As Integer = dgvInstructorSched.Rows.Add()

                    Dim CellValue As String = $"Time: {TimeDuration}" & vbCrLf & $"Day: {day}" & vbCrLf & $"Room: {roomNumber}" & vbCrLf & $"Subject: {Subject}"


                    dgvInstructorSched.Rows(rowIndex).Cells(columnIndex).Value = CellValue
                    dgvInstructorSched.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Green
                End If
            Next

            ' Set DataGridView properties
            dgvInstructorSched.AllowUserToAddRows = False
            dgvInstructorSched.ReadOnly = True

            dgvInstructorSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            dgvInstructorSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvInstructorSched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvInstructorSched.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgvInstructorSched.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvInstructorSched.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        viewInstructors.Show()

    End Sub

    Private Sub printer_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printer.PrintPage
        Dim style As New StringFormat
        style.Alignment = StringAlignment.Center


        Dim printArea As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)


        Dim logo1 As Image = Image.FromFile("C:\Users\ravem\OneDrive\Desktop\ICS_SCHD\Resources\cmdtransparent.png")
        Dim scaledLogo1 As New Bitmap(80, 80)
        Using g As Graphics = Graphics.FromImage(scaledLogo1)
            g.DrawImage(logo1, New Rectangle(0, 0, 80, 80))
        End Using


        Dim logoRect1 As New RectangleF(printArea.Left, printArea.Top, scaledLogo1.Width, scaledLogo1.Height)
        e.Graphics.DrawImage(scaledLogo1, logoRect1)


        Dim logo2 As Image = Image.FromFile("C:\Users\ravem\OneDrive\Desktop\ICS_SCHD\Resources\icstransparent.png")
        Dim scaledLogo2 As New Bitmap(100, 100)
        Using g As Graphics = Graphics.FromImage(scaledLogo2)
            g.DrawImage(logo2, New Rectangle(0, 0, 100, 100))
        End Using

        Dim logoRect2 As New RectangleF(printArea.Right - 100, printArea.Top, 100, 100)
        e.Graphics.DrawImage(scaledLogo2, logoRect2)


        Dim textFont As New Font("Calibri", 12, FontStyle.Bold)
        Dim text As String = "Colegio De Montalban"
        Dim textSize As SizeF = e.Graphics.MeasureString(text, textFont)
        Dim textRect As New RectangleF((logoRect1.Right + logoRect2.Left - textSize.Width) / 2, logoRect1.Bottom + 10, textSize.Width, textSize.Height)
        e.Graphics.DrawString(text, textFont, Brushes.Black, textRect, style)


        text = "Institute of Computer Studies Schedule"
        textSize = e.Graphics.MeasureString(text, textFont)
        textRect = New RectangleF((logoRect1.Right + logoRect2.Left - textSize.Width) / 2, textRect.Bottom + 5, textSize.Width, textSize.Height)
        e.Graphics.DrawString(text, textFont, Brushes.Black, textRect, style)

        ' Print the header
        Dim instructorHeaderText As String = $"Instructor name: {instructor}"
        Dim headerFont As New Font("Calibri", 14, FontStyle.Bold)
        Dim headerSize As SizeF = e.Graphics.MeasureString(instructorHeaderText, headerFont)
        Dim headerRect As New RectangleF(printArea.Left, textRect.Bottom + 10, printArea.Width, headerSize.Height)
        e.Graphics.DrawString(instructorHeaderText, headerFont, Brushes.Black, headerRect, style)

        ' Calculate the size and position of each cell
        Dim columnWidths As New List(Of Single)
        Dim columnPositions As New List(Of Single)
        Dim totalWidth As Single = 0
        For Each column As DataGridViewColumn In printingdgv.Columns
            If Not column.Name.Equals("ScheduleID", StringComparison.OrdinalIgnoreCase) Then
                ' Skip the "ScheduleID" column
                Dim columnWidth As Single = column.Width / printingdgv.Width * printArea.Width
                columnWidths.Add(columnWidth)
                columnPositions.Add(totalWidth)
                totalWidth += columnWidth
            End If
        Next

        Dim yPos As Single = headerRect.Bottom + 10
        Dim rowHeight As Single = printingdgv.Rows(0).Height / printingdgv.Height * printArea.Height

        ' Calculate the starting position to center the table horizontally
        Dim startX As Single = e.MarginBounds.Left + (e.MarginBounds.Width - totalWidth) / 2

        ' Print the column headers
        Dim headerBrush As New SolidBrush(Color.Black)
        For columnIndex As Integer = 0 To columnWidths.Count - 1
            ' Skip the "ScheduleID" column
            If Not printingdgv.Columns(columnIndex).Name.Equals("ScheduleID", StringComparison.OrdinalIgnoreCase) Then
                Dim columnHeader As String
                Select Case printingdgv.Columns(columnIndex).HeaderText
                    Case "InstructorName"
                        columnHeader = "Name"
                    Case "Section"
                        columnHeader = "Section"
                    Case "Subject"
                        columnHeader = "Subject"
                    Case "StartTime"
                        columnHeader = "Start"
                    Case "EndTime"
                        columnHeader = "End"
                    Case "RoomNumber"
                        columnHeader = "Room #"
                    Case Else
                        columnHeader = printingdgv.Columns(columnIndex).HeaderText
                End Select

                Dim cellRect As New RectangleF(startX + columnPositions(columnIndex), yPos, columnWidths(columnIndex), rowHeight)
                e.Graphics.FillRectangle(Brushes.LightGray, cellRect)
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(cellRect))
                ' Draw the header text centered in the cell
                Dim headerTextRect As New RectangleF(cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height)
                e.Graphics.DrawString(columnHeader, headerFont, headerBrush, headerTextRect, style)
            End If
        Next

        ' Move to the next row
        yPos += rowHeight

        ' Print the DataGridView content
        For rowIndex As Integer = 0 To printingdgv.Rows.Count - 1
            Dim xPos As Single = startX
            For columnIndex As Integer = 0 To columnWidths.Count - 1
                ' Skip the "ScheduleID" column
                If Not printingdgv.Columns(columnIndex).Name.Equals("ScheduleID", StringComparison.OrdinalIgnoreCase) Then
                    Dim cellValue As String = printingdgv.Rows(rowIndex).Cells(columnIndex).FormattedValue.ToString()

                    ' Check if the cell belongs to the "StartTime" or "EndTime" column
                    If printingdgv.Columns(columnIndex).Name = "StartTime" OrElse printingdgv.Columns(columnIndex).Name = "EndTime" Then
                        ' Check if the cell value is empty or not in a valid datetime format
                        If Not String.IsNullOrEmpty(cellValue) AndAlso DateTime.TryParse(cellValue, Nothing) Then
                            ' Convert the time to 12-hour format
                            Dim timeValue As DateTime = DateTime.Parse(cellValue)
                            cellValue = timeValue.ToString("hh:mm tt")
                        End If
                    End If

                    Dim cellRect As New RectangleF(startX + columnPositions(columnIndex), yPos, columnWidths(columnIndex), rowHeight)
                    e.Graphics.FillRectangle(Brushes.White, cellRect)
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(cellRect))
                    ' Draw the cell value centered in the cell
                    Dim cellTextRect As New RectangleF(cellRect.Left, cellRect.Top, cellRect.Width, cellRect.Height)
                    e.Graphics.DrawString(cellValue, printingdgv.Font, Brushes.Black, cellTextRect, style)
                    xPos += columnWidths(columnIndex)
                End If
            Next
            ' Move to the next row
            yPos += rowHeight
        Next

        ' Check if there are more pages to print
        e.HasMorePages = False ' Set to True if more pages are needed
    End Sub








    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printer.DefaultPageSettings.Landscape = True
        printer.Print()
    End Sub


End Class