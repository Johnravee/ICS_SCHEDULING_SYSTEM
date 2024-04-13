Imports MySql.Data.MySqlClient

Public Class rfidandPinRegistrationforinstructors

    Dim fname, mname, lname, sufx, jobPosisyon, emailAdd, workStats, registeredRFID, PIN As String
    Dim imageFileData() As Byte
    Private Sub rfidandPinRegistrationforinstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rfidscanpanel.Dock = DockStyle.Fill
        pinloginregpanel.Dock = DockStyle.Fill

        'PinControlButton
        For Each ctrl As Control In pinloginregpanel.Controls

            ' Check if the control is a Button
            If TypeOf ctrl Is Button Then
                AddHandler ctrl.Click, AddressOf pinTextDisplay
            End If
        Next
        Dim result As DialogResult

        ' Show a message box with OK and Cancel buttons
        result = MessageBox.Show("Do you want to proceed on rfid?", "Confirmation", MessageBoxButtons.OKCancel)

        ' Check which button was clicked
        If result = DialogResult.Cancel Then
            pinloginregpanel.Show()
            rfidscanpanel.Hide()
            Return
        End If
        adminRegistration.Hide()
        txtRfidRegister.Focus()

    End Sub


    'Display text to PIN
    Private Sub pinTextDisplay(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(txtpin1.Text) Then
            txtpin1.Text = sender.Text
        ElseIf String.IsNullOrEmpty(txtpin2.Text) Then
            txtpin2.Text = sender.Text
        ElseIf String.IsNullOrEmpty(txtpin3.Text) Then
            txtpin3.Text = sender.Text
        ElseIf String.IsNullOrEmpty(txtpin4.Text) Then
            txtpin4.Text = sender.Text
            PIN = txtpin1.Text & txtpin2.Text & txtpin3.Text & txtpin4.Text
            InsertInstructorAccount()

        End If
    End Sub



    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles RFIDTIMER.Tick
        pinloginregpanel.Show()
        rfidscanpanel.Hide()
    End Sub

    Private Sub txtRfidRegister_TextChanged(sender As Object, e As EventArgs) Handles txtRfidRegister.TextChanged
        If txtRfidRegister.Text.Length = 10 Then
            registeredRFID = txtRfidRegister.Text
            ScanDoneLogo.Visible = True
            RFIDTIMER.Start()
        End If


    End Sub

    ' ayusin nalang yung pagaayos ng variables and procedures
    Public Sub instructorDataConstructor(firstName As String, middleName As String, lastName As String, suffix As String, role As String, email As String, workstatus As String)
        fname = firstName
        mname = middleName
        lname = lastName
        sufx = suffix
        emailAdd = email
        jobPosisyon = role
        workStats = workstatus
    End Sub

    Private Sub clearPinBtn_Click(sender As Object, e As EventArgs) Handles clearPinBtn.Click
        txtpin1.Text = ""
        txtpin2.Text = ""
        txtpin3.Text = ""
        txtpin4.Text = ""
        PIN = ""
    End Sub


    Private Sub InsertInstructorAccount()
        Try
            PIN = EncryptData(PIN)
            registeredRFID = EncryptData(registeredRFID)


            DBCon()

            If con.State = ConnectionState.Open Then
                If jobPosisyon = "INSTRUCTOR" Then
                    cmd.CommandText = "INSERT INTO instructor (PIN, RFID, Firstname, MiddleName, Surname, Suffix, Position, WorkStatus, email) VALUES (@pin, @rfid, @fname, @mname, @surname, @suffix, @position, @workstats, @email)"


                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.Parameters.AddWithValue("@pin", PIN)
                    cmd.Parameters.AddWithValue("@rfid", registeredRFID)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@mname", mname)
                    cmd.Parameters.AddWithValue("@surname", lname)
                    cmd.Parameters.AddWithValue("@suffix", sufx)
                    cmd.Parameters.AddWithValue("@position", jobPosisyon)
                    cmd.Parameters.AddWithValue("@workstats", workStats)
                    cmd.Parameters.AddWithValue("@email", emailAdd)



                    cmd.ExecuteNonQuery()
                    pinloginregpanel.Hide()
                    MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    addNewInstructor.Show()
                    con.Close()
                Else
                    cmd.CommandText = "INSERT INTO instructor (PIN, RFID, Firstname, MiddleName, Surname, Suffix, Position, WorkStatus, email) VALUES (@pin, @rfid, @fname, @mname, @surname, @suffix, @position, @workstats, @email)"


                    cmd.Parameters.Clear()
                    cmd.Connection = con
                    cmd.Parameters.AddWithValue("@pin", PIN)
                    cmd.Parameters.AddWithValue("@rfid", registeredRFID)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@mname", mname)
                    cmd.Parameters.AddWithValue("@surname", lname)
                    cmd.Parameters.AddWithValue("@suffix", sufx)
                    cmd.Parameters.AddWithValue("@position", jobPosisyon)
                    cmd.Parameters.AddWithValue("@workstats", workStats)
                    cmd.Parameters.AddWithValue("@email", emailAdd)



                    cmd.ExecuteNonQuery()
                    pinloginregpanel.Hide()
                    MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Authentication_Form.Show()
                    con.Close()
                End If
            Else
                MsgBox("Connection lost.")
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                If ex.Message.Contains("instructor_rfid_unique") Then
                    MessageBox.Show("Duplicate RFID! This RFID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BackToWhatForm()
                ElseIf ex.Message.Contains("instructor_email_unique") Then
                    MessageBox.Show("Duplicate email address! This email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BackToWhatForm()
                Else
                    MessageBox.Show("Duplicate entry error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BackToWhatForm()
                End If
            Else
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BackToWhatForm()
            End If

        Finally
            con.Close()
        End Try


    End Sub

    Private Sub BackToWhatForm()
        If jobPosisyon = "INSTRUCTOR" Then
            Me.Hide()
            addNewInstructor.Show()
        Else
            Me.Hide()
            adminRegistration.Show()

        End If
    End Sub


End Class
