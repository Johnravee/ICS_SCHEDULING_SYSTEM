
Public Class viewRooms
    Private originalButtonPositions As New Dictionary(Of Button, Point) ' Dictionary to store original button positions
    Dim startPositionX As Integer = 30
    Dim startPositionY As Integer = 10
    Dim buttonWidth As Integer = 200
    Dim buttonHeight As Integer = 100
    Dim buttonSpacingX As Integer = 10
    Dim buttonSpacingY As Integer = 10
    Dim buttonCountInRow As Integer = 0
    Dim currentRow As Integer = 0
    Dim roomsTable As New DataTable()
    Public Shared ClickRoomNumber As String = ""



    Public Sub GetRooms()
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT Room FROM rooms ORDER BY Room ASC"
            dataReader.SelectCommand = cmd
            dataReader.Fill(roomsTable)


            For Each row As DataRow In roomsTable.Rows

                Dim btn As New Button()
                btn.Text = row("Room")
                btn.Size = New Size(buttonWidth, buttonHeight)
                btn.Font = New Font("Calibri", 20, Font.Style.Bold)


                Dim roomImage As Image = My.Resources.room40



                If roomImage IsNot Nothing Then
                    btn.Image = roomImage
                    btn.ImageAlign = ContentAlignment.MiddleRight
                    ' Set image alignment to the left of the text
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText ' Position image before text

                End If



                Dim xCoordinate As Integer = startPositionX + (buttonWidth + buttonSpacingX) * buttonCountInRow
                Dim yCoordinate As Integer = startPositionY + (buttonHeight + buttonSpacingY) * currentRow


                btn.Location = New Point(xCoordinate, yCoordinate)
                originalButtonPositions.Add(btn, btn.Location)
                panelbtns.Controls.Add(btn)
                buttonCountInRow += 1

                If buttonCountInRow = 6 Then
                    currentRow += 1
                    buttonCountInRow = 0
                End If

                AddHandler btn.Click, AddressOf RoomButton

            Next



        Catch ex As Exception
            MessageBox.Show("An error occurred while loading instructor data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RoomButton(sender As Object, e As EventArgs)
        ClickRoomNumber = sender.Text
        roomSchedule.Show()
        Me.Hide()

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dashboard.Show()
        Me.Close()
        txtsearch.Clear()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim searchText As String = txtsearch.Text.Trim().ToLower()

        Dim visibleButtonCount As Integer = 0 ' Track the number of visible buttons
        ' Define constants for button grid layout
        Dim buttonWidth As Integer = 100 ' Width of each button
        Dim buttonHeight As Integer = 30 ' Height of each button
        Dim horizontalSpacing As Integer = 105
        Dim verticalSpacing As Integer = 10
        Dim buttonsPerRow As Integer = Math.Max(panelbtns.Width \ (buttonWidth + horizontalSpacing), 1)

        For Each ctrl As Control In panelbtns.Controls
            If TypeOf ctrl Is Button Then
                Dim button As Button = CType(ctrl, Button)
                If searchText = "" OrElse button.Text.ToLower().Contains(searchText) Then
                    ' Show and position the button
                    button.Visible = True


                    ' Calculate row and column based on visibleButtonCount
                    Dim row As Integer = visibleButtonCount \ buttonsPerRow
                    Dim col As Integer = visibleButtonCount Mod buttonsPerRow

                    ' Calculate button position with spacing
                    Dim buttonX As Integer = col * (buttonWidth + horizontalSpacing) + 40
                    Dim buttonY As Integer = row * (buttonHeight + verticalSpacing * 9) + 20

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


    End Sub
End Class