Imports MySql.Data.MySqlClient

Public Class RFIDREGISTRATION

    Dim fname, mname, lname, sufx, jobPosisyon, emailAdd, workStats, registeredRFID, Gender As String
    Private Sub rfidandPinRegistrationforinstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rfidscanpanel.Dock = DockStyle.Fill
        txtRfidRegister.Focus()
        imgloading.Visible = False
        imgsuccess.Visible = False
        imgerror.Visible = False
        ScanRFID_Logo.Visible = True
        lblredirect.Visible = False
        lblsuccess.Visible = False
        lblemailerror.Visible = False
        lblrfiderror.Visible = False
        lblduplicateentry.Visible = False
        lblunxerror.Visible = False
    End Sub







    Private Sub txtRfidRegister_TextChanged(sender As Object, e As EventArgs) Handles txtRfidRegister.TextChanged
        If txtRfidRegister.Text.Length = 10 Then
            registeredRFID = txtRfidRegister.Text
            InsertInstructorAccount()


        End If


    End Sub

    ' ayusin nalang yung pagaayos ng variables and procedures
    Public Sub instructorDataConstructor(firstName As String, middleName As String, lastName As String, role As String, email As String, workstatus As String, gnder As String)
        fname = ReplaceSpecialCharacters(firstName)
        mname = ReplaceSpecialCharacters(middleName)
        lname = ReplaceSpecialCharacters(lastName)
        emailAdd = email
        jobPosisyon = ReplaceSpecialCharacters(role)
        workStats = ReplaceSpecialCharacters(workstatus)
        Gender = ReplaceSpecialCharacters(gnder)
    End Sub




    Private Sub InsertInstructorAccount()
        Try

            registeredRFID = EncryptData(registeredRFID)


            DBCon()

            If con.State = ConnectionState.Open Then

                cmd.CommandText = "INSERT INTO instructor (RFID, Firstname, MiddleName, Surname, Gender, Position, WorkStatus, email) VALUES (@rfid, @fname, @mname, @surname, @gender,@position, @workstats, @email)"


                cmd.Parameters.Clear()
                cmd.Connection = con

                cmd.Parameters.AddWithValue("@rfid", registeredRFID)
                cmd.Parameters.AddWithValue("@fname", UCase(fname))
                cmd.Parameters.AddWithValue("@mname", UCase(mname))
                cmd.Parameters.AddWithValue("@surname", UCase(lname))

                cmd.Parameters.AddWithValue("@position", UCase(jobPosisyon))
                cmd.Parameters.AddWithValue("@workstats", UCase(workStats))
                cmd.Parameters.AddWithValue("@email", emailAdd)
                cmd.Parameters.AddWithValue("@gender", UCase(Gender))






                If cmd.ExecuteNonQuery() > 0 Then
                    ScanRFID_Logo.Visible = False
                    imgsuccess.Visible = True
                    lblsuccess.Visible = True
                    createdsuccesstimer.Start()
                    redirectionTimer.Start()



                End If


                con.Close()
            End If


        Catch ex As MySqlException
            If ex.Number = 1062 Then
                If ex.Message.Contains("instructor_rfid_unique") Then
                    imgerror.Visible = True
                    lblrfiderror.Visible = True
                    backtoregistrationTimer.Start()

                ElseIf ex.Message.Contains("instructor_email_unique") Then
                    imgerror.Visible = True
                    lblemailerror.Visible = True
                    backtoregistrationTimer.Start()
                Else
                    imgerror.Visible = True
                    lblduplicateentry.Visible = True
                    backtoregistrationTimer.Start()
                End If
            Else
                imgerror.Visible = True
                lblunxerror.Visible = True
                backtoregistrationTimer.Start()
            End If

        Finally
            con.Close()
        End Try


    End Sub

    'Redirect to login in 7secs
    Private Sub redirectionTimer_Tick(sender As Object, e As EventArgs) Handles redirectionTimer.Tick
        Me.Close()
        adminRegistration.Close()
        ScanRFIDLOGIN.Show()
        redirectionTimer.Stop()
    End Sub

    'Redirect to registration in 5secs
    Private Sub backtoregistrationTimer_Tick(sender As Object, e As EventArgs) Handles backtoregistrationTimer.Tick
        adminRegistration.Show()
        Me.Close()
        backtoregistrationTimer.Stop()
    End Sub


    'Display loading animation in 3secs
    Private Sub createdsuccesstimer_Tick(sender As Object, e As EventArgs) Handles createdsuccesstimer.Tick
        imgsuccess.Visible = False
        lblsuccess.Visible = False
        imgloading.Visible = True
        lblredirect.Visible = True
        createdsuccesstimer.Stop()
    End Sub


End Class
