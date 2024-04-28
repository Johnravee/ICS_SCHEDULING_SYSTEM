Imports MySql.Data.MySqlClient

Public Class RFIDREGISTRATION

    Dim fname, mname, lname, sufx, jobPosisyon, emailAdd, workStats, registeredRFID As String
    Private Sub rfidandPinRegistrationforinstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rfidscanpanel.Dock = DockStyle.Fill



        Dim result As DialogResult

        ' Show a message box with OK and Cancel buttons
        result = MessageBox.Show("Do you want to proceed on rfid?", "Confirmation", MessageBoxButtons.OKCancel)

        ' Check which button was clicked
        If result = DialogResult.Cancel Then
            InsertInstructorAccount()
            rfidscanpanel.Hide()
            Return
        End If
        adminRegistration.Hide()
        txtRfidRegister.Focus()

    End Sub







    Private Sub txtRfidRegister_TextChanged(sender As Object, e As EventArgs) Handles txtRfidRegister.TextChanged
        If txtRfidRegister.Text.Length = 10 Then
            registeredRFID = txtRfidRegister.Text
            InsertInstructorAccount()
            ScanDoneLogo.Visible = True
            MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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




    Private Sub InsertInstructorAccount()
        Try

            registeredRFID = EncryptData(registeredRFID)


            DBCon()

            If con.State = ConnectionState.Open Then
                If jobPosisyon = "INSTRUCTOR" Then
                    cmd.CommandText = "INSERT INTO instructor (RFID, Firstname, MiddleName, Surname, Suffix, Position, WorkStatus, email) VALUES (@rfid, @fname, @mname, @surname, @suffix, @position, @workstats, @email)"


                    cmd.Parameters.Clear()
                    cmd.Connection = con

                    cmd.Parameters.AddWithValue("@rfid", registeredRFID)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@mname", mname)
                    cmd.Parameters.AddWithValue("@surname", lname)
                    cmd.Parameters.AddWithValue("@suffix", sufx)
                    cmd.Parameters.AddWithValue("@position", jobPosisyon)
                    cmd.Parameters.AddWithValue("@workstats", workStats)
                    cmd.Parameters.AddWithValue("@email", emailAdd)



                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    addNewInstructor.Show()
                    con.Close()
                Else
                    cmd.CommandText = "INSERT INTO instructor (RFID, Firstname, MiddleName, Surname, Suffix, Position, WorkStatus, email) VALUES (@rfid, @fname, @mname, @surname, @suffix, @position, @workstats, @email)"


                    cmd.Parameters.Clear()
                    cmd.Connection = con

                    cmd.Parameters.AddWithValue("@rfid", registeredRFID)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@mname", mname)
                    cmd.Parameters.AddWithValue("@surname", lname)
                    cmd.Parameters.AddWithValue("@suffix", sufx)
                    cmd.Parameters.AddWithValue("@position", jobPosisyon)
                    cmd.Parameters.AddWithValue("@workstats", workStats)
                    cmd.Parameters.AddWithValue("@email", emailAdd)



                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Instructor account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    ScanRFIDLOGIN.Show()
                    con.Close()
                End If
            Else
                MsgBox("Connection lost.")
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                If ex.Message.Contains("instructor_rfid_unique") Then
                    MessageBox.Show("Duplicate RFID! This RFID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf ex.Message.Contains("instructor_email_unique") Then
                    MessageBox.Show("Duplicate email address! This email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    MessageBox.Show("Duplicate entry error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Finally
            con.Close()
        End Try


    End Sub




End Class
