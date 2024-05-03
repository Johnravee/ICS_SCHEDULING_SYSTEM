Imports MySql.Data.MySqlClient

Public Class ScanRFIDLOGIN
    Private Sub ScanRFIDLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtrfidlogin.Focus()

    End Sub
    Private Sub ScanRFIDLOGIN_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            txtrfidlogin.Focus()

        End If
    End Sub

    'Scanner
    Private Sub txtrfid_TextChanged(sender As Object, e As EventArgs) Handles txtrfidlogin.TextChanged
        If txtrfidlogin.Text.Length >= 10 Then
            Dim encryptedRFID = EncryptData(txtrfidlogin.Text)

            If Authentication(encryptedRFID) Then
                clearinputtimer.Start()
                Dashboard.Show()
                Me.Hide()
                txtrfidlogin.Focus()
            End If
        End If
    End Sub



    ' Input Dialog
    Private Sub rfidlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles rfidlink.LinkClicked
        txtrfidlogin.Focus()
        Dim RfidInput As String = InputBox("Please enter your RFID number:", "Input Dialog").Trim()
        If Not String.IsNullOrWhiteSpace(RfidInput) Then
            Dim encryptedRFID = EncryptData(RfidInput)

            If Authentication(encryptedRFID) Then
                clearinputtimer.Start()
                Dashboard.Show()
                Me.Hide()

            End If
        End If
    End Sub

    'Authenticate user
    Private Function Authentication(data As String) As Boolean
        Try
            DBCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM instructor WHERE RFID = @rfid AND Position IN ('DEAN', 'BSIT PROGRAM HEAD', 'BScPE PROGRAM HEAD' )"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@rfid", data)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                con.Close()
                Return True
            Else
                con.Close()
                txtrfidlogin.Clear()
                txtrfidlogin.Focus()
                Scan_Denied_Logo.Visible = True
                ScanRFID_Logo.Visible = False
                hidelogos.Start()
                Return False
            End If
        Catch ex As Exception
            MsgBox("Sorry, there was a problem with the authentication process. Please try again.", MsgBoxStyle.Exclamation, "Authentication Error")
            con.Close()
            txtrfidlogin.Clear()
            txtrfidlogin.Focus()
            Scan_Denied_Logo.Visible = True
            ScanRFID_Logo.Visible = False
            hidelogos.Start()
            Return False
        End Try
    End Function



    'Show InputDialog
    Private Sub lk1register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lk1register.LinkClicked
        txtrfidlogin.Focus()
        adminRegistration.Show()
        Me.Hide()

    End Sub

    'Timer to clear input
    Private Sub clearinputtimer_Tick(sender As Object, e As EventArgs) Handles clearinputtimer.Tick
        txtrfidlogin.Clear()
        txtrfidlogin.Focus()
        clearinputtimer.Stop()
    End Sub

    'Close Program
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()

    End Sub

    Private Sub hidelogos_Tick(sender As Object, e As EventArgs) Handles hidelogos.Tick
        Scan_Denied_Logo.Visible = False
        ScanRFID_Logo.Visible = True
        hidelogos.Stop()
    End Sub
End Class