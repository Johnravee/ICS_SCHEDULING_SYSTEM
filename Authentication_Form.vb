Imports MySql.Data.MySqlClient

Public Class Authentication_Form
    Dim inputedEmail, inputedPin, inputedRfid As String
    Dim EncryptedRfid As String
    Dim EncryptedPin As String


    Private Sub Authentication_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBCon()
        Scan_AuthForm.Dock = DockStyle.Fill
        ManualLoginForm.Dock = DockStyle.Fill
        PinLoginForm.Dock = DockStyle.Fill

        For Each btn As Control In PinLoginForm.Controls
            If TypeOf btn Is Button Then
                AddHandler btn.Click, AddressOf PinDisplay
            End If
        Next

    End Sub
    Private Sub Scan_AuthForm_Paint(sender As Object, e As PaintEventArgs) Handles Scan_AuthForm.Paint
        RFIDBOX_Scan.Focus()
    End Sub

    Private Sub ManualLogin_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ManualLogin_Link.LinkClicked

        Scan_AuthForm.Hide()
        ManualLoginForm.Show()
    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        RFIDBOX_Scan.Text = ""
    End Sub

    Private Sub RFIDBOX_Scan_TextChanged(sender As Object, e As EventArgs) Handles RFIDBOX_Scan.TextChanged
        If RFIDBOX_Scan.Text.Length = 10 Then
            PinLoginForm.Show()
            Scan_AuthForm.Hide()
            timer.Start()
        End If
    End Sub



    Private Sub lk1register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk1register.LinkClicked
        adminRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub lk2register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk2register.LinkClicked
        adminRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try


            If EmailValidation(txtEmail.Text) Then
                inputedEmail = txtEmail.Text
                PinLoginForm.Show()
                ManualLoginForm.Hide()
            Else
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ManualLoginForm.Show()
            End If


        Catch ex As Exception
            MsgBox("An error occurred: " & ex.ToString())
        End Try
    End Sub


    Private Sub PinDisplay(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(txtpin1.Text) Then
            txtpin1.Text = sender.Text
        ElseIf String.IsNullOrEmpty(txtpin2.Text) Then
            txtpin2.Text = sender.Text
        ElseIf String.IsNullOrEmpty(txtpin3.Text) Then
            txtpin3.Text = sender.Text
        Else
            txtpin4.Text = sender.Text
            inputedPin = txtpin1.Text & txtpin2.Text & txtpin3.Text & txtpin4.Text


            If String.IsNullOrEmpty(RFIDBOX_Scan.Text) Then
                EmailWithPinAuth()
            Else
                RfidWithPinAuth()
            End If


        End If
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        inputedPin = ""
        txtpin1.Clear()
        txtpin2.Clear()
        txtpin3.Clear()
        txtpin4.Clear()
    End Sub


    Private Sub RfidWithPinAuth()
        inputedPin = EncryptData(inputedPin)
        inputedRfid = EncryptData(RFIDBOX_Scan.Text)

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM instructor WHERE RFID = @rfid AND PIN = @pin"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@rfid", inputedRfid)
            cmd.Parameters.AddWithValue("@pin", inputedPin)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                'pass data to userData.vb
                SaveUserData(reader("InstructorID"))
                clearInputs.Start()
                Dashboard.Show()
                Me.Hide()



            Else
                MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearInputs.Start()
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.ToString())
        End Try
    End Sub

    Private Sub EmailWithPinAuth()

        EncryptedPin = EncryptData(inputedPin)

        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM instructor WHERE email = @email AND PIN = @pin"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", inputedEmail)
            cmd.Parameters.AddWithValue("@pin", EncryptedPin)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                'pass data to userData.vb
                SaveUserData(reader("InstructorID"))
                clearInputs.Start()
                Dashboard.Show()
                Me.Hide()


            Else
                MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearInputs.Start()
            End If

            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.ToString())
        End Try
    End Sub

    Private Sub clearInputs_Tick(sender As Object, e As EventArgs) Handles clearInputs.Tick
        txtEmail.Clear()
        RFIDBOX_Scan.Clear()
        inputedEmail = ""
        inputedPin = ""
        inputedRfid = ""
        inputedPin = ""
        txtpin1.Clear()
        txtpin2.Clear()
        txtpin3.Clear()
        txtpin4.Clear()
        ManualLoginForm.Hide()
        PinLoginForm.Hide()
        Scan_AuthForm.Show()
        clearInputs.Stop()

    End Sub


    'ForgotPins need logic


    Private Sub Forgot_PIN_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Forgot_PIN_Link.LinkClicked

    End Sub

    Private Sub lkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkForgot.LinkClicked

    End Sub

    Private Sub ScanClose_Click(sender As Object, e As EventArgs) Handles ScanClose.Click
        Me.Close()
    End Sub

    Private Sub ScanMinimize_Click(sender As Object, e As EventArgs) Handles ScanMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class

