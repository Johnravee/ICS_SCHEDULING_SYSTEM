Public Class viewInstructors
    Private originalButtonPositions As New Dictionary(Of Button, Point) ' Dictionary to store original button positions
    Dim startPositionX As Integer = 45
    Dim startPositionY As Integer = 10
    Dim buttonWidth As Integer = 300
    Dim buttonHeight As Integer = 100
    Dim buttonSpacingX As Integer = 10
    Dim buttonSpacingY As Integer = 10
    Dim buttonCountInRow As Integer = 0
    Dim currentRow As Integer = 0
    Dim roomsTable As New DataTable()
    Public Shared Instructor As String = ""

    Private Sub viewInstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT CONCAT(Firstname, ' ', Middlename, ' ', Surname) AS Instructor FROM instructor"
            dataReader.SelectCommand = cmd
            dataReader.Fill(roomsTable)


            For Each row As DataRow In roomsTable.Rows

                Dim btn As New Button()
                btn.Text = row("Instructor")
                btn.Size = New Size(buttonWidth, buttonHeight)
                btn.Font = New Font("Calibri", 20, Font.Style.Bold)


                Dim imageFilePath As String = "C:\Users\ravem\OneDrive\Desktop\ICS_SCHD\Resources\434394242_336699002727228_7171667631377081297_n (1).png"
                If System.IO.File.Exists(imageFilePath) Then
                    btn.Image = Image.FromFile(imageFilePath)
                    btn.ImageAlign = ContentAlignment.MiddleCenter ' Set image alignment to the left of the text
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText ' Position image before text

                End If



                Dim xCoordinate As Integer = startPositionX + (buttonWidth + buttonSpacingX) * buttonCountInRow
                Dim yCoordinate As Integer = startPositionY + (buttonHeight + buttonSpacingY) * currentRow


                btn.Location = New Point(xCoordinate, yCoordinate)
                originalButtonPositions.Add(btn, btn.Location)
                panelbtns.Controls.Add(btn)
                buttonCountInRow += 1

                If buttonCountInRow = 4 Then
                    currentRow += 1
                    buttonCountInRow = 0
                End If

                AddHandler btn.Click, AddressOf InstructorButton

            Next



        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub

    Private Sub InstructorButton(sender As Object, e As EventArgs)
        Instructor = sender.Text
        Me.Hide()
        instructorSched.Show()

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dashboard.Show()
        Me.Hide()
        txtsearch.Clear()

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim searchText As String = txtsearch.Text.Trim().ToLower()
        Dim buttonFound As Boolean = False
        Dim visibleButtonCount As Integer = 0 ' Track the number of visible buttons
        ' Define constants for button grid layout
        Dim buttonWidth As Integer = 100 ' Width of each button
        Dim buttonHeight As Integer = 30 ' Height of each button
        Dim horizontalSpacing As Integer = 200
        Dim verticalSpacing As Integer = 80
        Dim buttonsPerRow As Integer = Math.Max(panelbtns.Width \ (buttonWidth + horizontalSpacing), 1)

        For Each ctrl As Control In panelbtns.Controls
            If TypeOf ctrl Is Button Then
                Dim button As Button = CType(ctrl, Button)
                If searchText = "" OrElse button.Text.ToLower().Contains(searchText) Then
                    ' Show and position the button
                    button.Visible = True
                    buttonFound = True

                    ' Calculate row and column based on visibleButtonCount
                    Dim row As Integer = visibleButtonCount \ buttonsPerRow
                    Dim col As Integer = visibleButtonCount Mod buttonsPerRow

                    ' Calculate button position with spacing
                    Dim buttonX As Integer = col * (buttonWidth + horizontalSpacing) + 40
                    Dim buttonY As Integer = row * (buttonHeight + verticalSpacing) + 20

                    ' Set the button location
                    button.Location = New Point(buttonX, buttonY)

                    ' Increment visibleButtonCount
                    visibleButtonCount += 1
                Else

                    button.Visible = False
                End If
            End If
        Next

        If searchText = "" Then
            For Each btn As Button In originalButtonPositions.Keys
                btn.Location = originalButtonPositions(btn)
                btn.Visible = True
            Next
        End If


        If Not buttonFound AndAlso searchText <> "" Then
            MessageBox.Show("Button not found.")
        End If
    End Sub
End Class